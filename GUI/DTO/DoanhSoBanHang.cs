using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class DoanhSoBanHang
    {
        public int STT { get; set; }
        public string MaNhanVien { get; set; }
        public Nullable<int> DoanhSoBan { get; set; }
        public Nullable<System.DateTime> ThoiGian { get; set; }
    }
}
