using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using LiveCharts;
using LiveCharts.Wpf;
using PBL3.DTO;

namespace PBL3.BLL
{
    class BLL_BaoCaoDoanhThu
    {
        QuanLyEntities db = new QuanLyEntities();
        public static BLL_BaoCaoDoanhThu _Instance;
        public static BLL_BaoCaoDoanhThu Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_BaoCaoDoanhThu();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_BaoCaoDoanhThu() { }
        private BaoCaoDoanhThu ConvertToBCDT(BAO_CAO_DOANH_THU a)
        {
            BaoCaoDoanhThu bcdt = new BaoCaoDoanhThu
            {
                STT = a.STT,
                MaSach = a.MaSach,
                GiaNhap = a.GiaNhap,
                GiaBan = a.GiaBan,
                SoLuongBan = a.SoLuongBan,
                DoanhThu = a.DoanhThu,
                ThoiGian = a.ThoiGian
            };
            return bcdt;
        }
        public void Bll_AddBaoCaoDoanhThu(BaoCaoDoanhThu a)
        {
            BAO_CAO_DOANH_THU bcdt = new BAO_CAO_DOANH_THU
            {
                STT = a.STT,
                MaSach = a.MaSach,
                GiaNhap = a.GiaNhap,
                GiaBan = a.GiaBan,
                SoLuongBan = a.SoLuongBan,
                DoanhThu = a.DoanhThu,
                ThoiGian = a.ThoiGian
            };
            db.BAO_CAO_DOANH_THU.Add(bcdt);
            db.SaveChanges();
        }
        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
        Func<ChartPoint, string> labelPoint1 = chartpoint => string.Format("{0}", chartpoint.X);

