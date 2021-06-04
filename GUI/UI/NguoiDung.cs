using GUI.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UI
{
    public partial class NguoiDung : Form
    {
        public string MaNhanVien { get; set; }
        public NguoiDung(string MaNhanVien)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = string.Empty;
            this.MaNhanVien = MaNhanVien;
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NguoiDung_Load(object sender, EventArgs e)
        {
            txtTenDN.Text = MaNhanVien;
            //txtHoTen = 
            txtTenDN.Enabled = false;
            isChange.Checked = false;
            txtMKcu.Enabled = false;
            txtMKmoi.Enabled = false;
            txtReMK.Enabled = false;
            Save.Enabled = false;

            NHAN_VIEN nv = BLL_QuanLy.Instance.Bll_GetNVByMaNV(MaNhanVien);
            txtHoTen.Text = nv.HoTen;
            if (nv.isAdmin) txtChucVu.Text = "Quản Lý";
            else txtChucVu.Text = "Nhân viên bán hàng";
        }

        private void isChange_CheckedChanged(object sender, EventArgs e)
        {
            if (isChange.Checked)
            {
                txtMKcu.Enabled = true;
                txtMKmoi.Enabled = true;
                txtReMK.Enabled = true;
                Save.Enabled = true;
            }
            else
            {
                txtMKcu.Text = string.Empty;
                txtMKmoi.Text = string.Empty;
                txtReMK.Text = string.Empty;
                txtMKcu.Enabled = false;
                txtMKmoi.Enabled = false;
                txtReMK.Enabled = false;
            }
        }

        private bool checkPass()
        {
            if (txtMKcu.Text != BLL_QuanLy.Instance.Bll_GetMKByTK(MaNhanVien))
            {
                MessageBox.Show("Mật khẩu cũ sai");
                return false;
            }
            if (txtMKmoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return false;
            }
            if (txtMKmoi.Text.Length > 10)
            {
                MessageBox.Show("Không nhập quá 10 kí tự");
                return false;
            }
            if (txtReMK.Text != txtMKmoi.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp");
                return false;
            }
            return true;
        }
          
        private void Save_Click(object sender, EventArgs e)
        {
            if(checkPass())
            {
                TK_NHANVIEN tk = new TK_NHANVIEN()
                {
                    TKNV = MaNhanVien,
                    Pass = txtMKmoi.Text
                };
                BLL_QuanLy.Instance.BLL_EditMatKhau(tk);
                this.Hide();
            }
        }
    }
}
