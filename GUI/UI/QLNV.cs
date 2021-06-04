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
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetAllViewNhanVien();
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
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetViewNhanVienByName(a);
        }
    }
}
