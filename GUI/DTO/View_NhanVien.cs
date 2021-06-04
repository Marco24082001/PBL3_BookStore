using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI.DTO
{
    class View_NhanVien
    {
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string TKNV { get; set; }
        public string DanToc { get; set; }
        public string GioiTinh { get; set; }
        public string CMND { get; set; }
        public string SoDienThoai { get; set; }
        public string QueQuan { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool TrangThai { get; set; }
        public bool isAdim { get; set; }
    }
}
