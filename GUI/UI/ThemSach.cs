using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;
using PBL3.DTO;

namespace PBL3.UI
{
    public partial class ThemSach : Form
    {
        public string masach { get; set; }
        public delegate void MyDel();
        public MyDel reset;
        string boxTitle = "Thông báo";
        public bool check { get; set; }
        public ThemSach()
        {
            InitializeComponent();
            setcbbNXB();
            setcbbTL();
        }

        public void setcbbNXB()
        {
            cbbNXB.Items.Clear();
            foreach(string i in BLL_NhaXuatBan.Instance.Bll_GetAllMaNXB())
            {
                cbbNXB.Items.Add(i);
            }
        }

        public void setcbbTL()
        {
            cbbTL.Items.Clear();
            foreach (string i in BLL_LoaiSach.Instance.Bll_GetAllMaLS())
            {
                cbbTL.Items.Add(i);
            }
        }

        private void ThemNXB_Click(object sender, EventArgs e)
        {
            ThemNXB f = new ThemNXB();
            f.Show();
            f.d = new ThemNXB.MyDel(setcbbNXB);
        }

        private void ThemTheLoai_Click(object sender, EventArgs e)
        {
            ThemTLSach f = new ThemTLSach();
            f.Show();
            f.d = new ThemTLSach.MyDel(setcbbTL);
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool CheckMaSach()
        {
            if(txtMaSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập 'Mã sách'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            foreach(string i in BLL_Sach.Instance.Bll_GetAllMaSach())
            {
                if(txtMaSach.Text == i)
                {
                    MessageBox.Show("'Mã sách' đã tồn tại", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            if(txtMaSach.Text.Length > 5)
            {
                MessageBox.Show("'Mã sách' không được quá 5 kí tự", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool CheckTenSach()
        {
            if(txtTenSach.Text == "")
            {
                MessageBox.Show("Vui lòng nhập 'Tên sách'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(txtTenSach.TextLength > 30)
            {
                MessageBox.Show("'Tên sách không được quá 30 kí tự", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool CheckGia(string a)
        {
            if(a == "")
            {
                MessageBox.Show("Vui lòng nhập 'Giá'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            for (int i = 0; i < a.Length; i++)
            {
                if ((int)a[i] < 48 || (int)a[i] > 57)
                {
                    MessageBox.Show("'Giá' không hợp lệ", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }
        private void AddSach()
        {
            if (CheckMaSach() == false) return;
            if (CheckTenSach() == false) return;
            if (CheckGia(txtGiaNhap.Text) == false) return;
            if (CheckGia(txtGiaBan.Text) == false) return;
            if (cbbNXB.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn 'Nhà xuất bản'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbbTL.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn 'Thể loại sách's", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Sach a = new Sach();
            a.MaSach = txtMaSach.Text;
            a.TenSach = txtTenSach.Text;
            a.GiaNhap = Convert.ToInt32(txtGiaNhap.Text);
            a.GiaBan = Convert.ToInt32(txtGiaBan.Text);
            a.SoLuong = 0;
            a.MaNXB = cbbNXB.SelectedItem.ToString();
            a.MaLoaiSach = cbbTL.SelectedItem.ToString();
            BLL_Sach.Instance.Bll_AddSach(a);
            check = true;
        }
        private void EditSach()
        {
            if (CheckTenSach() == false) return;
            if (CheckGia(txtGiaNhap.Text) == false) return;
            if (CheckGia(txtGiaBan.Text) == false) return;
            if (cbbNXB.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn 'Nhà xuất bản'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbbTL.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn 'Thể loại sách'", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Sach a = new Sach();
            a.MaSach = txtMaSach.Text;
            a.TenSach = txtTenSach.Text;
            a.GiaNhap = Convert.ToInt32(txtGiaNhap.Text);
            a.GiaBan = Convert.ToInt32(txtGiaBan.Text);
            a.SoLuong = 0;
            a.MaNXB = cbbNXB.SelectedItem.ToString();
            a.MaLoaiSach = cbbTL.SelectedItem.ToString();
            BLL_Sach.Instance.Bll_EditSach(a);
            check = true;
        }
        private void XacNhan_Click(object sender, EventArgs e)
        {
            if(masach == null)
            {
                AddSach();
            }
            else
            {
                EditSach();
            }
            if(check) reset();
        }

        private void ThemSach_Load(object sender, EventArgs e)
        {
            check = false;
            if(masach != null)
            {
                txtMaSach.Text = masach; txtMaSach.Enabled = false;
                Sach a = new Sach();
                a = BLL_Sach.Instance.Bll_GetSachByMaSach(masach);
                txtTenSach.Text = a.TenSach;
                txtGiaNhap.Text = a.GiaNhap.ToString();
                txtGiaNhap.Enabled = false;
                txtGiaBan.Text = a.GiaBan.ToString();
                cbbNXB.SelectedItem = a.MaNXB;
                cbbTL.SelectedItem = a.MaLoaiSach;
            }
        }
    }
}
