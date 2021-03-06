using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using PBL3.DTO;

namespace PBL3.BLL
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
                int a = db.HOA_DON_BAN.OrderByDescending(x => x.MaDonBan).Take(1).Single().MaDonBan;                
                return (a+1).ToString();
            }
            catch (InvalidOperationException)
            {
                return "1001";
            }
        }
        public string Bll_CreateHDN()
        {
            try
            {
                int a = db.HOA_DON_NHAP.OrderByDescending(x => x.MaDonNhap).Take(1).Single().MaDonNhap;                
                return (a+1).ToString();
            }
            catch (InvalidOperationException)
            {
                return "1001";
            }
        }

        public bool Bll_CheckTKMK(string tk, string mk)
        {
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
            return db.NHAN_VIEN.Find(tk).isAdmin;
        }


        public List<View_Sach> ChangeViewSach(List<SACH> list)
        {
            List<View_Sach> listSach = new List<View_Sach>();
            foreach (SACH i in list)
            {
                View_Sach obj = new View_Sach()
                {
                    MaSach = i.MaSach,
                    TenSach = i.TenSach,
                    GiaBan = i.GiaBan,
                    SoLuong = i.SoLuong,
                    TenNXB = i.NHA_XUAT_BAN.TenNXB,
                    TenLS = i.LOAI_SACH.TenLoaiSach,                   
                };
                listSach.Add(obj);
            }
            return listSach;
        }
        public List<SACH> Bll_GetAllSach()
        {
            return db.SACHes.ToList();
        }
        public List<SACH> Bll_GetAllSachByTrangThai()
        {
            return db.SACHes.Where(p => p.TrangThai == true).ToList();
        }
        public List<View_Sach> Bll_GetAllViewSachByTrangThai()
        {
            List<SACH> list =  db.SACHes.Where(p => p.TrangThai == true).ToList();
            return ChangeViewSach(list);
        }
        public List<DOANH_SO_BAN_HANG> BLL_GetAllDoanhSoBanHang()
        {
            return db.DOANH_SO_BAN_HANG.ToList();
        }
        public List<View_BCDT> Bll_GetViewBaoCaoDT()
        {
            List<BAO_CAO_DOANH_THU> list = db.BAO_CAO_DOANH_THU.ToList();
            return ChangeViewBCDT(list);
        }
        public List<CHI_TIET_HOA_DON_NHAP> Bll_GetAllChiTietHoaDonNhap()
        {
            return db.CHI_TIET_HOA_DON_NHAP.ToList();
        }
        public List<string> Bll_GetAllMaSach()
        {
            return db.SACHes.Select(p => p.MaSach).ToList();
        }

        public List<string> Bll_GetAllMaSachByTrangThai()
        {
            return db.SACHes.Where(p => p.TrangThai).Select(a => a.MaSach).ToList();
        }

        public List<int> Bll_GetAllMaDonNhap()
        {
            return db.HOA_DON_NHAP.Select(p => p.MaDonNhap).ToList();
        }

        public List<string> Bll_GetAllMaNV()
        {
            return db.NHAN_VIEN.Select(p => p.MaNhanVien).ToList();
        }

        public List<string> Bll_GetAllMaNXB()
        {
            return db.NHA_XUAT_BAN.Select(p => p.MaNXB).ToList();
        }
        public List<string> Bll_GetAllMaLS()
        {
            return db.LOAI_SACH.Select(p => p.MaLoaiSach).ToList();
        }

        public List<string> Bll_GetAllLoaiSach()
        {
            return db.LOAI_SACH.Select(p => p.TenLoaiSach).ToList();
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

        public List<int> Bll_GetAllMaDonBan()
        {
            return db.HOA_DON_BAN.Select(p => p.MaDonBan).ToList();
        }
        public List<string> Bll_GetAllSDT()
        {
            return db.KHACH_HANG.Select(p => p.SDT).ToList();
        }
        public List<SACH> Bll_GetSachByLS(string ls)
        {
            return db.SACHes.Where(p => p.MaLoaiSach == ls).ToList();
        }
        public List<View_Sach> Bll_GetViewSachByLS(string ls)
        {
            List<SACH> list = db.SACHes.Where(p => p.MaLoaiSach == ls).ToList();
            return ChangeViewSach(list);
        }

        public List<SACH> Bll_GetSachByLSAndTT(string ls)
        {
            return db.SACHes.Where(p => p.MaLoaiSach == ls && p.TrangThai).ToList();
        }
        public List<View_Sach> Bll_GetViewSachByLSAndTT(string ls)
        {
            List<SACH> list = db.SACHes.Where(p => p.MaLoaiSach == ls && p.TrangThai).ToList();
            return ChangeViewSach(list);
        }
        public List<View_NhanVien> ChangeViewNV(List<NHAN_VIEN> list)
        {
            List<View_NhanVien> listview = new List<View_NhanVien>();
            foreach (NHAN_VIEN i in list)
            {
                View_NhanVien obj = new View_NhanVien()
                {
                    MaNhanVien = i.MaNhanVien,
                    HoTen = i.HoTen,
                    TKNV = i.TK_NHANVIEN.TKNV,
                    DanToc = i.DanToc,
                    GioiTinh = i.GioiTinh,
                    CMND = i.CMND,
                    SoDienThoai = i.SoDienThoai,
                    QueQuan = i.QueQuan,
                    NgaySinh = i.NgaySinh,
                    TrangThai = i.TrangThai,
                    isAdim = i.isAdmin
                };
                listview.Add(obj);
            }
            return listview;
        }
        public List<NHAN_VIEN> Bll_GetAllNhanVien()
        {
            return db.NHAN_VIEN.ToList();
        }
        public List<NHAN_VIEN> Bll_GetNhanVienByName(string a)
        {
            List<NHAN_VIEN> list = new List<NHAN_VIEN>();
            foreach (NHAN_VIEN i in db.NHAN_VIEN.ToList())
            {
                if (i.HoTen.ToLower().Contains(a.ToLower()))
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
        public void Bll_ChangeAdmin(string maNV)
        {
            NHAN_VIEN admin = db.NHAN_VIEN.Where(p => p.isAdmin == true).Single();
            admin.isAdmin = false;
            NHAN_VIEN tmp = db.NHAN_VIEN.Find(maNV);
            tmp.isAdmin = true;
            db.SaveChanges();
        }
        public string Bll_SearchAdim()
        {
            return db.NHAN_VIEN.Where(p => p.isAdmin == true).Single().MaNhanVien;
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
            foreach (SACH i in listSach)
            {
                if (i.TenSach.ToLower().Contains(name.ToLower()))
                {
                    list.Add(i);
                }
            }
            return list;
        }

        public List<View_Sach> Bll_GetSachByNameLSAndTT(string name, string ls)
        {
            List<SACH> listSach = new List<SACH>();
            List<SACH> list = new List<SACH>();
            if (ls == "All")
            {
                listSach = Bll_GetAllSachByTrangThai();
            }
            else
            {
                listSach = Bll_GetSachByLSAndTT(ls);
            }
            foreach (SACH i in listSach)
            {
                if (i.TenSach.ToLower().Contains(name.ToLower()))
                {
                    list.Add(i);
                }
            }
            return ChangeViewSach(list);
        }

        public List<SACH> Bll_GetSachByMS(List<string> LMS)
        {
            List<SACH> listSach = new List<SACH>();
            foreach (string MS in LMS)
            {
                listSach.Add(db.SACHes.Find(MS));
            }
            return listSach;
        }

        public List<NHAN_VIEN> Bll_GetSachByMNV(List<string> LMNV)
        {
            List<NHAN_VIEN> listNhanVien = new List<NHAN_VIEN>();
            foreach (string MNV in LMNV)
            {
                listNhanVien.Add(db.NHAN_VIEN.Find(MNV));
            }
            return listNhanVien;
        }

        public List<DOANH_SO_BAN_HANG> Bll_GetSalesBySTT(List<int> LSTT)
        {
            List<DOANH_SO_BAN_HANG> listTurnOver = new List<DOANH_SO_BAN_HANG>();
            foreach (int STT in LSTT)
            {
                listTurnOver.Add(db.DOANH_SO_BAN_HANG.Find(STT));
            }
            return listTurnOver;
        }

        public List<BAO_CAO_DOANH_THU> Bll_GetDoanhThuBySTT(List<int> LSTT)
        {
            List<BAO_CAO_DOANH_THU> listDoanhThu = new List<BAO_CAO_DOANH_THU>();
            foreach (int STT in LSTT)
            {
                listDoanhThu.Add(db.BAO_CAO_DOANH_THU.Find(STT));
            }
            return listDoanhThu;
        }

        public List<SACH> Bll_SapXepSach(List<string> LMS, string CategorySort)
        {
            switch (CategorySort)
            {
                case "Ten Sach":
                    return (Bll_GetSachByMS(LMS).OrderBy(s => s.TenSach).ToList());
                case "Gia Ban":
                    return (Bll_GetSachByMS(LMS).OrderBy(s => s.GiaBan).ToList());
                case "So Luong":
                    return (Bll_GetSachByMS(LMS).OrderBy(s => s.SoLuong).ToList());
                default:
                    return (Bll_GetSachByMS(LMS).OrderBy(s => s.MaSach).ToList());
            }
        }

        public List<View_Sach> Bll_SapXepViewSach(List<string> LMS, string CategorySort)
        {
            return ChangeViewSach(Bll_SapXepSach(LMS, CategorySort));
        }

        public List<NHAN_VIEN> Bll_SapXepNV(List<string> LMNV, string CategorySort)
        {
            switch (CategorySort)
            {
                case "HoTen":
                    return (Bll_GetSachByMNV(LMNV).OrderBy(s => s.HoTen).ToList());
                case "GioiTinh":
                    return (Bll_GetSachByMNV(LMNV).OrderBy(s => s.GioiTinh).ToList());              
                case "Ngay Sinh":
                    return (Bll_GetSachByMNV(LMNV).OrderBy(s => s.NgaySinh).ToList());
                default:
                    return (Bll_GetSachByMNV(LMNV).OrderBy(s => s.MaNhanVien).ToList());
            }
        }

        public List<DOANH_SO_BAN_HANG> Bll_Sort_Sales(List<int> LSTT, string CategorySort)
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

        public List<BAO_CAO_DOANH_THU> Bll_Sort_DoanhThu(List<int> LSTT, string CategorySort)
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

        public List<View_BCDT> Bll_GetViewBCDTFolowNam(int nam)
        {
            List<BAO_CAO_DOANH_THU> list = db.BAO_CAO_DOANH_THU.Where(p => p.ThoiGian.Year == nam).ToList();
            return ChangeViewBCDT(list);
        }
        public List<View_BCDT> Bll_GetViewBCDTFolowNamThang(int nam, int thang)
        {
            List<BAO_CAO_DOANH_THU> list = db.BAO_CAO_DOANH_THU.Where(p => p.ThoiGian.Year == nam && p.ThoiGian.Month == thang).ToList();
            return ChangeViewBCDT(list);
        }
        public List<View_BCDT> Bll_GetViewBCDTFolowNamThangNgay(int nam, int thang, int ngay)
        {
            List<BAO_CAO_DOANH_THU> list = db.BAO_CAO_DOANH_THU.Where(p => p.ThoiGian.Year == nam && p.ThoiGian.Month == thang && p.ThoiGian.Day == ngay).ToList();
            return ChangeViewBCDT(list);
        }

        public List<DOANH_SO_BAN_HANG> Bll_GetDoanhSoBanHangFolowNam(int nam)
        {
            return db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Year == nam).ToList();
        }
        public List<DOANH_SO_BAN_HANG> Bll_GetDoanhSoBanHangFolowNamThang(int nam, int thang)
        {
            return db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Year == nam && p.ThoiGian.Month == thang).ToList();
        }
        public List<DOANH_SO_BAN_HANG> Bll_GetDoanhSoBanHangFolowNamThangNgay(int nam, int thang, int ngay)
        {
            return db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Year == nam && p.ThoiGian.Month == thang && p.ThoiGian.Day == ngay).ToList();
        }

        public SeriesCollection Bll_GetValueChart_Sales(int num1, int num2, int num3 = -1)
        {
            SeriesCollection series = new SeriesCollection();
            if (num3 != -1)
            {
                var months = db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Year.Equals(num3) && p.ThoiGian.Month.Equals(num1) || p.ThoiGian.Month.Equals(num2))
                                                 .Select(p => new { Month = p.ThoiGian.Month }).Distinct();
                foreach (var month in months)
                {
                    List<int> values = new List<int>();
                    for (int day = 1; day <= 31; day++)
                    {
                        int value = 0;
                        var data = db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Year.Equals(num3) && p.ThoiGian.Month.Equals(month.Month) && p.ThoiGian.Day.Equals(day))
                                                       .Select(p => new { p.DoanhSoBan, p.ThoiGian.Day })
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
                var years = db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Year.Equals(num1) || p.ThoiGian.Year.Equals(num2))
                                                .Select(p => new { Year = p.ThoiGian.Year }).Distinct();
                foreach (var year in years)
                {
                    List<int> values = new List<int>();
                    for (int month = 1; month <= 12; month++)
                    {
                        int value = 0;
                        var data = db.DOANH_SO_BAN_HANG.Where(p => p.ThoiGian.Year.Equals(year.Year) && p.ThoiGian.Month.Equals(month))
                                                       .Select(p => new { p.DoanhSoBan, p.ThoiGian.Month })
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

        public List<DateTime> Bll_GetListDate(int numDay)
        {
            List<DateTime> listDate = new List<DateTime>();
            listDate.Add(DateTime.Now);
            for (int i = 0; i <= numDay; i++)
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
                var data = db.BAO_CAO_DOANH_THU.Where(p => p.ThoiGian.Year.Equals(date.Year) && p.ThoiGian.Month.Equals(date.Month) && p.ThoiGian.Day.Equals(date.Day))
                                               .Select(p => new { p.DoanhThu, Day = p.ThoiGian.Day })
                                               .GroupBy(p => p.Day)
                                               .Select(p => new { Day = p.Key, sumTurnover = p.Sum(i => i.DoanhThu) });
                if (data.SingleOrDefault() != null)
                    value = (int)data.SingleOrDefault().sumTurnover;
                values.Add(value);
            }
            ColumnSeries col = new ColumnSeries() { DataLabels = false, Values = new ChartValues<int>(values)};
            return col;
        }

        Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
        Func<ChartPoint, string> labelPoint1 = chartpoint => string.Format("{0}", chartpoint.X);

        public SeriesCollection Bll_GetValueChart_Products()
        {
            SeriesCollection series = new SeriesCollection();
            
            var data = db.BAO_CAO_DOANH_THU.Where(p => p.ThoiGian.Year.Equals(DateTime.Now.Year))
                                           .Select(p => new { p.SACH, p.SoLuongBan })
                                           .GroupBy(p => p.SACH)
                                           .Select(p => new { Sach = p.Key, sumNumber = p.Sum(i => i.SoLuongBan) })
                                           .OrderByDescending(p => p.sumNumber);
            var books = data.Take(5);
            foreach(var book in books)
            {
                series.Add(new PieSeries() { Title = book.Sach.TenSach.ToString(), Values = new ChartValues<int> { book.sumNumber }, DataLabels = true, LabelPoint = labelPoint, Foreground = new SolidColorBrush(Colors.White) });
            }

            return series;
        }

        public SeriesCollection Bll_GetValueChart_Remain_Products()
        {
            SeriesCollection series = new SeriesCollection();
            List<int> values = new List<int>();
            var books = db.SACHes.Where(p => p.SoLuong > 0 && p.TrangThai.Equals(true))
                                .Select(p => new { p.TenSach, p.SoLuong })
                                .OrderBy(p => p.SoLuong);
            foreach(var book in books)
            {
                values.Add(book.SoLuong);
            }
            series.Add(new RowSeries() { Title = "Số lượng: ", Values = new ChartValues<int>(values), LabelPoint = labelPoint1, Foreground = new SolidColorBrush(Colors.White), Fill = new SolidColorBrush(Colors.Khaki) });
            return series;
        }

        public List<string> Bll_GetLabel_Remain_Products()
        {
            List<string> label = new List<string>();
            var books = db.SACHes.Where(p => p.SoLuong > 0 && p.TrangThai.Equals(true))
                                .Select(p => new { p.TenSach, p.SoLuong })
                                .OrderBy(p => p.SoLuong);
            foreach(var book in books)
            {
                label.Add(book.TenSach.ToString());
            }
            return label;
        }

        public int Bll_getTotal_Sales()
        {
            return db.HOA_DON_BAN.Count();
        }

        public int Bll_getTotal_Customers()
        {
            return db.KHACH_HANG.Count();
        }

        public int Bll_getTotal_Categorys()
        {
            return db.LOAI_SACH.Count();
        }

        public int Bll_getTotal_TurnOver()
        {
            int TurnOver = 0;
            foreach(var dt in db.BAO_CAO_DOANH_THU)
            {
                TurnOver += (int)dt.DoanhThu;
            }
            return TurnOver;
        }

        public int Bll_getTotal_Books()
        {
            return db.SACHes.Where(p => p.SoLuong > 0 && p.TrangThai.Equals(true)).Count();
        }

        public int Bll_getTotal_Employees()
        {
            return db.NHAN_VIEN.Where(p => p.TrangThai.Equals(true)).Count();
        }

        public string Bll_GetMKByTK(string tk)
        {
            return db.TK_NHANVIEN.Find(tk).Pass;
        }
    }   
}
