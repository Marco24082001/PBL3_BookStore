﻿using PBL3.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3.UI
{
    public partial class NguoiDung : Form
    {
        string boxTitle = "Thông báo";
        public string MaNhanVien { get; set; }
        public NguoiDung(string MaNhanVien)
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Text = string.Empty;
            this.MaNhanVien = MaNhanVien;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NguoiDung_Load(object sender, EventArgs e)
        {
            txtTenDN.Text = MaNhanVien;
            txtHoTen.ReadOnly = true;
            txtChucVu.ReadOnly = true;
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
                Save.Enabled = false;
            }
        }

        private bool checkPass()
        {
            if (txtMKcu.Text != BLL_QuanLy.Instance.Bll_GetMKByTK(MaNhanVien))
            {
                MessageBox.Show("Sai 'Mật khẩu cũ'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtMKmoi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập 'Mật khẩu mới'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtMKmoi.Text.Length > 10)
            {
                MessageBox.Show("'Mật khẩu mới' không được quá 10 kí tự", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtReMK.Text != txtMKmoi.Text)
            {
                MessageBox.Show("'Mật khẩu mới' không khớp", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
