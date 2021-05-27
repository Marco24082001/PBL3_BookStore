using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI.BLL
{
    class BLL_QuanLy
    {
        QuanLyEntities db = new QuanLyEntities();
        public static BLL_QuanLy _Instance;
        public static BLL_QuanLy Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_QuanLy();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_QuanLy() { }

        public string Bll_CreateHDB()
        {
            try
            {
                string a = db.HOA_DON_BAN.OrderByDescending(x => x.MaDonBan).Take(1).Single().MaDonBan;
                string s = "";
                for (int i = 3; i < a.Length; i++)
                {
                    s += a[i];
                }
                int so = Convert.ToInt32(s) + 1;
                s = "HDB" + so.ToString();
                return s;
            }
            catch(InvalidOperationException)
            {
                return "HDB1";
            }
        }
        public string Bll_CreateHDN()
        {
            try
            {
                string a = db.HOA_DON_NHAP.OrderByDescending(x => x.MaDonNhap).Take(1).Single().MaDonNhap;
                string s = "";
                for (int i = 3; i < a.Length; i++)
                {
                    s += a[i];
                }
                int so = Convert.ToInt32(s) + 1;
                s = "HDN" + so.ToString();
                return s;
            }
            catch(InvalidOperationException)
            {
                return "HDN1";
            }            
        }

        public bool Bll_CheckTKMK(string tk, string mk)
        {
            //QuanLyEntities db = new QuanLyEntities();
            List<TK_NHANVIEN> list = db.TK_NHANVIEN.ToList();
            foreach (TK_NHANVIEN i in list)
            {
                if (tk == i.TKNV && mk == i.Pass && db.NHAN_VIEN.Find(i.TKNV).TrangThai)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Bll_CheckAdmin(string tk)
        {
            //QuanLyEntities db = new QuanLyEntities();
            bool a = db.NHAN_VIEN.Find(tk).isAdmin;
            return a;
        }

        public List<SACH> Bll_GetAllSach()
        {
            //QuanLyEntities db = new QuanLyEntities();
            var list = db.SACHes.ToList();
            List<SACH> lSach = list;
            return lSach;
        }
        public List<SACH> Bll_GetAllSachByTrangThai()
        {
            return db.SACHes.Where(p => p.TrangThai == true).ToList();
        }
        public List<DOANH_SO_BAN_HANG> BLL_GetAllDoanhSoBanHang()
        {
            return db.DOANH_SO_BAN_HANG.ToList();
        }
        public List<BAO_CAO_DOANH_THU> Bll_GetAllBaoCaoDT()
        {
            return db.BAO_CAO_DOANH_THU.ToList();
        }
        public List<CHI_TIET_HOA_DON_NHAP> Bll_GetAllChiTietHoaDonNhap()
        {
            List<CHI_TIET_HOA_DON_NHAP> l = db.CHI_TIET_HOA_DON_NHAP.ToList();
            return l;
        }
        public List<string> Bll_GetAllMaSach()
        {
            List<String> list = new List<string>();
            list = db.SACHes.Select(p => p.MaSach).ToList();
            return list;
        }

        public List<string> Bll_GetAllMaSachByTrangThai()
        {
            return db.SACHes.Where(p => p.TrangThai).Select(a => a.MaSach).ToList();
        }

        public List<string> Bll_GetAllMaDonNhap()
        {
            List<String> list = new List<string>();
            list = db.HOA_DON_NHAP.Select(p => p.MaDonNhap).ToList();
            return list;
        }

        public List<string> Bll_GetAllMaNV()
        {
            return db.NHAN_VIEN.Select(p => p.MaNhanVien).ToList();
        }

        public List<string> Bll_GetAllMaNXB()
        {
            List<string> list = new List<string>();
            list = db.NHA_XUAT_BAN.Select(p => p.MaNXB).ToList();
            return list;
        }
        public List<string> Bll_GetAllMaLS()
        {
            List<string> list = new List<string>();
            list = db.LOAI_SACH.Select(p => p.MaLoaiSach).ToList();
            return list;
        }

        public string Bll_GetNameNVByMaNV(string manv)
        {
            return db.NHAN_VIEN.Find(manv).HoTen.ToString();
        }

        public NHAN_VIEN Bll_GetNVByMaNV(string manv)
        {
            return db.NHAN_VIEN.Find(manv);
        }
        public SACH Bll_GetSachByMaSach(string masach)
        {
            return db.SACHes.Find(masach);
        }
        public TK_NHANVIEN Bll_GetTKByMaNV(string manv)
        {
            return db.TK_NHANVIEN.Find(manv);
        }

        public int Bll_GetGiaBanByMaSach(string masach)
        {
            return db.SACHes.Find(masach).GiaBan;
        }

        public int Bll_GetGiaNhapByMaSach(string masach)
        {
            return db.SACHes.Find(masach).GiaNhap;
        }
        public int Bll_GetSLByMaSach(string masach)
        {
            return db.SACHes.Find(masach).SoLuong;
        }
        public string Bll_GetKHBySDT(string sdt)
        {
            return db.KHACH_HANG.Find(sdt).HoTen;
        }

        public List<string> Bll_GetAllMaDonBan()
        {
            List<string> list = new List<string>();
            list = db.HOA_DON_BAN.Select(p => p.MaDonBan).ToList();
            return list;
        }
        public List<string> Bll_GetAllSDT()
        {
            List<string> list = new List<string>();
            list = db.KHACH_HANG.Select(p => p.SDT).ToList();
            return list;
        }
        public List<SACH> Bll_GetSachByLS(string ls)
        {
            return db.SACHes.Where(p => p.MaLoaiSach == ls).ToList();
        }

        public List<NHAN_VIEN> Bll_GetAllNhanVien()
        { 
            List<NHAN_VIEN> list = new List<NHAN_VIEN>();
            list = db.NHAN_VIEN.ToList();
            return list;
        }
        public List<NHAN_VIEN> Bll_GetNhanVienByName(string a)
        {
            List<NHAN_VIEN> list = new List<NHAN_VIEN>();
            foreach(NHAN_VIEN i in Bll_GetAllNhanVien())
            {
                if(i.HoTen.ToLower().Contains(a.ToLower()))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public void Bll_AddNhanVien(NHAN_VIEN nv)
        {
            db.NHAN_VIEN.Add(nv);
            db.SaveChanges();
        }

        public void Bll_AddTKNhanVien(TK_NHANVIEN tk)
        {
            db.TK_NHANVIEN.Add(tk);
            db.SaveChanges();
        }
        public void Bll_AddSach(SACH a)
        {
            db.SACHes.Add(a);
            db.SaveChanges();
        }
        public void Bll_AddKhachHang(KHACH_HANG a)
        {
            db.KHACH_HANG.Add(a);
            db.SaveChanges();
        }
        public void Bll_AddHoaDonBan(HOA_DON_BAN a)
        {
            db.HOA_DON_BAN.Add(a);
            db.SaveChanges();
        }

        public void Bll_AddHoaDonNhap(HOA_DON_NHAP a)
        {
            db.HOA_DON_NHAP.Add(a);
            db.SaveChanges();
        }
        public void Bll_AddChiTietHoaDonBan(CHI_TIET_HOA_DON_BAN a)
        {
            db.CHI_TIET_HOA_DON_BAN.Add(a);
            db.SaveChanges();
        }
        public void Bll_AddChiTietHoaDonNhap(CHI_TIET_HOA_DON_NHAP a)
        {
            db.CHI_TIET_HOA_DON_NHAP.Add(a);
            db.SaveChanges();
        }

        public void Bll_EditSLByMaSach(string masach, int sl)
        {
            var tmp = db.SACHes.Find(masach);
            tmp.SoLuong = sl;
            db.SaveChanges();
        }
        public void Bll_EditNhanVien(NHAN_VIEN nv)
        {
            NHAN_VIEN tmp = db.NHAN_VIEN.Find(nv.MaNhanVien);
            tmp.HoTen = nv.HoTen;
            tmp.DanToc = nv.DanToc;
            tmp.GioiTinh = nv.GioiTinh;
            tmp.CMND = nv.CMND;
            tmp.SoDienThoai = nv.SoDienThoai;
            tmp.QueQuan = nv.QueQuan;
            tmp.NgaySinh = nv.NgaySinh;
            tmp.TrangThai = nv.TrangThai;
            tmp.isAdmin = nv.isAdmin;
            db.SaveChanges();
        }
        public void Bll_EditSach(SACH s)
        {
            SACH tmp = db.SACHes.Find(s.MaSach);
            tmp.TenSach = s.TenSach;
            tmp.GiaBan = s.GiaBan;
            tmp.NHA_XUAT_BAN = s.NHA_XUAT_BAN;
            tmp.LOAI_SACH = s.LOAI_SACH;
            db.SaveChanges();
        }

        public void BLL_EditMatKhau(TK_NHANVIEN tk)
        {
            var tmp = db.TK_NHANVIEN.Find(tk.TKNV);
            tmp.Pass = tk.Pass;
            db.SaveChanges();
        }

        public void Bll_ChangeTrangThaiNV(string manv)
        {
            var a = db.NHAN_VIEN.Find(manv);
            a.TrangThai = !(a.TrangThai);
            db.SaveChanges();
        }

        public void Bll_ChaneTrangThaiSach(string ma)
        {
            var a = db.SACHes.Find(ma);
            a.TrangThai = !(a.TrangThai);
            db.SaveChanges();
        }

        public void Bll_AddLoaiSach(LOAI_SACH ls)
        {
            db.LOAI_SACH.Add(ls);
            db.SaveChanges();
        }
        public void Bll_AddBaoCaoDoanhThu(BAO_CAO_DOANH_THU bcdt)
        {
            db.BAO_CAO_DOANH_THU.Add(bcdt);
            db.SaveChanges();
        }
        public void Bll_AddDoanhSoBanHang(DOANH_SO_BAN_HANG ds)
        {
            db.DOANH_SO_BAN_HANG.Add(ds);
            db.SaveChanges();
        }
        public void Bll_AddNXB(NHA_XUAT_BAN nxb)
        {
            db.NHA_XUAT_BAN.Add(nxb);
            db.SaveChanges();
        }
        
        public List<SACH> Bll_GetSachByNameAndLS(string name, string ls)
        {
            List<SACH> listSach = new List<SACH>();
            List<SACH> list = new List<SACH>();
            if (ls == "All")
            {
                listSach = Bll_GetAllSach();
            }
            else
            {
                listSach = Bll_GetSachByLS(ls);
            }
            foreach(SACH i in listSach)
            {
                if(i.TenSach.ToLower().Contains(name.ToLower()))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public List<SACH> Bll_GetSachByMS(List<string> LMS)
        {
            List<SACH> listSach = new List<SACH>();
            foreach(string MS in LMS)
            {
                listSach.Add(db.SACHes.Find(MS));
            }
            return listSach;
        }

        public List<NHAN_VIEN> Bll_GetSachByMNV(List<string> LMNV)
        {
            List<NHAN_VIEN> listNhanVien = new List<NHAN_VIEN>();
            foreach(string MNV in LMNV)
            {
                listNhanVien.Add(db.NHAN_VIEN.Find(MNV));
            }
            return listNhanVien;
        }

        public List<SACH> Bll_Sort(List<string> LMS, string CategorySort)
        {
            switch(CategorySort)
            {
                case "MaSach":
                    return Bll_GetSachByMS(LMS).OrderBy(s => s.MaSach).ToList();
                case "TenSach":
                    return Bll_GetSachByMS(LMS).OrderBy(s => s.TenSach).ToList();
                case "GiaBan":
                    return Bll_GetSachByMS(LMS).OrderBy(s => s.GiaBan).ToList();
                case "GiaNhap":
                    return Bll_GetSachByMS(LMS).OrderBy(s => s.GiaNhap).ToList();
                case "SoLuong":
                    return Bll_GetSachByMS(LMS).OrderBy(s => s.SoLuong).ToList();
                case "MaLoaiSach":
                    return Bll_GetSachByMS(LMS).OrderBy(s => s.MaLoaiSach).ToList();
                case "MaNXB":
                    return Bll_GetSachByMS(LMS).OrderBy(s => s.MaNXB).ToList();
                default:
                    return Bll_GetSachByMS(LMS).OrderBy(s => s.MaSach).ToList();
            }
        }

        public List<NHAN_VIEN> Bll_Sort_NhanVien(List<string> LMNV, string CategorySort)
        {
            switch (CategorySort)
            {
                case "MaNhanVien":
                    return Bll_GetSachByMNV(LMNV).OrderBy(s => s.MaNhanVien).ToList();
                case "HoTen":
                    return Bll_GetSachByMNV(LMNV).OrderBy(s => s.HoTen).ToList();
                case "DanToc":
                    return Bll_GetSachByMNV(LMNV).OrderBy(s => s.DanToc).ToList();
                case "GioiTinh":
                    return Bll_GetSachByMNV(LMNV).OrderBy(s => s.GioiTinh).ToList();
                case "CMND":
                    return Bll_GetSachByMNV(LMNV).OrderBy(s => s.CMND).ToList();
                case "SoDienThoai":
                    return Bll_GetSachByMNV(LMNV).OrderBy(s => s.SoDienThoai).ToList();
                case "QueQuan":
                    return Bll_GetSachByMNV(LMNV).OrderBy(s => s.QueQuan).ToList();
                case "NgaySinh":
                    return Bll_GetSachByMNV(LMNV).OrderBy(s => s.NgaySinh).ToList();
                default:
                    return Bll_GetSachByMNV(LMNV).OrderBy(s => s.MaNhanVien).ToList();
            }
        
        }
        public List<BAO_CAO_DOANH_THU> Bll_GetBaoCaoDoanhThuFolowNam(int nam)
        {
            return db.BAO_CAO_DOANH_THU.Where(p => p.ThoiGian.Value.Year == nam).ToList();
        }
        public List<BAO_CAO_DOANH_THU> Bll_GetBaoCaoDoanhThuFolowNamThang(int nam, int thang)
        {
            return db.BAO_CAO_DOANH_THU.Where(p => p.ThoiGian.Value.Year == nam && p.ThoiGian.Value.Month == thang).ToList();
        }
        public List<BAO_CAO_DOANH_THU> Bll_GetBaoCaoDoanhThuFolowNamThangNgay(int nam, int thang, int ngay)
        {
            return db.BAO_CAO_DOANH_THU.Where(p => p.ThoiGian.Value.Year == nam && p.ThoiGian.Value.Month == thang && p.ThoiGian.Value.Day == ngay).ToList();
        }

        public List<DOANH_SO_BAN_HANG> Bll_GetDoanhSoBanHangFolowNam(int nam)
        {
            return db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Value.Year == nam).ToList();
        }
        public List<DOANH_SO_BAN_HANG> Bll_GetDoanhSoBanHangFolowNamThang(int nam, int thang)
        {
            return db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Value.Year == nam && p.ThoiGian.Value.Month == thang).ToList();
        }
        public List<DOANH_SO_BAN_HANG> Bll_GetDoanhSoBanHangFolowNamThangNgay(int nam, int thang, int ngay)
        {
            return db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Value.Year == nam && p.ThoiGian.Value.Month == thang && p.ThoiGian.Value.Day == ngay).ToList();
        }

        //public SeriesCollection Bll_GetValueChart(int num1, int num2, int num3 = -1)
        //{
        //    SeriesCollection series = new SeriesCollection();
        //    //var years = db.DOANH_SO_BAN_HANG.Select(p => new { Year = p.ThoiGian.Value.Year }).Distinct();

        //    //foreach (var year in years)
        //    //{
        //    //    List<int> values = new List<int>();
        //    //    for (int month = 1; month <= 11; month++)
        //    //    {
        //    //        int value = 0;
        //    //        var data = db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Value.Year.Equals(year.Year) && p.ThoiGian.Value.Month.Equals(month))
        //    //                                       .Select(p => new { p.DoanhSoBan, p.ThoiGian.Value.Month })
        //    //                                       .GroupBy(p => p.Month)
        //    //                                       .Select(p => new { Month = p.Key, SumTurnover = p.Sum(i => i.DoanhSoBan) });
        //    //        if (data.SingleOrDefault() != null)
        //    //            value = (int)data.SingleOrDefault().SumTurnover;
        //    //        values.Add(value);
        //    //    }
        //    //    series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<int>(values) });
        //    //}
        //    //return series;
        //    if (num3 != -1)
        //    {
        //        var months = db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Value.Year.Equals(num3) && p.ThoiGian.Value.Month.Equals(num1) || p.ThoiGian.Value.Month.Equals(num2))
        //                                         .Select(p => new { Month = p.ThoiGian.Value.Month }).Distinct();
        //        foreach(var month in months)
        //        {
        //            List<int> values = new List<int>();
        //            for (int day = 1; day <= 31; day++)
        //            {
        //                int value = 0;
        //                var data = db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Value.Year.Equals(num3) && p.ThoiGian.Value.Month.Equals(month.Month) && p.ThoiGian.Value.Day.Equals(day))
        //                                               .Select(p => new { p.DoanhSoBan, p.ThoiGian.Value.Day })
        //                                               .GroupBy(p => p.Day)
        //                                               .Select(p => new { Day = p.Key, SumTurnover = p.Sum(i => i.DoanhSoBan) });
        //                if (data.SingleOrDefault() != null)
        //                    value = (int)data.SingleOrDefault().SumTurnover;
        //                values.Add(value);
        //            }
        //            series.Add(new LineSeries() { Title = month.Month.ToString(), Values = new ChartValues<int>(values) });
        //        }
        //        return series;
        //    }
        //    else
        //    {
        //        var years = db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Value.Year.Equals(num1) || p.ThoiGian.Value.Year.Equals(num2))
        //                                        .Select(p => new { Year = p.ThoiGian.Value.Year }).Distinct();
        //        foreach(var year in years)
        //        {
        //            List<int> values = new List<int>();
        //            for (int month = 1; month <= 12; month++)
        //            {
        //                int value = 0;
        //                var data = db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Value.Year.Equals(year.Year) && p.ThoiGian.Value.Month.Equals(month))
        //                                               .Select(p => new { p.DoanhSoBan, p.ThoiGian.Value.Month })
        //                                               .GroupBy(p => p.Month)
        //                                               .Select(p => new { Month = p.Key, SumTurnover = p.Sum(i => i.DoanhSoBan) });
        //                if (data.SingleOrDefault() != null)
        //                    value = (int)data.SingleOrDefault().SumTurnover;
        //                values.Add(value);
        //            }
        //            series.Add(new LineSeries() { Title = year.Year.ToString(), Values = new ChartValues<int>(values) });
        //        }
        //        return series;
        //    }
        //}
    }   
}
