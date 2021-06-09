﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.BLL;
using GUI.UI;

namespace GUI
{
    public partial class NhanVien : Form
    {
        Thread Luong;
        List<CHI_TIET_HOA_DON_BAN> list = new List<CHI_TIET_HOA_DON_BAN>();
        public string maNV { get; set; }
        bool checkKhachHang = false;
        NguoiDung user;
        public NhanVien()
        {
            InitializeComponent();
            setCbbMaSach();
            setData1();
            setCbbLoaiSach();
            setcbbSort();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public void setData1()
        {
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetAllViewSachByTrangThai().ToList();
            dataGridView1.Columns["MaSach"].HeaderText = "Mã sách";
            dataGridView1.Columns["TenSach"].HeaderText = "Tên sách";
            dataGridView1.Columns["GiaBan"].HeaderText = "Giá";
            dataGridView1.Columns["SoLuong"].HeaderText = "Số lượng";
            dataGridView1.Columns["TenNXB"].HeaderText = "Nhà xuất bản";
            dataGridView1.Columns["TenLS"].HeaderText = "Thể loại";
        }
        public void setData2()
        {
            dataGridView2.DataSource = null;
            if(list.Count == 0)
            {
                return;
            }
            else
            {
                dataGridView2.DataSource = list;
                dataGridView2.Columns["MaDonBan"].HeaderText = "Mã đơn bán";
                dataGridView2.Columns["MaSach"].HeaderText = "Mã sách";
                dataGridView2.Columns["SoLuong"].HeaderText = "Số lượng";
                dataGridView2.Columns["DonGia"].HeaderText = "Đơn giá";
                dataGridView2.Columns["ThanhTien"].HeaderText = "Thành tiền";
                dataGridView2.Columns[0].Visible = false;
                dataGridView2.Columns[6].Visible = false;
                dataGridView2.Columns[7].Visible = false;
                dataGridView2.CurrentCell = dataGridView2.Rows[0].Cells[1];
            }
        }
        public void setCbbMaSach()
        {
            foreach(string i in BLL_QuanLy.Instance.Bll_GetAllMaSachByTrangThai())
            {
                cbbMaSach.Items.Add(i);
            }
            cbbMaSach.SelectedIndex = 0;
        }
        public void setCbbLoaiSach()
        {
            cbbTheLoai.Items.Add("All");
            foreach (string i in BLL_QuanLy.Instance.Bll_GetAllMaLS())
            {
                cbbTheLoai.Items.Add(i);
            }
            cbbTheLoai.SelectedIndex = 0;
        }

        public void setcbbSort()
        {
            cbbSort.Items.AddRange(new String[] {
                "Ten Sach", "Gia Ban", "So Luong"
            });
            cbbSort.SelectedIndex = 0;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            txtMaNhanVien.Text = txtTen.Text = BLL_QuanLy.Instance.Bll_GetNameNVByMaNV(maNV);
            txtMaNhanVien.Enabled = false;
            TongCong.Text = "0";
        }

        private bool ChecktxtSDT()
        {
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Vui long nhap số điện thoại");
                return false;
            }
            if(txtSDT.Text.Length != 10)
            {
                MessageBox.Show("10 so");
                return false;
            }
            string a = txtSDT.Text;
            for (int i = 0; i < txtSDT.TextLength; i++)
            {
                if ((int)a[i] < 48 || (int)a[i] > 57)
                {
                    MessageBox.Show("Số điện thoại ko hợp lệ");
                    return false;
                }
            }
            return true;
        }

