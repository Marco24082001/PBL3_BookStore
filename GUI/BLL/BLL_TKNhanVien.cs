using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL
{
    class BLL_TKNhanVien
    {
        QuanLyEntities db = new QuanLyEntities();
        public static BLL_TKNhanVien _Instance;
        public static BLL_TKNhanVien Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_TKNhanVien();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_TKNhanVien() { }
        public void Bll_AddTKNhanVien(TKNhanVien a)
        {
            TK_NHANVIEN tk = new TK_NHANVIEN { TKNV = a.TKNV, Pass = a.Pass };
            db.TK_NHANVIEN.Add(tk);
            db.SaveChanges();
        }
        public string Bll_GetMKByTK(string tk)
        {
            return db.TK_NHANVIEN.Find(tk).Pass;
        }
        public void BLL_EditMatKhau(TKNhanVien tk)
        {
            TK_NHANVIEN tmp = db.TK_NHANVIEN.Find(tk.TKNV);
            tmp.Pass = tk.Pass;
            db.SaveChanges();
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
        public int Bll_getTotal_Customers()
        {
            return db.KHACH_HANG.Count();
        }
    }
}
