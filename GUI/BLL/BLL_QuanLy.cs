using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public bool Bll_CheckTKMK(string tk, string mk)
        {
            //QuanLyEntities db = new QuanLyEntities();
            var list = db.TK_NHANVIEN.ToList();
            List<TK_NHANVIEN> tk_NhanVien = list;
            foreach (TK_NHANVIEN i in tk_NhanVien)
            {
                if (tk == i.TKNV && mk == i.Pass)
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
            var tmp = db.NHAN_VIEN.Find(nv.MaNhanVien);
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

        public void BLL_EditMatKhau(TK_NHANVIEN tk)
        {
            var tmp = db.TK_NHANVIEN.Find(tk.TKNV);
            tmp.Pass = tk.Pass;
            db.SaveChanges();
        }

        public void Bll_OffNVByMaNV(string manv)
        {
            var a = db.NHAN_VIEN.Find(manv);
            a.TrangThai = false;
            db.SaveChanges();
        }

        public void Bll_OffSachByMaSach(string ma)
        {
            var a = db.SACHes.Find(ma);
            a.TrangThai = false;
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
    }
}
