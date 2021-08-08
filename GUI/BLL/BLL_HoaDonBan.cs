using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL
{
    class BLL_HoaDonBan
    {
        QuanLyEntities db = new QuanLyEntities();
        public static BLL_HoaDonBan _Instance;
        public static BLL_HoaDonBan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_HoaDonBan();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_HoaDonBan() { }
        public string Bll_CreateHDB()
        {
            try
            {
                int a = db.HOA_DON_BAN.OrderByDescending(x => x.MaDonBan).Take(1).Single().MaDonBan;
                return (a + 1).ToString();
            }
            catch (InvalidOperationException)
            {
                return "1001";
            }
        }
        public void Bll_AddHoaDonBan(HoaDonBan a)
        {
            HOA_DON_BAN hd = new HOA_DON_BAN
            {
                MaDonBan = a.MaDonBan,
                SDT_KH = a.SDT_KH,
                MaNhanVien = a.MaNhanVien,
                NgayBan = a.NgayBan
            };
            db.HOA_DON_BAN.Add(hd);
            db.SaveChanges();
        }
        public int Bll_getTotal_Sales()
        {
            return db.HOA_DON_BAN.Count();
        }
    }
}
