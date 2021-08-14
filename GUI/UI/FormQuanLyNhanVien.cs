using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.BLL;

namespace PBL3.UI
{
    public partial class FormQuanLyNhanVien : Form
    {
        string boxTitle = "Thông báo";
        public delegate void Mydel();
        public Mydel Exit_QuanLy;
        Thread Luong;
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
            setcbbSort();
        }

        public void setData()
        {
            dataGridView1.DataSource = BLL_NhanVien.Instance.Bll_GetNhanVienByName(txtName.Text);
            dataGridView1.Columns["MaNhanVien"].HeaderText = "Mã nhân viên";
            dataGridView1.Columns["HoTen"].HeaderText = "Họ tên";
            dataGridView1.Columns["DanToc"].HeaderText = "Dân tộc";
            dataGridView1.Columns["GioiTinh"].HeaderText = "Giới tính";
            dataGridView1.Columns["CMND"].HeaderText = "CMND";
            dataGridView1.Columns["SoDienThoai"].HeaderText = "Số điện thoại";
            dataGridView1.Columns["QueQuan"].HeaderText = "Quê quán";
            dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dataGridView1.Columns["TrangThai"].HeaderText = "Trạng thái";
            dataGridView1.Columns["isAdmin"].HeaderText = "Admin";
        }

        public void setcbbSort()
        {
            cbbSort.Items.AddRange(new String[]
            {
                "Ho Ten", "Gioi Tinh", "Ngay Sinh"
            });
            cbbSort.SelectedIndex = 0;
        }

        private void Them_Click(object sender, EventArgs e)
        {
            FormThemNhanViens f = new FormThemNhanViens();
            f.maNV = null;
            f.d = new FormThemNhanViens.MyDel(setData);
            f.Show();
        }

        private void ChinhSua_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if(r.Count > 1)
            {
                MessageBox.Show("Chỉ được phép chỉnh sửa 1 hàng", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            FormThemNhanViens f = new FormThemNhanViens();
            f.maNV = dataGridView1.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            f.Show();
            f.d = new FormThemNhanViens.MyDel(setData);
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hàng cần xóa", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            foreach (DataGridViewRow i in r)
            {
                string manv = i.Cells["MaNhanVien"].Value.ToString();
                if(manv == BLL_NhanVien.Instance.Bll_SearchAdim())
                {
                    MessageBox.Show("Bạn đang là Admin", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else BLL_NhanVien.Instance.Bll_ChangeTrangThaiNV(manv);
            }
            setData();
        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            setData();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            List<string> LMNV = new List<string>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                LMNV.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
            string CategorySort = cbbSort.SelectedItem.ToString();
            dataGridView1.DataSource = BLL_NhanVien.Instance.Bll_SapXepNV(LMNV, CategorySort);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string a = txtName.Text;
            dataGridView1.DataSource = BLL_NhanVien.Instance.Bll_GetNhanVienByName(a);
        }

        private void openFormDangNhap(object newForm)
        {
            FormDangNhap f = new FormDangNhap();
            Application.Run(f);
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count > 1)
            {
                MessageBox.Show("Chỉ được phép Edit một hàng", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        
            string maNV = dataGridView1.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            if (BLL_NhanVien.Instance.Bll_CheckAdmin(maNV))
            {
                MessageBox.Show("Nhân viên này hiện đang là Admin", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!BLL_NhanVien.Instance.Bll_CheckTrangThai(maNV))
            {
                MessageBox.Show("Nhân viên hiện không còn hoạt động", boxTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DialogResult result;
            result = MessageBox.Show("Bạn chắc chắn đổi Admin không ?", boxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == System.Windows.Forms.DialogResult.Yes)
            {
                BLL_NhanVien.Instance.Bll_ChangeAdmin(maNV);
                Exit_QuanLy();
                Luong = new Thread(openFormDangNhap);
                Luong.SetApartmentState(ApartmentState.STA);
                Luong.Start();
            }
        }
    }
}