        public SeriesCollection Bll_GetValueChart_Products()
        {
            SeriesCollection series = new SeriesCollection();

            var data = db.BAO_CAO_DOANH_THU.Where(p => p.ThoiGian.Value.Year.Equals(DateTime.Now.Year))
                                           .Select(p => new { p.SACH, p.SoLuongBan })
                                           .GroupBy(p => p.SACH)
                                           .Select(p => new { Sach = p.Key, sumNumber = p.Sum(i => i.SoLuongBan) })
                                           .OrderByDescending(p => p.sumNumber);
            var books = data.Take(5);
            foreach (var book in books)
            {
                series.Add(new PieSeries() { Title = book.Sach.TenSach.ToString(), Values = new ChartValues<int> { book.sumNumber }, DataLabels = true, LabelPoint = labelPoint, Foreground = new SolidColorBrush(Colors.White) });
            }

            return series;
        }
        public int Bll_getTotal_TurnOver()
        {
            int TurnOver = 0;
            foreach (var dt in db.BAO_CAO_DOANH_THU)
            {
                TurnOver += (int)dt.DoanhThu;
            }
            return TurnOver;
        }
        public List<View_BCDT> ChangeViewBCDT(List<BAO_CAO_DOANH_THU> list)
        {
            List<View_BCDT> listview = new List<View_BCDT>();
            foreach (BAO_CAO_DOANH_THU i in list)
            {
                View_BCDT obj = new View_BCDT()
                {
                    STT = i.STT,
                    TenSach = i.SACH.TenSach,
                    GiaNhap = i.GiaNhap,
                    GiaBan = i.GiaBan,
                    SoLuong = i.SoLuongBan,
                    DoanhThu = (int)i.DoanhThu,
                    ThoiGian = (DateTime)i.ThoiGian
                };
                listview.Add(obj);
            }
            return listview;
        }
        public List<View_BCDT> Bll_GetViewBaoCaoDT()
        {
            List<BAO_CAO_DOANH_THU> list = db.BAO_CAO_DOANH_THU.ToList();
            return ChangeViewBCDT(list);
        }
        public List<View_BCDT> Bll_GetViewBCDTFolowNam(int nam)
        {
            List<BAO_CAO_DOANH_THU> list = db.BAO_CAO_DOANH_THU.Where(p => p.ThoiGian.Value.Year == nam).ToList();
            return ChangeViewBCDT(list);
        }
        public List<View_BCDT> Bll_GetViewBCDTFolowNamThang(int nam, int thang)
        {
            List<BAO_CAO_DOANH_THU> list = db.BAO_CAO_DOANH_THU.Where(p => p.ThoiGian.Value.Year == nam && p.ThoiGian.Value.Month == thang).ToList();
            return ChangeViewBCDT(list);
        }
        public List<View_BCDT> Bll_GetViewBCDTFolowNamThangNgay(int nam, int thang, int ngay)
        {
            List<BAO_CAO_DOANH_THU> list = db.BAO_CAO_DOANH_THU.Where(p => p.ThoiGian.Value.Year == nam && p.ThoiGian.Value.Month == thang && p.ThoiGian.Value.Day == ngay).ToList();
            return ChangeViewBCDT(list);
        }
        public List<BaoCaoDoanhThu> Bll_GetDoanhThuBySTT(List<int> LSTT)
        {
            List<BaoCaoDoanhThu> listDoanhThu = new List<BaoCaoDoanhThu>();
            foreach (int STT in LSTT)
            {
                listDoanhThu.Add(ConvertToBCDT(db.BAO_CAO_DOANH_THU.Find(STT)));
            }
            return listDoanhThu;
        }
        public List<BaoCaoDoanhThu> Bll_Sort_DoanhThu(List<int> LSTT, string CategorySort)
        {
            switch (CategorySort)
            {
                case "STT":
                    return Bll_GetDoanhThuBySTT(LSTT).OrderBy(s => s.STT).ToList();
                case "MaSach":
                    return Bll_GetDoanhThuBySTT(LSTT).OrderBy(s => s.MaSach).ToList();
                case "GiaNhap":
                    return Bll_GetDoanhThuBySTT(LSTT).OrderBy(s => s.GiaNhap).ToList();
                case "GiaBan":
                    return Bll_GetDoanhThuBySTT(LSTT).OrderByDescending(s => s.GiaBan).ToList();
                case "SoLuongBan":
                    return Bll_GetDoanhThuBySTT(LSTT).OrderByDescending(s => s.SoLuongBan).ToList();
                case "DoanhThu":
                    return Bll_GetDoanhThuBySTT(LSTT).OrderByDescending(s => s.DoanhThu).ToList();
                default:
                    return Bll_GetDoanhThuBySTT(LSTT).OrderByDescending(s => s.ThoiGian).ToList();
            }
        }
        public List<DateTime> Bll_GetListDate(int numDay)
        {
            List<DateTime> listDate = new List<DateTime>();
            listDate.Add(DateTime.Now);
            for (int i = 0; i < numDay; i++)
            {
                listDate.Add(listDate[i].AddDays(-1));
            }
            listDate.Reverse();
            return listDate;
        }
        public ColumnSeries Bll_GetValueChart_Turnover(int numDay)
        {
            List<int> values = new List<int>();


            foreach (DateTime date in Bll_GetListDate(numDay))
            {
                int value = 0;
                var data = db.BAO_CAO_DOANH_THU.Where(p => p.ThoiGian.Value.Year.Equals(date.Year) && p.ThoiGian.Value.Month.Equals(date.Month) && p.ThoiGian.Value.Day.Equals(date.Day))
                                               .Select(p => new { p.DoanhThu, Day = p.ThoiGian.Value.Day })
                                               .GroupBy(p => p.Day)
                                               .Select(p => new { Day = p.Key, sumTurnover = p.Sum(i => i.DoanhThu) });
                if (data.SingleOrDefault() != null)
                    value = (int)data.SingleOrDefault().sumTurnover;
                values.Add(value);
            }
            ColumnSeries col = new ColumnSeries() { DataLabels = false, Values = new ChartValues<int>(values) };
            return col;
        }
    }
}
