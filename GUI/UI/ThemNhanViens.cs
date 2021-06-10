﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.BLL;
namespace GUI
{
    public partial class ThemNhanViens : Form
    {
        public delegate void MyDel();
        public MyDel d;
        public string maNV { get; set; }
        string boxTitle = "Thông báo";
        public ThemNhanViens()
        {
            InitializeComponent();
        }

        public void loadData()
        {
            txtMaNV.Enabled = false;
            NHAN_VIEN nv = BLL_QuanLy.Instance.Bll_GetNVByMaNV(maNV);
            txtMaNV.Text = nv.MaNhanVien;
            txtHoTen.Text = nv.HoTen;
            if (nv.GioiTinh == "Nam") Nam.Checked = true;
            else Nu.Checked = true;
            txtDanToc.Text = nv.DanToc;
            txtCMND.Text = nv.CMND;
            txtSdt.Text = nv.SoDienThoai;
            txtQueQuan.Text = nv.QueQuan;
            dateTimePicker1.Value = nv.NgaySinh;
        }

        private void ThemNhanViens_Load(object sender, EventArgs e)
        {
            if (maNV != null)
            {
                loadData();
            }
        }

        private void LamMoi_Click(object sender, EventArgs e)
        {    
            if(maNV == null)
            {
                txtMaNV.Text = "";
            }
            txtHoTen.Text = "";
            Nam.Checked = true;
            txtDanToc.Text = "";
            txtCMND.Text = "";
            txtSdt.Text = "";
            txtQueQuan.Text = "";
            txtMatKhau.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private bool NhapMaNV()
        {
            if(txtMaNV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập 'Mã nhân viên'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            foreach(string ma in BLL_QuanLy.Instance.Bll_GetAllMaNV())
            {
                if(ma == txtMaNV.Text)
                {
                    MessageBox.Show("'Mã nhân viên' đã tồn tại", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if (txtMaNV.Text.Length > 5)
            {
                MessageBox.Show("'Mã nhân viên' không quá 5 kí tự", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool NhapHoTen()
        {
            if(txtHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập 'Họ và tên'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(txtHoTen.Text.Length > 30)
            {
                MessageBox.Show("'Họ và tên' không quá 30 kí tự", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool NhapDanToc()
        {
            if(txtDanToc.Text == "")
            {
                MessageBox.Show("Vui lòng nhập 'Dân tộc'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(txtDanToc.TextLength > 10)
            {
                MessageBox.Show("'Dân tộc' không được quá 10 kí tự", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool NhapCMND()
        {
            if(txtCMND.Text == "")
            {
                MessageBox.Show("Vui lòng nhập 'CMND'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string a = txtCMND.Text;
            if (txtCMND.TextLength > 12)
            {
                MessageBox.Show("'CMND' không được quá 12 số", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            for (int i = 0; i < txtCMND.TextLength; i++)
            {
                if ((int)a[i] < 48 || (int)a[i] > 57)
                {
                    MessageBox.Show("'CMND' không hợp lệ", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private bool NhapSDT()
        {
            if(txtSdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhâp 'Số điện thoại'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string a = txtSdt.Text;
            if(txtSdt.TextLength > 10)
            {
                MessageBox.Show("'Số điện thoại' không được quá 10 số", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            for (int i = 0; i < txtSdt.TextLength; i++)
            {
                if ((int)a[i] < 48 || (int)a[i] > 57)
                {
                    MessageBox.Show("'Số điện thoại' không hợp lệ", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        private bool NhapQueQuan()
        {
            if(txtQueQuan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập 'Quê quán'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtQueQuan.Text.Length > 50)
            {
                MessageBox.Show("'Quê quán' không được quá 50 kí tự", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool NhapMatKhau()
        {
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập 'Mật khẩu'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtQueQuan.Text.Length > 10)
            {
                MessageBox.Show("'Mật khẩu' không được quá 10 kí tự", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void Add()
        {
            if (NhapMaNV() == false) return;
            if (NhapHoTen() == false) return;
            if (!NhapHoTen()) return;
            if (NhapCMND() == false) return;
            if (NhapSDT() == false) return;
            if (NhapQueQuan() == false) return;
            if (!NhapMatKhau()) return;
            NHAN_VIEN nv = new NHAN_VIEN();            
            nv.MaNhanVien = txtMaNV.Text;
            nv.HoTen = txtHoTen.Text;
            if (Nam.Checked == true) nv.GioiTinh = "Nam";
            else nv.GioiTinh = "Nu";
            nv.DanToc = txtDanToc.Text;
            nv.CMND = txtCMND.Text;
            nv.SoDienThoai = txtSdt.Text;
            nv.QueQuan = txtQueQuan.Text;
            nv.NgaySinh = dateTimePicker1.Value;
            nv.TrangThai = true;
            BLL_QuanLy.Instance.Bll_AddNhanVien(nv);
            TK_NHANVIEN tk = new TK_NHANVIEN();
            tk.TKNV = txtMaNV.Text;
            tk.Pass = txtMatKhau.Text;
            BLL_QuanLy.Instance.Bll_AddTKNhanVien(tk);
        }

        private void Edit(string maNV)
        {
            if (NhapHoTen() == false) return;
            if (NhapCMND() == false) return;
            if (NhapSDT() == false) return;
            if (NhapQueQuan() == false) return;
            NHAN_VIEN nv = new NHAN_VIEN(); 
            txtMaNV.Text = maNV;
            txtMaNV.Enabled = false;
            nv.MaNhanVien = txtMaNV.Text;
            nv.HoTen = txtHoTen.Text;
            if (Nam.Checked == true) nv.GioiTinh = "Nam";
            else nv.GioiTinh = "Nu";
            nv.DanToc = txtDanToc.Text;
            nv.CMND = txtCMND.Text;
            nv.SoDienThoai = txtSdt.Text;
            nv.QueQuan = txtQueQuan.Text;
            nv.NgaySinh = dateTimePicker1.Value;
            BLL_QuanLy.Instance.Bll_EditNhanVien(nv);
        }

        private void XacNhan_Click(object sender, EventArgs e)
        {
            if (maNV != null)
            {
                Edit(maNV);
            }
            else Add();
            d();
        }

        private void Thoat_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
