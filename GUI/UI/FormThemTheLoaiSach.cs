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
    public partial class FormThemTheLoaiSach : Form
    {
        public delegate void MyDel();
        public MyDel d;
        string boxTitle = "Thống báo";
        public FormThemTheLoaiSach()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            foreach (string a in BLL_QuanLy.Instance.Bll_GetAllMaLS())
            {
                if (txtMaLS.Text == a)
                {
                    MessageBox.Show("'Loại sách' đã tồn tại", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            LoaiSach ls = new LoaiSach();
            ls.MaLoaiSach = txtMaLS.Text;
            ls.TenLoaiSach = txtTenLS.Text;
            try
            {
                BLL_LoaiSach.Instance.Bll_AddLoaiSach(ls);
            }
            catch(DbEntityValidationException ex)
            {
                MessageBox.Show(ex.ToString(), boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            d();
        }
        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
