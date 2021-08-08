using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL
{
    class BLL_HoaDonNhap
    {
        QuanLyEntities db = new QuanLyEntities();
        public static BLL_HoaDonNhap _Instance;
        public static BLL_HoaDonNhap Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_HoaDonNhap();
                }
                return _Instance;
            }
            private set { }
        }
        public string Bll_CreateHDN()
        {
            try
            {
                int a = db.HOA_DON_NHAP.OrderByDescending(x => x.MaDonNhap).Take(1).Single().MaDonNhap;
                return (a + 1).ToString();
            }
            catch (InvalidOperationException)
            {
                return "1001";
            }
        }
        public void Bll_AddHoaDonNhap(HoaDonNhap a)
        {
            HOA_DON_NHAP hd = new HOA_DON_NHAP
            {
                MaDonNhap = a.MaDonNhap,
                NgayNhap = a.NgayNhap
            };
            db.HOA_DON_NHAP.Add(hd);
            db.SaveChanges();
        }
    }
}
