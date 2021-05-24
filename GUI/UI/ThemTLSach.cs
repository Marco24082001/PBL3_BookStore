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
    public partial class ThemTLSach : Form
    {
        public delegate void MyDel();
        public MyDel d;
        public ThemTLSach()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            foreach (string a in BLL_QuanLy.Instance.Bll_GetAllMaLS())
            {
                if (txtMaLS.Text == a)
                {
                    MessageBox.Show("Loai sach da ton tai");
                    return;
                }
            }
            LOAI_SACH ls = new LOAI_SACH();
            ls.MaLoaiSach = txtMaLS.Text;
            ls.TenLoaiSach = txtTenLS.Text;
            try
            {
                BLL_QuanLy.Instance.Bll_AddLoaiSach(ls);
            }
            catch(DbEntityValidationException)
            {
                MessageBox.Show("Error");
            }
            
            d();
        }
        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
