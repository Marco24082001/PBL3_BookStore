using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL
{
    class BLL_ChiTietHoaDonNhap
    {
        QuanLyEntities db = new QuanLyEntities();
        public static BLL_ChiTietHoaDonNhap _Instance;
        public static BLL_ChiTietHoaDonNhap Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_ChiTietHoaDonNhap();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_ChiTietHoaDonNhap() { }
        public void Bll_AddChiTietHoaDonNhap(ChiTietHoaDonNhap a)
        {
            CHI_TIET_HOA_DON_NHAP ct = new CHI_TIET_HOA_DON_NHAP
            {
                ID = a.ID,
                MaDonNhap = a.MaDonNhap,
                MaSach = a.MaSach,
                SoLuong = a.SoLuong,
                ThanhTien = a.ThanhTien
            };
            db.CHI_TIET_HOA_DON_NHAP.Add(ct);
            db.SaveChanges();
        }
    }
}
