using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;

namespace PBL3.UI
{
    public partial class FormDangNhap : Form
    {
        Thread Luong;
        private string TaiKhoan;
        private string MatKhau;
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            TaiKhoan = textBox1.Text;
            MatKhau = textBox2.Text;
            bool checktkmk = BLL_TKNhanVien.Instance.Bll_CheckTKMK(TaiKhoan, MatKhau);
            if(checktkmk == true)
            {
                if (BLL_NhanVien.Instance.Bll_CheckAdmin(TaiKhoan))
                {
                    this.Close();
                    Luong = new Thread(openFormQuanLy);
                    Luong.SetApartmentState(ApartmentState.STA);
                    Luong.Start();
                }
                else
                {
                    this.Close();
                    Luong = new Thread(openFormNhanVien);
                    Luong.SetApartmentState(ApartmentState.STA);
                    Luong.Start();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập sai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void openFormNhanVien()
        {
            FormBanHang f = new FormBanHang();
            f.maNV = TaiKhoan;
            Application.Run(f);
        }

        private void openFormQuanLy()
        {
            FormTrangChu f = new FormTrangChu();
            f.maNV = TaiKhoan;
            Application.Run(f);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                iconButton2.PerformClick();
            }
        }
    }
}
