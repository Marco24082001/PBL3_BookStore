using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveCharts;
using LiveCharts.Wpf;
using PBL3.DTO;

namespace PBL3.BLL
{
    class BLL_DoanhSoBanHang
    {
        QuanLyEntities db = new QuanLyEntities();
        public static BLL_DoanhSoBanHang _Instance;
        public static BLL_DoanhSoBanHang Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_DoanhSoBanHang();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_DoanhSoBanHang() { }
        public void Bll_AddDoanhSoBanHang(DoanhSoBanHang a)
        {
            DOANH_SO_BAN_HANG dsbh = new DOANH_SO_BAN_HANG
            {
                STT = a.STT,
                MaNhanVien = a.MaNhanVien,
                DoanhSoBan = a.DoanhSoBan,
                ThoiGian = a.ThoiGian
            };
            db.DOANH_SO_BAN_HANG.Add(dsbh);
            db.SaveChanges();
        }
        private DoanhSoBanHang ConvertToDSBH(DOANH_SO_BAN_HANG a)
        {
            DoanhSoBanHang ds = new DoanhSoBanHang
            {
                STT = a.STT,
                MaNhanVien = a.MaNhanVien,
                DoanhSoBan = a.DoanhSoBan,
                ThoiGian = a.ThoiGian
            };
            return ds;
        }
        public List<DoanhSoBanHang> BLL_GetAllDoanhSoBanHang()
        {
            List<DoanhSoBanHang> list = new List<DoanhSoBanHang>();
            foreach(DOANH_SO_BAN_HANG i in db.DOANH_SO_BAN_HANG.ToList())
            {
                list.Add(ConvertToDSBH(i));
            }
            return list;
        }
        public List<DoanhSoBanHang> Bll_GetDoanhSoBanHangFolowNam(int nam)
        {
            List<DoanhSoBanHang> list = new List<DoanhSoBanHang>();
            foreach(DOANH_SO_BAN_HANG i in db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Value.Year == nam).ToList())
            {
                list.Add(ConvertToDSBH(i));
            }
            return list;
        }
        public List<DoanhSoBanHang> Bll_GetDoanhSoBanHangFolowNamThang(int nam, int thang)
        {
            List<DoanhSoBanHang> list = new List<DoanhSoBanHang>();
            foreach (DOANH_SO_BAN_HANG i in db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Value.Year == nam && p.ThoiGian.Value.Month == thang).ToList())
            {
                list.Add(ConvertToDSBH(i));
            }
            return list;
        }
        public List<DoanhSoBanHang> Bll_GetDoanhSoBanHangFolowNamThangNgay(int nam, int thang, int ngay)
        {
            List<DoanhSoBanHang> list = new List<DoanhSoBanHang>();
            foreach (DOANH_SO_BAN_HANG i in db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Value.Year == nam && p.ThoiGian.Value.Month == thang && p.ThoiGian.Value.Day == ngay).ToList())
            {
                list.Add(ConvertToDSBH(i));
            }
            return list;
        }
        public SeriesCollection Bll_GetValueChart_Sales(int num1, int num2, int num3 = -1)
        {
            SeriesCollection series = new SeriesCollection();
            if (num3 != -1)
            {
                var months = db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Value.Year.Equals(num3) && p.ThoiGian.Value.Month.Equals(num1) || p.ThoiGian.Value.Month.Equals(num2))
                                                 .Select(p => new { Month = p.ThoiGian.Value.Month }).Distinct();
                foreach (var month in months)
                {
                    List<int> values = new List<int>();
                    for (int day = 1; day <= 31; day++)
                    {
                        int value = 0;
                        var data = db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Value.Year.Equals(num3) && p.ThoiGian.Value.Month.Equals(month.Month) && p.ThoiGian.Value.Day.Equals(day))
                                                       .Select(p => new { p.DoanhSoBan, p.ThoiGian.Value.Day })
                                                       .GroupBy(p => p.Day)
                                                       .Select(p => new { Day = p.Key, SumTurnover = p.Sum(i => i.DoanhSoBan) });
                        if (data.SingleOrDefault() != null)
                            value = (int)data.SingleOrDefault().SumTurnover;
                        values.Add(value);
                    }
                    series.Add(new LineSeries() { Title = month.Month.ToString(), Values = new ChartValues<int>(values) });
                }
                return series;
            }
            else
            {
                var years = db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Value.Year.Equals(num1) || p.ThoiGian.Value.Year.Equals(num2))
                                                .Select(p => new { Year = p.ThoiGian.Value.Year }).Distinct();
                foreach (var year in years)
                {
                    List<int> values = new List<int>();
                    for (int month = 1; month <= 12; month++)
                    {
                        int value = 0;
                        var data = db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Value.Year.Equals(year.Year) && p.ThoiGian.Value.Month.Equals(month))
                                                       .Select(p => new { p.DoanhSoBan, p.ThoiGian.Value.Month })
                                                       .GroupBy(p => p.Month)
                                                       .Select(p => new { Month = p.Key, SumSales = p.Sum(i => i.DoanhSoBan) });
                        if (data.SingleOrDefault() != null)
                            value = (int)data.SingleOrDefault().SumSales;
                        values.Add(value);
                    }
                    series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<int>(values) });
                }
                return series;
            }
        }
        public List<DoanhSoBanHang> Bll_GetSalesBySTT(List<int> LSTT)
        {
            List<DoanhSoBanHang> listTurnOver = new List<DoanhSoBanHang>();
            foreach (int STT in LSTT)
            {
                listTurnOver.Add(ConvertToDSBH(db.DOANH_SO_BAN_HANG.Find(STT)));
            }
            return listTurnOver;
        }
        public List<DoanhSoBanHang> Bll_Sort_Sales(List<int> LSTT, string CategorySort)
        {
            switch (CategorySort)
            {
                case "STT":
                    return Bll_GetSalesBySTT(LSTT).OrderBy(s => s.STT).ToList();
                case "MaNhanVien":
                    return Bll_GetSalesBySTT(LSTT).OrderBy(s => s.MaNhanVien).ToList();
                case "DoanhSoBan":
                    return Bll_GetSalesBySTT(LSTT).OrderBy(s => s.DoanhSoBan).ToList();
                default:
                    return Bll_GetSalesBySTT(LSTT).OrderByDescending(s => s.ThoiGian).ToList();
            }
        }
    }
}
