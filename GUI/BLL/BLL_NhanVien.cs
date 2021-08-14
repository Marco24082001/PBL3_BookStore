using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL
{
    class BLL_NhanVien
    {
        QuanLyEntities db = new QuanLyEntities();
        public static BLL_NhanVien _Instance;
        public static BLL_NhanVien Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_NhanVien();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_NhanVien() { }
        public NhanVien Bll_GetNVByMaNV(string manv)
        {
            NHAN_VIEN a = db.NHAN_VIEN.Find(manv);
            NhanVien nv = new NhanVien
            {
                MaNhanVien = a.MaNhanVien,
                HoTen = a.HoTen,
                DanToc = a.DanToc,
                GioiTinh = a.GioiTinh,
                CMND = a.CMND,
                SoDienThoai = a.SoDienThoai,
                QueQuan = a.QueQuan,
                NgaySinh = a.NgaySinh,
                TrangThai = a.TrangThai,
                isAdmin = a.isAdmin
            };
            return nv;
        }
        public List<string> Bll_GetAllMaNV()
        {
            return db.NHAN_VIEN.Select(p => p.MaNhanVien).ToList();
        }
        public void Bll_AddNhanVien(NhanVien a)
        {
            NHAN_VIEN nv = new NHAN_VIEN
            {
                MaNhanVien = a.MaNhanVien,
                HoTen = a.HoTen,
                DanToc = a.DanToc,
                GioiTinh = a.GioiTinh,
                CMND = a.CMND,
                SoDienThoai = a.SoDienThoai,
                QueQuan = a.QueQuan,
                NgaySinh = a.NgaySinh,
                TrangThai = a.TrangThai,
                isAdmin = a.isAdmin
            };
            db.NHAN_VIEN.Add(nv);
            db.SaveChanges();
        }
        public void Bll_EditNhanVien(NhanVien nv)
        {
            NHAN_VIEN tmp = db.NHAN_VIEN.Find(nv.MaNhanVien);
            tmp.HoTen = nv.HoTen;
            tmp.DanToc = nv.DanToc;
            tmp.GioiTinh = nv.GioiTinh;
            tmp.CMND = nv.CMND;
            tmp.SoDienThoai = nv.SoDienThoai;
            tmp.QueQuan = nv.QueQuan;
            tmp.NgaySinh = nv.NgaySinh;
            db.SaveChanges();
        }
        public string Bll_GetNameNVByMaNV(string manv)
        {
            return db.NHAN_VIEN.Find(manv).HoTen.ToString();
        }
        private NhanVien ConvertToNhanVien(NHAN_VIEN a)
        {
            NhanVien nv = new NhanVien
            {
                MaNhanVien = a.MaNhanVien,
                HoTen = a.HoTen,
                DanToc = a.DanToc,
                GioiTinh = a.GioiTinh,
                CMND = a.CMND,
                SoDienThoai = a.SoDienThoai,
                QueQuan = a.QueQuan,
                NgaySinh = a.NgaySinh,
                TrangThai = a.TrangThai,
                isAdmin = a.isAdmin
            };
            return nv;
        }
        public List<NhanVien> Bll_GetAllNhanVien()
        {
            List<NHAN_VIEN> list = db.NHAN_VIEN.ToList();
            List<NhanVien> lnv = new List<NhanVien>();
            foreach(NHAN_VIEN a in list)
            {
                lnv.Add(ConvertToNhanVien(a));
            }
            return lnv;
        }
        public string Bll_SearchAdim()
        {
            return db.NHAN_VIEN.Where(p => p.isAdmin == true).Single().MaNhanVien;
        }
        public void Bll_ChangeTrangThaiNV(string manv)
        {
            NHAN_VIEN a = db.NHAN_VIEN.Find(manv);
            a.TrangThai = !(a.TrangThai);
            db.SaveChanges();
        }
        public List<NhanVien> Bll_GetNhanVienByName(string a)
        {
            List<NhanVien> list = new List<NhanVien>();
            foreach (NHAN_VIEN i in db.NHAN_VIEN.ToList())
            {
                if (i.HoTen.ToLower().Contains(a.ToLower()))
                {
                    list.Add(ConvertToNhanVien(i));
                }
            }
            return list;
        }
        public bool Bll_CheckAdmin(string tk)
        {
            return db.NHAN_VIEN.Find(tk).isAdmin;
        }
        public void Bll_ChangeAdmin(string maNV)
        {
            NHAN_VIEN admin = db.NHAN_VIEN.Where(p => p.isAdmin == true).Single();
            admin.isAdmin = false;
            NHAN_VIEN tmp = db.NHAN_VIEN.Find(maNV);
            tmp.isAdmin = true;
            db.SaveChanges();
        }
        public List<NHAN_VIEN> Bll_GetNhanVienByMNV(List<string> LMNV)
        {
            List<NHAN_VIEN> listNhanVien = new List<NHAN_VIEN>();
            foreach (string MNV in LMNV)
            {
                listNhanVien.Add(db.NHAN_VIEN.Find(MNV));
            }
            return listNhanVien;
        }
        private List<NhanVien> ConvertToListNV(List<NHAN_VIEN> a)
        {
            List<NhanVien> list = new List<NhanVien>();
            foreach(NHAN_VIEN i in a)
            {
                list.Add(ConvertToNhanVien(i));
            }
            return list;
        }
        public List<NhanVien> Bll_SapXepNV(List<string> LMNV, string CategorySort)
        {
            List<NhanVien> list = new List<NhanVien>();
            switch (CategorySort)
            {
                case "HoTen":
                    return ConvertToListNV(Bll_GetNhanVienByMNV(LMNV).OrderBy(s => s.HoTen).ToList());
                case "GioiTinh":
                    return ConvertToListNV(Bll_GetNhanVienByMNV(LMNV).OrderBy(s => s.GioiTinh).ToList());
                case "Ngay Sinh":
                    return ConvertToListNV(Bll_GetNhanVienByMNV(LMNV).OrderBy(s => s.NgaySinh).ToList());
                default:
                    return ConvertToListNV(Bll_GetNhanVienByMNV(LMNV).OrderBy(s => s.MaNhanVien).ToList());
            }
        }
        public int Bll_getTotal_Employees()
        {
            return db.NHAN_VIEN.Where(p => p.TrangThai.Equals(true)).Count();
        }
        public bool Bll_CheckTrangThai(string Ma)
        {
            return db.NHAN_VIEN.Find(Ma).TrangThai;
        }
    }
}
