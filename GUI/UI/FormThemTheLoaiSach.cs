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
        private bool checkMaLS(string ma)
        {
            if (ma.Length == 0)
            {
                MessageBox.Show("'Không nhập quá Mã loại sách", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ma.Length > 5)
            {
                MessageBox.Show("Không nhập quá 5 kí tự", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            foreach (string a in BLL_QuanLy.Instance.Bll_GetAllMaLS())
            {
                if (txtMaLS.Text == a)
                {
                    MessageBox.Show("Loại sách' đã tồn tại", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        private bool checkTenLS(string ten)
        {
            if (ten.Length == 0)
            {
                MessageBox.Show("Không nhập tên loại sách", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ten.Length > 40)
            {
                MessageBox.Show("Không nhập quá 40 kí tự", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void OK_Click(object sender, EventArgs e)
        {
            if (!checkMaLS(txtMaLS.Text)) return;
            if (!checkTenLS(txtTenLS.Text)) return;
            LoaiSach ls = new LoaiSach()
            {
                MaLoaiSach = txtMaLS.Text,
                TenLoaiSach = txtTenLS.Text
            };
            BLL_LoaiSach.Instance.Bll_AddLoaiSach(ls);
            this.Close();
            d();
        }
        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
