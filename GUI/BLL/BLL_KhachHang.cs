using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL
{
    class BLL_KhachHang
    {
        QuanLyEntities db = new QuanLyEntities();
        public static BLL_KhachHang _Instance;
        public static BLL_KhachHang Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_KhachHang();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_KhachHang() { }
        public void Bll_AddKhachHang(KhachHang a)
        {
            KHACH_HANG kh = new KHACH_HANG
            {
                SDT = a.SDT,
                HoTen = a.HoTen
            };
            db.KHACH_HANG.Add(kh);
            db.SaveChanges();
        }
        public List<string> Bll_GetAllSDT()
        {
            return db.KHACH_HANG.Select(p => p.SDT).ToList();
        }
        public string Bll_GetKHBySDT(string sdt)
        {
            return db.KHACH_HANG.Find(sdt).HoTen;
        }
    }
}
