using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.BLL;

namespace GUI
{
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
            setcbbSort();
        }

        public void setData()
        {
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetAllNhanVien();
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
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[12].Visible = false;
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
            ThemNhanViens f = new ThemNhanViens();
            f.maNV = null;
            f.d = new ThemNhanViens.MyDel(setData);
            f.Show();
        }

        private void ChinhSua_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if(r.Count > 1)
            {
                MessageBox.Show("Chi duoc phep Edit 1 Row");
                return;
            }
            ThemNhanViens f = new ThemNhanViens();
            f.maNV = dataGridView1.CurrentRow.Cells["MaNhanVien"].Value.ToString();
            f.Show();
            f.d = new ThemNhanViens.MyDel(setData);
        }

        private void Xoa_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection r = dataGridView1.SelectedRows;
            if (r.Count == 0)
            {
                MessageBox.Show("Chon Row can xoa");
                return;
            }
            foreach (DataGridViewRow i in r)
            {
                string manv = i.Cells["MaNhanVien"].Value.ToString();
                BLL_QuanLy.Instance.Bll_ChangeTrangThaiNV(manv);
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
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_SapXepNV(LMNV, CategorySort);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string a = txtName.Text;
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetNhanVienByName(a);
        }
    }
}
