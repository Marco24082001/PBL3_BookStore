using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.BLL;

namespace GUI
{
    public partial class ThemHoaDon : Form
    {
        public ThemHoaDon()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            HOA_DON_NHAP hdn = new HOA_DON_NHAP();
            hdn.MaDonNhap = MaDonNhap.Text;
            hdn.NgayNhap = dateTimePicker1.Value;
            hdn.GhiChu = GhiChu.Text;
            BLL_QuanLy.Instance.Bll_AddHoaDonNhap(hdn);
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ThemHoaDon_Load(object sender, EventArgs e)
        {

        }
    }
}