        private bool ChecktxtHoTen()
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Vui long nhap họ tên");
                return false;
            }
            if(txtHoTen.Text.Length > 30)
            {
                MessageBox.Show("Không nhập quá 30 kí tự");
                return false;
            }
            return true;
        }

        private bool CheckSoLuong()
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng sách");
                return false;
            }
            return true;
        }
        private void Them_Click(object sender, EventArgs e)
        {
            if (!ChecktxtSDT()) return;
            if (!ChecktxtHoTen()) return;
            if (!CheckSoLuong()) return;
            int soSachinList = 0;
            foreach(CHI_TIET_HOA_DON_BAN i in list)
            {
                if(i.MaSach == cbbMaSach.SelectedItem.ToString())
                {
                    soSachinList += i.SoLuong;
                }
            }
            if(numericUpDown1.Value + soSachinList > BLL_QuanLy.Instance.Bll_GetSLByMaSach(cbbMaSach.SelectedItem.ToString()))
            {
                MessageBox.Show("Số lượng sách trong kho không đủ");
                return;
            }
            txtHoTen.Enabled = false;
            txtSDT.Enabled = false;
            int donGia = BLL_QuanLy.Instance.Bll_GetGiaBanByMaSach(cbbMaSach.SelectedItem.ToString());
            int soLuong = Convert.ToInt32(numericUpDown1.Value.ToString());
            CHI_TIET_HOA_DON_BAN chitiet = new CHI_TIET_HOA_DON_BAN()
            {
                MaSach = cbbMaSach.SelectedItem.ToString(),
                SoLuong = soLuong,
                DonGia = donGia,
                ThanhTien = donGia * soLuong,
            };
            int tong = Convert.ToInt32(TongCong.Text);
            TongCong.Text = (tong + chitiet.ThanhTien).ToString();
            foreach(CHI_TIET_HOA_DON_BAN p in list)
            {
                if(chitiet.MaSach == p.MaSach)
                {
                    p.SoLuong += chitiet.SoLuong;
                    p.ThanhTien = p.SoLuong * p.DonGia;
                    setData2();
                    return;
                }
            }
            list.Add(chitiet);
            setData2();
            return;
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView2.SelectedRows;
            foreach(DataGridViewRow i in r)
            {
                list.RemoveAt(i.Index); 
            }
            setData2();
            if(list.Count == 0)
            {               
                txtSDT.Enabled = true;
                txtHoTen.Enabled = true;
                txtHoTen.Text = "";
                txtSDT.Text = "";
                numericUpDown1.Value = 0;
                cbbMaSach.SelectedIndex = 0;
                TongCong.Text = "0";
            }
        }

        private void ThanhToan_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Gio Hang rỗng");
                return;
            }
            if (checkKhachHang == false)
            {
                KHACH_HANG kh = new KHACH_HANG();
                kh.SDT = txtSDT.Text;
                kh.HoTen = txtHoTen.Text;
                BLL_QuanLy.Instance.Bll_AddKhachHang(kh);
            }
            HOA_DON_BAN hdb = new HOA_DON_BAN()
            {
                SDT_KH = txtSDT.Text, 
                MaNhanVien = maNV,
                NgayBan = DateTime.Now,
            };
            BLL_QuanLy.Instance.Bll_AddHoaDonBan(hdb);
            foreach(CHI_TIET_HOA_DON_BAN a in list)
            {
                BLL_QuanLy.Instance.Bll_AddChiTietHoaDonBan(a);
                string maSach = a.MaSach;
                int soLuongban = a.SoLuong;
                int soLuongNow = BLL_QuanLy.Instance.Bll_GetSLByMaSach(maSach);
                BLL_QuanLy.Instance.Bll_EditSLByMaSach(maSach, soLuongNow - soLuongban);
            }
            foreach (CHI_TIET_HOA_DON_BAN a in list)
            {
                BAO_CAO_DOANH_THU bcdt = new BAO_CAO_DOANH_THU()
                {
                    MaSach = a.MaSach,
                    GiaNhap = BLL_QuanLy.Instance.Bll_GetGiaNhapByMaSach(a.MaSach),
                    GiaBan = BLL_QuanLy.Instance.Bll_GetGiaBanByMaSach(a.MaSach),
                    SoLuongBan = a.SoLuong,
                    DoanhThu = a.SoLuong * (BLL_QuanLy.Instance.Bll_GetGiaBanByMaSach(a.MaSach) - BLL_QuanLy.Instance.Bll_GetGiaNhapByMaSach(a.MaSach)),
                    ThoiGian = DateTime.Now,
                };
                BLL_QuanLy.Instance.Bll_AddBaoCaoDoanhThu(bcdt);
            }
            int tong = 0;
            foreach(CHI_TIET_HOA_DON_BAN a in list)
            {
                tong += a.SoLuong * (BLL_QuanLy.Instance.Bll_GetGiaBanByMaSach(a.MaSach) - BLL_QuanLy.Instance.Bll_GetGiaNhapByMaSach(a.MaSach));
            }
            DOANH_SO_BAN_HANG dsbh = new DOANH_SO_BAN_HANG()
            {
                MaNhanVien = maNV,
                DoanhSoBan = tong,
                ThoiGian = DateTime.Now,
            };
            BLL_QuanLy.Instance.Bll_AddDoanhSoBanHang(dsbh);
            list.Clear();
            dataGridView2.DataSource = null;
            txtHoTen.Enabled = true;
            txtSDT.Enabled = true;
            checkKhachHang = false;
            txtSDT.Text = "";
            txtHoTen.Text = "";
            cbbMaSach.SelectedIndex = 0;
            numericUpDown1.Value = 0;
            setData1();
            MessageBox.Show("ThanhToanThanhCong");
        }

        private void SDT_TextChanged(object sender, EventArgs e)
        {
            foreach(string i in BLL_QuanLy.Instance.Bll_GetAllSDT())
            {
                if(txtSDT.Text == i)
                {
                    checkKhachHang = true;
                    txtHoTen.Text = BLL_QuanLy.Instance.Bll_GetKHBySDT(txtSDT.Text);
                    txtHoTen.Enabled = false;
                    return;
                }
                else
                {
                    checkKhachHang = false;
                    txtHoTen.Text = "";
                    txtHoTen.Enabled = true;
                }
            }
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Luong = new Thread(openFormDangNhap);
            Luong.SetApartmentState(ApartmentState.STA);
            Luong.Start();
        }

        private void openFormDangNhap(object newForm)
        {
            DangNhap f = new DangNhap();
            Application.Run(f);
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void infoNhanVien_Click(object sender, EventArgs e)
        {
            if(user == null)
            {
                user = new NguoiDung(maNV);
            }
            user.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbMaSach.SelectedItem = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            numericUpDown1.Value = 1;
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            List<string> LMS = new List<string>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                LMS.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
            string CategorySort = cbbSort.SelectedItem.ToString();
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_SapXepViewSach(LMS, CategorySort);
        }

        private void cbbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTheLoai.SelectedItem.ToString() == "All")
            {
                setData1();
            }
            else
            {
                dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetViewSachByLSAndTT(cbbTheLoai.SelectedItem.ToString());
            }
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {
            if (cbbTheLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long chon The Loai");
                return;
            }
            string theloai = cbbTheLoai.SelectedItem.ToString();
            string name = txtTenSach.Text;
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetSachByNameLSAndTT(name, theloai);
        }
    }
}
