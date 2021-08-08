using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO;
namespace PBL3.UI
{
    public partial class ThemNXB : Form
    {
        public delegate void MyDel();
        public MyDel d;
        string boxTitle = "Thông báo";
        public ThemNXB()
        {
            InitializeComponent();
        }

        private void XacNhan_Click(object sender, EventArgs e)
        {
            foreach (string a in BLL_NhaXuatBan.Instance.Bll_GetAllMaNXB()) {
                if(txtMaNXB.Text == a)
                {
                    MessageBox.Show("Nhà xuất bản đã tồn tại", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            NhaXuatBan nxb = new NhaXuatBan();
            nxb.MaNXB = txtMaNXB.Text;
            nxb.TenNXB = txtTenNXB.Text;
            try
            {
                BLL_NhaXuatBan.Instance.Bll_AddNXB(nxb);
            }
            catch(DbEntityValidationException ex)
            {
                MessageBox.Show(ex.ToString(), boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }              
            d();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
