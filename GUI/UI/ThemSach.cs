using System;
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
    public partial class ThemSach : Form
    {
        public string masach { get; set; }
        public delegate void MyDel();
        public MyDel d;
        public ThemSach()
        {
            InitializeComponent();
            setcbbNXB();
            setcbbTL();
        }

        public void setcbbNXB()
        {
            cbbNXB.Items.Clear();
            foreach(string i in BLL_QuanLy.Instance.Bll_GetAllMaNXB())
            {
                cbbNXB.Items.Add(i);
            }
        }

        public void setcbbTL()
        {
            cbbTL.Items.Clear();
            foreach (string i in BLL_QuanLy.Instance.Bll_GetAllMaLS())
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
            foreach(string i in BLL_QuanLy.Instance.Bll_GetAllMaSach())
            {
                if(txtMaSach.Text == i)
                {
                    MessageBox.Show("Mã sách đã tồn tại");
                    return false;
                }
            }
            if(txtMaSach.Text.Length > 5)
            {
                MessageBox.Show("Mã sách không quá 5 kí tự");
                return false;
            }
            return true;
        }
        private bool CheckTenSach()
        {
            if(txtTenSach.TextLength > 30)
            {
                MessageBox.Show("Tên sách không quá 30 kí tự");
                return false;
            }
            return true;
        }
        private bool CheckGia(string a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if ((int)a[i] < 48 || (int)a[i] > 57)
                {
                    MessageBox.Show("Giá bán không hợp lệ");
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
                MessageBox.Show("Vui lòng chọn NXB");
                return;
            }
            if (cbbTL.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Thể loại sách");
                return;
            }
            SACH a = new SACH();
            a.MaSach = txtMaSach.Text;
            a.TenSach = txtTenSach.Text;
            a.GiaNhap = Convert.ToInt32(txtGiaNhap.Text);
            a.GiaBan = Convert.ToInt32(txtGiaBan.Text);
            a.SoLuong = 0;
            a.MaNXB = cbbNXB.SelectedItem.ToString();
            a.MaLoaiSach = cbbTL.SelectedItem.ToString();
            BLL_QuanLy.Instance.Bll_AddSach(a);
        }
        private void EditSach()
        {
            if (CheckTenSach() == false) return;
            if (CheckGia(txtGiaNhap.Text) == false) return;
            if (CheckGia(txtGiaBan.Text) == false) return;
            if (cbbNXB.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn NXB");
                return;
            }
            if (cbbTL.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Thể loại sách");
                return;
            }
            SACH a = new SACH();
            a.MaSach = txtMaSach.Text;
            a.TenSach = txtTenSach.Text;
            a.GiaNhap = Convert.ToInt32(txtGiaNhap.Text);
            a.GiaBan = Convert.ToInt32(txtGiaBan.Text);
            a.SoLuong = 0;
            a.MaNXB = cbbNXB.SelectedItem.ToString();
            a.MaLoaiSach = cbbTL.SelectedItem.ToString();
            BLL_QuanLy.Instance.Bll_EditSach(a);
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
            d();
        }

        private void ThemSach_Load(object sender, EventArgs e)
        {
            if(masach != null)
            {
                txtMaSach.Text = masach; txtMaSach.Enabled = false;
                SACH a = new SACH();
                a = BLL_QuanLy.Instance.Bll_GetSachByMaSach(masach);
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
