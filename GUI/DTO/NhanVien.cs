using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3.DTO
{
    class NhanVien
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string DanToc { get; set; }
        public string GioiTinh { get; set; }
        public string CMND { get; set; }
        public string SoDienThoai { get; set; }
        public string QueQuan { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public bool TrangThai { get; set; }
        public bool isAdmin { get; set; }
    }
}
