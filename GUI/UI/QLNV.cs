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
    public partial class QLNV : Form
    {
        public QLNV()
        {
            InitializeComponent();
        }

        public void setData()
        {
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetAllNhanVien();
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
        }
        private void Xem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetAllNhanVien();
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
                BLL_QuanLy.Instance.Bll_OffNVByMaNV(manv);
            }
            setData();
        }

        private void SapXep_Click(object sender, EventArgs e)
        {

        }

        private void QLNV_Load(object sender, EventArgs e)
        {
            setData();
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetNhanVienByName(a);
        }
    }
}
