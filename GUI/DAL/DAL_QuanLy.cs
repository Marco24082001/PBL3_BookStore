using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DAL
{
    class DAL_QuanLy
    {
        QuanLyEntities db = new QuanLyEntities();
        public static DAL_QuanLy _Instance;
        public static DAL_QuanLy Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new DAL_QuanLy();
                }
                return _Instance;
            }
            private set { }
        }
        private DAL_QuanLy() { }

        public bool Dal_CheckTKMK(string tk, string mk)
        {
            //QuanLyEntities db = new QuanLyEntities();
            var list = db.TK_NHANVIEN.ToList();
            List<TK_NHANVIEN> tk_NhanVien = list;
            foreach(TK_NHANVIEN i in tk_NhanVien)
            {
                if(tk == i.TKNV && mk == i.Pass)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Dal_CheckAdmin(string tk)
        {
            //QuanLyEntities db = new QuanLyEntities();
            bool a = db.NHAN_VIEN.Find(tk).isAdmin;
            return a;
        }

        public List<SACH> Dal_GetAllSach()
        {
            //QuanLyEntities db = new QuanLyEntities();
            var list = db.SACHes.ToList();
            List<SACH> lSach = list;
            return lSach;
        }

        public List<string> Dal_GetAllMaSach()
        {
            List<String> list = new List<string>();
            list = db.SACHes.Select(p => p.MaSach).ToList();
            return list;
        }

        public string Dal_GetNVByMaNV(string manv)
        {
            return db.NHAN_VIEN.Find(manv).HoTen.ToString();
        }

        public int Dal_GetGiaTienByMaSach(string masach)
        {
            return db.SACHes.Find(masach).GiaBan;
        }
        public List<NHAN_VIEN> Dal_GetAllNhanVien()
        {
            List<NHAN_VIEN> list = new List<NHAN_VIEN>();
            list = db.NHAN_VIEN.ToList();
            return list;
        }
    }
}
