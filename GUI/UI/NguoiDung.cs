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
            txtMkc.Enabled = false;
            txtMkm.Enabled = false;
            txtNl.Enabled = false;
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
                txtMkc.Enabled = true;
                txtMkm.Enabled = true;
                txtNl.Enabled = true;
                Save.Enabled = true;
            }
            else
            {
                txtMkc.Text = string.Empty;
                txtMkm.Text = string.Empty;
                txtNl.Text = string.Empty;
                txtMkc.Enabled = false;
                txtMkm.Enabled = false;
                txtNl.Enabled = false;
            }
        }

        private bool checkPass(string mkc, string mk, string rmk)
        {
            TK_NHANVIEN tk = BLL_QuanLy.Instance.Bll_GetTKByMaNV(MaNhanVien);
            if (mk.Length > 10)
            {
                MessageBox.Show("Mật khẩu tối đa 10 ký tự");
                return false;
            }
            if(mkc == tk.Pass && mk != "" && rmk != "")
            {
                if (mk == rmk) return true;
                else return false;
            }
            return false;
        }
          
        private void Save_Click(object sender, EventArgs e)
        {
            if (isChange.Checked)
            {
                if (checkPass(txtMkc.Text, txtMkm.Text, txtNl.Text))
                {
                    TK_NHANVIEN tk = new TK_NHANVIEN();
                    tk.TKNV = MaNhanVien;
                    tk.Pass = txtMkm.Text;
                    BLL_QuanLy.Instance.BLL_EditMatKhau(tk);
                    this.Hide();
                }
                else MessageBox.Show("Ban nhap sai: vui long nhap lai !");
            }
        }
    }
}
