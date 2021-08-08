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
    class BLL_Sach
    {
        QuanLyEntities db = new QuanLyEntities();
        public static BLL_Sach _Instance;
        public static BLL_Sach Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_Sach();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_Sach() { }
        public List<string> Bll_GetAllMaSach()
        {
            return db.SACHes.Select(p => p.MaSach).ToList();
        }
        private Sach ConvertToSach(SACH a)
        {
            Sach sach = new Sach
            {
                MaSach = a.MaSach,
                TenSach = a.TenSach,
                GiaBan = a.GiaBan,
                GiaNhap = a.GiaNhap,
                SoLuong = a.SoLuong,
                MaNXB = a.MaNXB,
                MaLoaiSach = a.MaLoaiSach,
                TrangThai = a.TrangThai
            };
            return sach;
        }
        private View_Sach ConvertToViewSach(SACH i)
        {
            View_Sach sach = new View_Sach
            {
                MaSach = i.MaSach,
                TenSach = i.TenSach,
                GiaBan = i.GiaBan,
                SoLuong = i.SoLuong,
                TenNXB = i.NHA_XUAT_BAN.TenNXB,
                TenLS = i.LOAI_SACH.TenLoaiSach,
            };
            return sach;
        }
        public void Bll_AddSach(Sach a)
        {
            SACH sach = new SACH
            {
                MaSach = a.MaSach,
                TenSach = a.TenSach,
                GiaBan = a.GiaBan,
                GiaNhap = a.GiaNhap,
                SoLuong = a.SoLuong,
                MaNXB = a.MaNXB,
                MaLoaiSach = a.MaLoaiSach,
                TrangThai = a.TrangThai
            };
            db.SACHes.Add(sach);
            db.SaveChanges();
        }
        public void Bll_EditSach(Sach s)
        {
            SACH tmp = db.SACHes.Find(s.MaSach);
            tmp.TenSach = s.TenSach;
            tmp.GiaBan = s.GiaBan;
            tmp.MaNXB = s.MaNXB;
            tmp.MaLoaiSach = s.MaLoaiSach;
            db.SaveChanges();
        }
        public Sach Bll_GetSachByMaSach(string masach)
        {
            SACH a = db.SACHes.Find(masach);            
            return ConvertToSach(a);
        }
        public List<Sach> Bll_GetSachByLS(string ls)
        {
            List<SACH> l = db.SACHes.Where(p => p.MaLoaiSach == ls).ToList();
            List<Sach> lSach = new List<Sach>();
            foreach(SACH a in l)
            {
                lSach.Add(ConvertToSach(a));
            }
            return lSach;
        }
        public List<Sach> Bll_GetAllSach()
        {
            List<SACH> l = db.SACHes.ToList();
            List<Sach> lSach = new List<Sach>();
            foreach (SACH a in l)
            {
                lSach.Add(ConvertToSach(a));
            }
            return lSach;
        }
        public int Bll_GetGiaNhapByMaSach(string masach)
        {
            return db.SACHes.Find(masach).GiaNhap;
        }
        public int Bll_GetSLByMaSach(string masach)
        {
            return db.SACHes.Find(masach).SoLuong;
        }
        public void Bll_EditSLByMaSach(string masach, int sl)
        {
            SACH tmp = db.SACHes.Find(masach);
            tmp.SoLuong = sl;
            db.SaveChanges();
        }
        public List<Sach> Bll_GetSachByNameAndLS(string name, string ls)
        {
            List<Sach> listSach = new List<Sach>();
            List<Sach> list = new List<Sach>();
            if (ls == "All")
            {
                listSach = Bll_GetAllSach();
            }
            else
            {
                listSach = Bll_GetSachByLS(ls);
            }
            foreach (Sach i in listSach)
            {
                if (i.TenSach.ToLower().Contains(name.ToLower()))
                {
                    list.Add(i);
                }
            }
            return list;
        }
        public void Bll_ChaneTrangThaiSach(string ma)
        {
            SACH a = db.SACHes.Find(ma);
            a.TrangThai = !(a.TrangThai);
            db.SaveChanges();
        }
        public List<string> Bll_GetAllMaSachByTrangThai()
        {
            return db.SACHes.Where(p => p.TrangThai).Select(a => a.MaSach).ToList();
        }
        public List<string> Bll_GetAllMaLS()
        {
            return db.LOAI_SACH.Select(p => p.MaLoaiSach).ToList();
        }
        public string Bll_GetNameNVByMaNV(string manv)
        {
            return db.NHAN_VIEN.Find(manv).HoTen.ToString();
        }
        public int Bll_GetGiaBanByMaSach(string masach)
        {
            return db.SACHes.Find(masach).GiaBan;
        }
        public List<View_Sach> Bll_GetAllViewSachByTrangThai()
        {
            List<View_Sach> list = new List<View_Sach>();
            foreach(SACH i in db.SACHes.Where(p => p.TrangThai == true).ToList())
            {
                list.Add(ConvertToViewSach(i));
            }
            return list;
        }
        public List<SACH> Bll_GetSachByLMS(List<string> LMS)
        {
            List<SACH> listSach = new List<SACH>();
            foreach (string MS in LMS)
            {
                listSach.Add(db.SACHes.Find(MS));
            }
            return listSach;
        }

        public List<SACH> Bll_SapXep(List<string> LMS, string CategorySort)
        {
            switch (CategorySort)
            {
                case "Ten Sach":
                    return (Bll_GetSachByLMS(LMS).OrderBy(s => s.TenSach).ToList());
                case "Gia Ban":
                    return (Bll_GetSachByLMS(LMS).OrderBy(s => s.GiaBan).ToList());
                case "So Luong":
                    return (Bll_GetSachByLMS(LMS).OrderBy(s => s.SoLuong).ToList());
                default:
                    return (Bll_GetSachByLMS(LMS).OrderBy(s => s.MaSach).ToList());
            }
        }
        public List<View_Sach> Bll_SapXepViewSach(List<string> LMS, string CategorySort)
        {
            List<View_Sach> list = new List<View_Sach>();
            foreach(SACH i in Bll_SapXep(LMS, CategorySort))
            {
                list.Add(ConvertToViewSach(i));
            }
            return list;
        }
        public List<Sach> Bll_SapXepSach(List<string> LMS, string CategorySort)
        {
            List<Sach> list = new List<Sach>();
            foreach (SACH i in Bll_SapXep(LMS, CategorySort))
            {
                list.Add(ConvertToSach(i));
            }
            return list;
        }
        public List<View_Sach> Bll_GetViewSachByLSAndTT(string ls)
        {
            List<View_Sach> list = new List<View_Sach>();
            foreach(SACH i in db.SACHes.Where(p => p.MaLoaiSach == ls && p.TrangThai).ToList())
            {
                list.Add(ConvertToViewSach(i));
            }
            return list;
        }
        public List<View_Sach> Bll_GetSachByNameLSAndTT(string name, string ls)
        {
            List<SACH> listSach = new List<SACH>();
            List<View_Sach> list = new List<View_Sach>();
            if (ls == "All")
            {
                listSach = db.SACHes.Where(p => p.TrangThai == true).ToList();
            }
            else
            {
                listSach = db.SACHes.Where(p => p.MaLoaiSach == ls && p.TrangThai).ToList();
            }
            foreach (SACH i in listSach)
            {
                if (i.TenSach.ToLower().Contains(name.ToLower()))
                {
                    list.Add(ConvertToViewSach(i));
                }
            }
            return list;
        }
        public List<string> Bll_GetLabel_Remain_Products()
        {
            List<string> label = new List<string>();
            var books = db.SACHes.Where(p => p.SoLuong > 0 && p.TrangThai.Equals(true))
                                .Select(p => new { p.TenSach, p.SoLuong })
                                .OrderBy(p => p.SoLuong);
            foreach (var book in books)
            {
                label.Add(book.TenSach.ToString());
            }
            return label;
        }
        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
        Func<ChartPoint, string> labelPoint1 = chartpoint => string.Format("{0}", chartpoint.X);

        public SeriesCollection Bll_GetValueChart_Remain_Products()
        {
            SeriesCollection series = new SeriesCollection();
            List<int> values = new List<int>();
            var books = db.SACHes.Where(p => p.SoLuong > 0 && p.TrangThai.Equals(true))
                                .Select(p => new { p.TenSach, p.SoLuong })
                                .OrderBy(p => p.SoLuong);
            foreach (var book in books)
            {
                values.Add(book.SoLuong);
            }
            series.Add(new RowSeries() { Title = "Số lượng: ", Values = new ChartValues<int>(values), LabelPoint = labelPoint1, Foreground = new SolidColorBrush(Colors.White), Fill = new SolidColorBrush(Colors.Khaki) });
            return series;
        }
        public int Bll_getTotal_Books()
        {
            return db.SACHes.Where(p => p.SoLuong > 0 && p.TrangThai.Equals(true)).Count();
        }
    }      
}
