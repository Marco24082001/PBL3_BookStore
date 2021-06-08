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
using GUI.BLL;

namespace GUI
{
    public partial class QuanLySach : Form
    {
        List<CHI_TIET_HOA_DON_NHAP> list = new List<CHI_TIET_HOA_DON_NHAP>();
        public QuanLySach()
        {
            InitializeComponent();
            setcbbMaSach();
            setcbbTheLoai();
            setcbbSort();
        }
        public void setData1()
        {
            if (cbbTheLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long chon loai sach");
                return;
            }
            if (cbbTheLoai.SelectedIndex == 0)
            {
                dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetAllSach();
            }
            else
            {
                string ls = cbbTheLoai.SelectedItem.ToString();
                dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetSachByLS(ls);
            }
            dataGridView1.Columns["MaSach"].HeaderText = "Mã sách";
            dataGridView1.Columns["TenSach"].HeaderText = "Tên sách";
            dataGridView1.Columns["GiaBan"].HeaderText = "Giá bán";
            dataGridView1.Columns["GiaNhap"].HeaderText = "Giá nhập";
            dataGridView1.Columns["SoLuong"].HeaderText = "Số lượng";
            dataGridView1.Columns["MaNXB"].HeaderText = "Nhà xuất bản";
            dataGridView1.Columns["MaLoaiSach"].HeaderText = "Thể loại";
            dataGridView1.Columns["TrangThai"].HeaderText = "Trạng thái";
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
        }
        public void setData2()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = list;
            dataGridView2.Columns["MaDonNhap"].HeaderText = "Mã đơn nhập";
            dataGridView2.Columns["MaSach"].HeaderText = "Mã sách";
            dataGridView2.Columns["SoLuong"].HeaderText = "Số lượng";
            dataGridView2.Columns["ThanhTien"].HeaderText = "Thành tiền";
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[5].Visible = false;
            dataGridView2.Columns[6].Visible = false;
            if (list.Count != 0) dataGridView2.CurrentCell = dataGridView2.Rows[0].Cells[1];
        }
        public void setcbbMaSach()
        {
            foreach(string i in BLL_QuanLy.Instance.Bll_GetAllMaSach())
            {
                cbbMaSach.Items.Add(i);
            }
        }
        public void setcbbTheLoai()
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

        private void Them_Click(object sender, EventArgs e)
        {
            foreach(CHI_TIET_HOA_DON_NHAP i in list)
            {
                BLL_QuanLy.Instance.Bll_AddChiTietHoaDonNhap(i);
            }
        }

