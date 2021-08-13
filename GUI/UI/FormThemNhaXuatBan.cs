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
    public partial class FormThemNhaXuatBan : Form
    {
        public delegate void MyDel();
        public MyDel d;
        string boxTitle = "Thông báo";
        public FormThemNhaXuatBan()
        {
            InitializeComponent();
        }
        private bool checkMaNXB(string ma)
        {
            if(ma.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập Mã NXB", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ma.Length > 5)
            {
                MessageBox.Show("Không nhập quá 5 kí tự", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            foreach (string a in BLL_NhaXuatBan.Instance.Bll_GetAllMaNXB())
            {
                if (txtMaNXB.Text == a)
                {
                    MessageBox.Show("Nhà xuất bản đã tồn tại", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        private bool checkTenNXB(string ten)
        {
            if (ten.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập tên NXB", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ten.Length > 30)
            {
                MessageBox.Show("'Không nhập quá 30 kí tự", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void XacNhan_Click(object sender, EventArgs e)
        {
            if (!checkMaNXB(txtMaNXB.Text)) return;
            if (!checkTenNXB(txtTenNXB.Text)) return;
            NhaXuatBan nxb = new NhaXuatBan()
            {
                MaNXB = txtMaNXB.Text,
                TenNXB = txtTenNXB.Text,
            };
            BLL_NhaXuatBan.Instance.Bll_AddNXB(nxb);
            this.Close();       
            d();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
