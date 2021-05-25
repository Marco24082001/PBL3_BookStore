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
using GUI.BLL;

namespace GUI
{
    public partial class ThemNXB : Form
    {
        public delegate void MyDel();
        public MyDel d;
        public ThemNXB()
        {
            InitializeComponent();
        }

        private void XacNhan_Click(object sender, EventArgs e)
        {
            foreach (string a in BLL_QuanLy.Instance.Bll_GetAllMaNXB()) {
                if(txtMaNXB.Text == a)
                {
                    MessageBox.Show("Nha Xuat Ban da ton tai");
                    return;
                }
            }
            NHA_XUAT_BAN nxb = new NHA_XUAT_BAN();
            nxb.MaNXB = txtMaNXB.Text;
            nxb.TenNXB = txtTenNXB.Text;
            try
            {
                BLL_QuanLy.Instance.Bll_AddNXB(nxb);
            }
            catch(DbEntityValidationException)
            {
                MessageBox.Show("Error");
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
