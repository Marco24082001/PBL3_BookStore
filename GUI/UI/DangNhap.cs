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
using GUI.BLL;

namespace GUI
{
    public partial class DangNhap : Form
    {
        Thread Luong;
        string TaiKhoan;
        string MatKhau;
        public DangNhap()
        {
            InitializeComponent();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            TaiKhoan = textBox1.Text;
            MatKhau = textBox2.Text;
            bool checktkmk = BLL_QuanLy.Instance.Bll_CheckTKMK(TaiKhoan, MatKhau);
            if(checktkmk == true)
            {
                if (BLL_QuanLy.Instance.Bll_CheckAdmin(TaiKhoan) == false)
                {
                    
                    this.Close();
                    Luong = new Thread(openFormNhanVien);
                    Luong.SetApartmentState(ApartmentState.STA);
                    Luong.Start();
                }
                else
                {
                    this.Close();
                    Luong = new Thread(openFormQuanLy);
                    Luong.SetApartmentState(ApartmentState.STA);
                    Luong.Start();
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập sai");
            }
        }

        private void openFormNhanVien(object newForm)
        {
            NhanVien f = new NhanVien();
            f.maNV = TaiKhoan;
            Application.Run(f);
        }

        private void openFormQuanLy(object newForm)
        {
            QuanLy f = new QuanLy();
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
