using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL
{
    class BLL_ChiTietHoaDonBan
    {
        QuanLyEntities db = new QuanLyEntities();
        public static BLL_ChiTietHoaDonBan _Instance;
        public static BLL_ChiTietHoaDonBan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_ChiTietHoaDonBan();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_ChiTietHoaDonBan() { }
        public void Bll_AddChiTietHoaDonBan(ChiTietHoaDonBan a)
        {
            CHI_TIET_HOA_DON_BAN ct = new CHI_TIET_HOA_DON_BAN
            {
                ID = a.ID,
                MaDonBan = a.MaDonBan,
                MaSach = a.MaSach,
                DonGia = a.DonGia,
                SoLuong = a.SoLuong,
                ThanhTien = a.ThanhTien
            };
            db.CHI_TIET_HOA_DON_BAN.Add(ct);
            db.SaveChanges();
        }
    }
}
