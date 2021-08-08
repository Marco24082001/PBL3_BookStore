using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class BaoCaoDoanhThu
    {
        public int STT { get; set; }
        public string MaSach { get; set; }
        public int GiaNhap { get; set; }
        public int GiaBan { get; set; }
        public int SoLuongBan { get; set; }
        public Nullable<int> DoanhThu { get; set; }
        public Nullable<System.DateTime> ThoiGian { get; set; }
    }
}