        private void ThemSach_Click(object sender, EventArgs e)
        {
            ThemSach f = new ThemSach();
            f.Show();
            f.d += new ThemSach.MyDel(setData1);
        }
        private void ThemChiTiet_Click(object sender, EventArgs e)
        {
            if(txtMaDN.Text == "")
            {
                MessageBox.Show("Nhap ma hoa don");
                return;
            }
            if(cbbMaSach.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn mã sách");
                return;
            }
            CHI_TIET_HOA_DON_NHAP ct = new CHI_TIET_HOA_DON_NHAP()
            {
                MaDonNhap = Convert.ToInt32(txtMaDN.Text),
                MaSach = cbbMaSach.SelectedItem.ToString(),
                SoLuong = Convert.ToInt32(numericUpDown4.Value.ToString()),
                ThanhTien = Convert.ToInt32(numericUpDown4.Value.ToString())
                            * BLL_QuanLy.Instance.Bll_GetGiaNhapByMaSach(cbbMaSach.SelectedItem.ToString()),
            };
            int tong = Convert.ToInt32(txtTong.Text);
            txtTong.Text = (tong + ct.ThanhTien).ToString();
            foreach (CHI_TIET_HOA_DON_NHAP p in list)
            {
                if (ct.MaSach == p.MaSach)
                {
                    p.SoLuong += ct.SoLuong;
                    p.ThanhTien = p.SoLuong * BLL_QuanLy.Instance.Bll_GetGiaNhapByMaSach(p.MaSach);
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
            if(list.Count == 0)
            {
                MessageBox.Show("Gio Hang rỗng");
                return;
            }
            HOA_DON_NHAP hdn = new HOA_DON_NHAP()
            {
                MaDonNhap = Convert.ToInt32(txtMaDN.Text),
                NgayNhap = DateTime.Now,
                GhiChu = "",
            };
            BLL_QuanLy.Instance.Bll_AddHoaDonNhap(hdn);
            foreach (CHI_TIET_HOA_DON_NHAP a in list)
            {
                BLL_QuanLy.Instance.Bll_AddChiTietHoaDonNhap(a);
                string maSach = a.MaSach;
                int soLuongnhap = (int)a.SoLuong;
                int soLuongNow = BLL_QuanLy.Instance.Bll_GetSLByMaSach(maSach);
                BLL_QuanLy.Instance.Bll_EditSLByMaSach(maSach, soLuongNow + soLuongnhap);
            }
            list.Clear();
            dataGridView2.DataSource = null;
            txtMaDN.Text = "";
            cbbMaSach.SelectedIndex = 0;
            numericUpDown4.Value = 0;
            txtTong.Text = "0";
            setData1();
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            txtTong.Text = "0";
            txtMaDN.Enabled = false;
        }

        private void XoaChiTiet_Click(object sender, EventArgs e)
        {            
            if(list.Count == 0)
            {
                MessageBox.Show("Gio hang rong");
                return;
            }
            DataGridViewSelectedRowCollection r = dataGridView2.SelectedRows;
            foreach (DataGridViewRow i in r)
            {
                list.RemoveAt(i.Index);
            }
            if(list.Count != 0)
            {
                setData2();
            }
            else
            {
                dataGridView2.DataSource = null;
            }
            txtTong.Text = "0";
        }

        private void cbbTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            setData1();
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {
            if(cbbTheLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long chon The Loai");
                return;
            }
            string theloai = cbbTheLoai.SelectedItem.ToString();
            string name = txtTenSach.Text;
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetSachByNameAndLS(name, theloai);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count > 1)
            {
                MessageBox.Show("Chi duoc phep Edit 1 Row");
                return;
            }
            ThemSach f = new ThemSach();
            f.masach = dataGridView1.CurrentRow.Cells["MaSach"].Value.ToString();
            f.Show();
            f.d = new ThemSach.MyDel(setData1);
        }

        private void XoaSach_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count == 0)
            {
                MessageBox.Show("Chon Row can xoa");
                return;
            }
            foreach (DataGridViewRow i in r)
            {
                string maSach = i.Cells["MaSach"].Value.ToString();
                BLL_QuanLy.Instance.Bll_ChaneTrangThaiSach(maSach);
            }
            setData1();
        }

        private void AddHoaDon_Click(object sender, EventArgs e)
        {
            txtMaDN.Text = BLL_QuanLy.Instance.Bll_CreateHDN();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cbbMaSach.SelectedItem = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            numericUpDown4.Value = 1;
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            List<string> LMS = new List<string>();
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                LMS.Add(dataGridView1.Rows[i].Cells["MaSach"].Value.ToString());
            }
            string CategorySort = cbbSort.SelectedItem.ToString();
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_SapXepSach(LMS, CategorySort);
        }

        private void cbbTheLoai_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            setData1();
        }

        private void txtTenSach_TextChanged_1(object sender, EventArgs e)
        {
            if (cbbTheLoai.SelectedIndex == -1)
            {
                MessageBox.Show("Vui long chon The Loai");
                return;
            }
            string theloai = cbbTheLoai.SelectedItem.ToString();
            string name = txtTenSach.Text;
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetSachByNameAndLS(name, theloai);
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
        }
    }
}
