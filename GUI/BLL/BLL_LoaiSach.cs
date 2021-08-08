using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PBL3.DTO;

namespace PBL3.BLL
{
    class BLL_LoaiSach
    {
        QuanLyEntities db = new QuanLyEntities();
        public static BLL_LoaiSach _Instance;
        public static BLL_LoaiSach Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new BLL_LoaiSach();
                }
                return _Instance;
            }
            private set { }
        }
        private BLL_LoaiSach() { }
        public void Bll_AddLoaiSach(LoaiSach a)
        {
            LOAI_SACH ls = new LOAI_SACH { MaLoaiSach = a.MaLoaiSach, TenLoaiSach = a.TenLoaiSach };
            db.LOAI_SACH.Add(ls);
            db.SaveChanges();
        }
        public List<string> Bll_GetAllMaLS()
        {
            return db.LOAI_SACH.Select(p => p.MaLoaiSach).ToList();
        }
        public int Bll_getTotal_Categorys()
        {
            return db.LOAI_SACH.Count();
        }

    }
}
