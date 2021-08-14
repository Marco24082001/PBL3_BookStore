using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using PBL3.BLL;
using PBL3.DTO;

namespace PBL3.UI
{
    public partial class FormQuanLySach : Form
    {
        List<ChiTietHoaDonNhap> list = new List<ChiTietHoaDonNhap>();
        string boxTitle = "Thống báo";
        public FormQuanLySach()
        {
            InitializeComponent();
            setcbbMaSach();
            setcbbTheLoai();
            setcbbSort();
        }
        
        //public void reset()
        //{
        //    setData1();
        //    setcbbMaSach();
        //    setcbbTheLoai();
        //    setcbbSort();
        //}
        public void setData1()
        {
            //if (cbbTheLoai.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Vui lòng chọn 'Thể loại'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (cbbTheLoai.SelectedIndex == 0)
            //{
            //    dataGridView1.DataSource = BLL_Sach.Instance.Bll_GetAllSach();
            //}
            //else
            //{
            //    string ls = cbbTheLoai.SelectedItem.ToString();
            //    dataGridView1.DataSource = BLL_Sach.Instance.Bll_GetSachByLS(ls);
            //}
            dataGridView1.DataSource = BLL_Sach.Instance.Bll_GetSachByNameAndLS(txtTenSach.Text, cbbTheLoai.SelectedItem.ToString());
            dataGridView1.Columns["MaSach"].HeaderText = "Mã sách";
            dataGridView1.Columns["TenSach"].HeaderText = "Tên sách";
            dataGridView1.Columns["GiaBan"].HeaderText = "Giá bán";
            dataGridView1.Columns["GiaNhap"].HeaderText = "Giá nhập";
            dataGridView1.Columns["SoLuong"].HeaderText = "Số lượng";
            dataGridView1.Columns["MaNXB"].HeaderText = "Nhà xuất bản";
            dataGridView1.Columns["MaLoaiSach"].HeaderText = "Thể loại";
            dataGridView1.Columns["TrangThai"].HeaderText = "Trạng thái";
        }
        public void setData2()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = list;
            dataGridView2.Columns["ID"].Visible = false;
            dataGridView2.Columns["MaDonNhap"].HeaderText = "Mã đơn nhập";
            dataGridView2.Columns["MaSach"].HeaderText = "Mã sách";
            dataGridView2.Columns["SoLuong"].HeaderText = "Số lượng";
            dataGridView2.Columns["ThanhTien"].HeaderText = "Thành tiền";
        }
        public void setcbbMaSach()
        {
            foreach (string i in BLL_Sach.Instance.Bll_GetAllMaSach())
            {
                cbbMaSach.Items.Add(i);
            }
        }
        public void setcbbTheLoai()
        {
            cbbTheLoai.Items.Add("All");
            foreach (string i in BLL_LoaiSach.Instance.Bll_GetAllMaLS())
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

        private void Them_Click(object sender, EventArgs e)
        {
            foreach (ChiTietHoaDonNhap i in list)
            {
                BLL_ChiTietHoaDonNhap.Instance.Bll_AddChiTietHoaDonNhap(i);
            }
        }

        private void ThemSach_Click(object sender, EventArgs e)
        {
            FormThemSach f = new FormThemSach();
            f.Show();
            f.reset += new FormThemSach.MyDel(setData1);
            f.reset += new FormThemSach.MyDel(setcbbMaSach);
        }
        private void ThemChiTiet_Click(object sender, EventArgs e)
        {
            if (txtMaDN.Text == "")
            {
                MessageBox.Show("Vui lòng nhập 'Mã hóa đơn'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbbMaSach.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn 'Mã sách'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (numericUpDown4.Value == 0)
            {
                MessageBox.Show("Vui lòng chọn số lượng sách");
                return;
            }
            ChiTietHoaDonNhap ct = new ChiTietHoaDonNhap()
            {
                MaDonNhap = Convert.ToInt32(txtMaDN.Text),
                MaSach = cbbMaSach.SelectedItem.ToString(),
                SoLuong = Convert.ToInt32(numericUpDown4.Value.ToString()),
                ThanhTien = Convert.ToInt32(numericUpDown4.Value.ToString())
                            * BLL_Sach.Instance.Bll_GetGiaNhapByMaSach(cbbMaSach.SelectedItem.ToString()),
            };
            int tong = Convert.ToInt32(txtTong.Text);
            txtTong.Text = (tong + ct.ThanhTien).ToString();
            foreach (ChiTietHoaDonNhap p in list)
            {
                if (ct.MaSach == p.MaSach)
                {
                    p.SoLuong += ct.SoLuong;
                    p.ThanhTien = p.SoLuong * BLL_Sach.Instance.Bll_GetGiaNhapByMaSach(p.MaSach);
                    setData2();
                    return;
                }
            }
            list.Add(ct);
            setData2();
            return;
        }

        private void XacNhan_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Giỏ hàng rỗng", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            HoaDonNhap hdn = new HoaDonNhap()
            {
                MaDonNhap = Convert.ToInt32(txtMaDN.Text),
                NgayNhap = dateTimePicker1.Value,
            };
            BLL_HoaDonNhap.Instance.Bll_AddHoaDonNhap(hdn);
            foreach (ChiTietHoaDonNhap a in list)
            {
                BLL_ChiTietHoaDonNhap.Instance.Bll_AddChiTietHoaDonNhap(a);
                string maSach = a.MaSach;
                int soLuongnhap = (int)a.SoLuong;
                int soLuongNow = BLL_Sach.Instance.Bll_GetSLByMaSach(maSach);
                BLL_Sach.Instance.Bll_EditSLByMaSach(maSach, soLuongNow + soLuongnhap);
            }
            list.Clear();
            dataGridView2.DataSource = null;
            txtMaDN.Text = "";
            cbbMaSach.SelectedIndex = 0;
            numericUpDown4.Value = 0;
            txtTong.Text = "0";
            setData1();
            MessageBox.Show("Nhập thành công", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            txtTong.Text = "0";
            txtMaDN.Enabled = false;
        }

        private void XoaChiTiet_Click(object sender, EventArgs e)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Giỏ hàng rỗng", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewSelectedRowCollection r = dataGridView2.SelectedRows;
            int tong = Convert.ToInt32(txtTong.Text);
            foreach (DataGridViewRow i in r)
            {
                txtTong.Text = (tong - Convert.ToInt32(i.Cells[4].Value.ToString())).ToString();
                list.RemoveAt(i.Index);
            }
            if (list.Count != 0)
            {
                setData2();
            }
            else
            {
                dataGridView2.DataSource = null;
                txtTong.Text = "0";
            }
            
        }

        private void cbbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            setData1();
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {
            if (cbbTheLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn 'Thể loại'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string theloai = cbbTheLoai.SelectedItem.ToString();
            string name = txtTenSach.Text;
            dataGridView1.DataSource = BLL_Sach.Instance.Bll_GetSachByNameAndLS(name, theloai);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count > 1)
            {
                MessageBox.Show("Chỉ được phép chỉnh sửa một hàng", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormThemSach f = new FormThemSach();
            f.masach = dataGridView1.CurrentRow.Cells["MaSach"].Value.ToString();
            f.Show();
            f.reset = new FormThemSach.MyDel(setData1);
        }

        private void XoaSach_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow i in r)
            {
                string maSach = i.Cells["MaSach"].Value.ToString();
                BLL_Sach.Instance.Bll_ChaneTrangThaiSach(maSach);
            }
            setData1();
        }

        private void AddHoaDon_Click(object sender, EventArgs e)
        {
            txtMaDN.Text = BLL_HoaDonNhap.Instance.Bll_CreateHDN();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            List<string> LMS = new List<string>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                LMS.Add(dataGridView1.Rows[i].Cells["MaSach"].Value.ToString());
            }
            string CategorySort = cbbSort.SelectedItem.ToString();
            dataGridView1.DataSource = BLL_Sach.Instance.Bll_SapXepSach(LMS, CategorySort);
        }

        private void cbbTheLoai_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            setData1();
        }

        private void txtTenSach_TextChanged_1(object sender, EventArgs e)
        {
            //if (cbbTheLoai.SelectedIndex == -1)
            //{
            //    MessageBox.Show("Vui lòng chọn 'Thể loại'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //string theloai = cbbTheLoai.SelectedItem.ToString();
            //string name = txtTenSach.Text;
            //dataGridView1.DataSource = BLL_Sach.Instance.Bll_GetSachByNameAndLS(name, theloai);
            setData1();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbMaSach.SelectedItem = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            numericUpDown4.Value = 1;
        }
    }
}
