using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class ChiTietHoaDonNhap
    {
        public int ID { get; set; }
        public int MaDonNhap { get; set; }
        public string MaSach { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<int> ThanhTien { get; set; }
    }
}
