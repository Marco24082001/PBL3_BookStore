using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL
{
    class BLL_NhaXuatBan
    {
        QuanLyEntities db = new QuanLyEntities();
        public static BLL_NhaXuatBan _Instance;
        public static BLL_NhaXuatBan Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_NhaXuatBan();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_NhaXuatBan() { }
        public void Bll_AddNXB(NhaXuatBan a)
        {
            NHA_XUAT_BAN nxb = new NHA_XUAT_BAN { MaNXB = a.MaNXB, TenNXB = a.TenNXB };
            db.NHA_XUAT_BAN.Add(nxb);
            db.SaveChanges();
        }
        public List<string> Bll_GetAllMaNXB()
        {
            return db.NHA_XUAT_BAN.Select(p => p.MaNXB).ToList();
        }
    }
}
