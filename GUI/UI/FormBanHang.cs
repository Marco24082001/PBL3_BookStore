using System;
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
using PBL3.BLL;
using PBL3.DTO;

namespace PBL3.UI
{
    public partial class FormBanHang : Form
    {
        Thread Luong;
        List<ChiTietHoaDonBan> list = new List<ChiTietHoaDonBan>();
        public string maNV { get; set; }
        bool checkKhachHang = false;
        FormCaiDatThongTin user;
        string boxTitle = "Thông báo";
        public FormBanHang()
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
            dataGridView1.DataSource = BLL_Sach.Instance.Bll_GetAllViewSachByTrangThai().ToList();
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
            if (list.Count == 0)
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
            }
        }
        public void setCbbMaSach()
        {
            foreach (string i in BLL_Sach.Instance.Bll_GetAllMaSachByTrangThai())
            {
                cbbMaSach.Items.Add(i);
            }
            cbbMaSach.SelectedIndex = 0;
        }
        public void setCbbLoaiSach()
        {
            cbbTheLoai.Items.Add("All");
            foreach (string i in BLL_Sach.Instance.Bll_GetAllMaLS())
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
            txtMaNhanVien.Text = txtTen.Text = BLL_Sach.Instance.Bll_GetNameNVByMaNV(maNV);
            txtMaNhanVien.Enabled = false;
            txtMaDonBan.Enabled = false;
            TongCong.Text = "0";
        }

        private bool ChecktxtSDT()
        {
            if (txtSDT.Text == "")
            {
                MessageBox.Show("Vui lòng nhập 'Số điện thoại'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSDT.Text.Length != 10)
            {
                MessageBox.Show("'Số điện thoại' phải đúng 10 chữ số", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            string a = txtSDT.Text;
            for (int i = 0; i < txtSDT.TextLength; i++)
            {
                if ((int)a[i] < 48 || (int)a[i] > 57)
                {
                    MessageBox.Show("'Số điện thoại' không hợp lệ", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private bool ChecktxtHoTen()
        {
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập 'Họ và tên'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtHoTen.Text.Length > 30)
            {
                MessageBox.Show("'Họ và tên' không được quá 30 kí tự", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool CheckSoLuong()
        {
            if (numericUpDown1.Value == 0)
            {
                MessageBox.Show("Vui lòng chọn 'Số lượng'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void Them_Click(object sender, EventArgs e)
        {
            if (!ChecktxtSDT()) return;
            if (!ChecktxtHoTen()) return;
            if (!CheckSoLuong()) return;
            if (txtMaDonBan.Text == "")
            {
                MessageBox.Show("Vui lòng tạo 'Mã hóa đơn'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int soSachinList = 0;
            foreach (ChiTietHoaDonBan i in list)
            {
                if (i.MaSach == cbbMaSach.SelectedItem.ToString())
                {
                    soSachinList += i.SoLuong;
                }
            }
            if (numericUpDown1.Value + soSachinList > BLL_Sach.Instance.Bll_GetSLByMaSach(cbbMaSach.SelectedItem.ToString()))
            {
                MessageBox.Show("Số lượng sách trong kho không đủ", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtHoTen.Enabled = false;
            txtSDT.Enabled = false;
            txtMaDonBan.Enabled = false;
            int donGia = BLL_Sach.Instance.Bll_GetGiaBanByMaSach(cbbMaSach.SelectedItem.ToString());
            int soLuong = Convert.ToInt32(numericUpDown1.Value.ToString());
            ChiTietHoaDonBan chitiet = new ChiTietHoaDonBan()
            {
                MaDonBan = Convert.ToInt32(txtMaDonBan.Text),
                MaSach = cbbMaSach.SelectedItem.ToString(),
                SoLuong = soLuong,
                DonGia = donGia,
                ThanhTien = donGia * soLuong,
            };
            int tong = Convert.ToInt32(TongCong.Text);
            TongCong.Text = (tong + chitiet.ThanhTien).ToString();
            foreach (ChiTietHoaDonBan p in list)
            {
                if (chitiet.MaSach == p.MaSach)
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
            int tong = Convert.ToInt32(TongCong.Text);
            foreach (DataGridViewRow i in r)
            {
                TongCong.Text = (tong - Convert.ToInt32(i.Cells[5].Value.ToString())).ToString();
                list.RemoveAt(i.Index);          
            }
            setData2();
            if (list.Count == 0)
            {
                txtSDT.Enabled = true;
                txtHoTen.Enabled = true;
                txtHoTen.Text = "";
                txtSDT.Text = "";
                txtMaDonBan.Text = "";
                numericUpDown1.Value = 0;
                cbbMaSach.SelectedIndex = 0;
                TongCong.Text = "0";
            }
        }

        private void ThanhToan_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Giỏ hàng rỗng", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (checkKhachHang == false)
            {
                KhachHang kh = new KhachHang();
                kh.SDT = txtSDT.Text;
                kh.HoTen = txtHoTen.Text;
                BLL_KhachHang.Instance.Bll_AddKhachHang(kh);
            }
            HoaDonBan hdb = new HoaDonBan()
            {
                MaDonBan = Convert.ToInt32(txtMaDonBan.Text),
                SDT_KH = txtSDT.Text,
                MaNhanVien = maNV,
                NgayBan = DateTime.Now,
            };
            //Them HoaDonBan
            BLL_HoaDonBan.Instance.Bll_AddHoaDonBan(hdb);
            foreach (ChiTietHoaDonBan a in list)
            {
                BLL_ChiTietHoaDonBan.Instance.Bll_AddChiTietHoaDonBan(a);
                string maSach = a.MaSach;
                int soLuongban = a.SoLuong;
                int soLuongNow = BLL_Sach.Instance.Bll_GetSLByMaSach(maSach);
                BLL_Sach.Instance.Bll_EditSLByMaSach(maSach, soLuongNow - soLuongban);
            }
            //Them ChietHoaDonBan
            foreach (ChiTietHoaDonBan a in list)
            {
                DTO.BaoCaoDoanhThu bcdt = new DTO.BaoCaoDoanhThu()
                {
                    MaSach = a.MaSach,
                    GiaNhap = BLL_Sach.Instance.Bll_GetGiaNhapByMaSach(a.MaSach),
                    GiaBan = BLL_Sach.Instance.Bll_GetGiaBanByMaSach(a.MaSach),
                    SoLuongBan = a.SoLuong,
                    DoanhThu = a.SoLuong * (BLL_Sach.Instance.Bll_GetGiaBanByMaSach(a.MaSach) - BLL_Sach.Instance.Bll_GetGiaNhapByMaSach(a.MaSach)),
                    ThoiGian = DateTime.Now,
                };
                BLL_BaoCaoDoanhThu.Instance.Bll_AddBaoCaoDoanhThu(bcdt);
            }
            //Them DoanhSoBanHang
            DoanhSoBanHang dsbh = new DoanhSoBanHang()
            {
                MaNhanVien = maNV,
                DoanhSoBan = Convert.ToInt32(TongCong.Text),
                ThoiGian = DateTime.Now,
            };
            BLL_DoanhSoBanHang.Instance.Bll_AddDoanhSoBanHang(dsbh);
            //setup lại giao diện
            list.Clear();
            dataGridView2.DataSource = null;
            txtHoTen.Enabled = true;
            txtSDT.Enabled = true;
            checkKhachHang = false;
            txtMaDonBan.Text = "";
            txtSDT.Text = "";
            txtHoTen.Text = "";
            cbbMaSach.SelectedIndex = 0;
            numericUpDown1.Value = 0;
            MessageBox.Show("Thanh Toán thành công\nTổng tiền : " + TongCong.Text + " VNĐ", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            setData1();
            TongCong.Text = "0";
        }

        private void SDT_TextChanged(object sender, EventArgs e)
        {
            foreach (string i in BLL_KhachHang.Instance.Bll_GetAllSDT())
            {
                if (txtSDT.Text == i)
                {
                    checkKhachHang = true;
                    txtHoTen.Text = BLL_KhachHang.Instance.Bll_GetKHBySDT(txtSDT.Text);
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
            FormDangNhap f = new FormDangNhap();
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
            if (user == null)
            {
                user = new FormCaiDatThongTin(maNV);
            }
            user.Show();
        }

        private void AddHoaDon_Click(object sender, EventArgs e)
        {
            txtMaDonBan.Text = BLL_HoaDonBan.Instance.Bll_CreateHDB();
        }


        private void sortBtn_Click(object sender, EventArgs e)
        {
            List<string> LMS = new List<string>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                LMS.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
            string CategorySort = cbbSort.SelectedItem.ToString();
            dataGridView1.DataSource = BLL_Sach.Instance.Bll_SapXepViewSach(LMS, CategorySort);
        }

        private void cbbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbTheLoai.SelectedItem.ToString() == "All")
            {
                setData1();
            }
            else
            {
                dataGridView1.DataSource = BLL_Sach.Instance.Bll_GetViewSachByLSAndTT(cbbTheLoai.SelectedItem.ToString());
            }
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {
            if (cbbTheLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Thể loại sách", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string theloai = cbbTheLoai.SelectedItem.ToString();
            string name = txtTenSach.Text;
            dataGridView1.DataSource = BLL_Sach.Instance.Bll_GetSachByNameLSAndTT(name, theloai);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbMaSach.SelectedItem = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            numericUpDown1.Value = 1;
        }
    }
}
