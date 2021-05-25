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
    public partial class BaoCaoDoanhThu : Form
    {
        public delegate void MyDel(Form childForm);
        public MyDel Sender;
        public BaoCaoDoanhThu()
        {
            InitializeComponent();
            setData();
            setcbbNam();
        }

        public void setData()
        {
            dataGridView2.DataSource = BLL_QuanLy.Instance.Bll_GetAllBaoCaoDT();
        }

        private void backPage_Click(object sender, EventArgs e)
        {
            ThongKe f = new ThongKe();
            Sender(f);
        }
        public void setcbbNam()
        {
            for (int i = 2000; i <= DateTime.Now.Year; i++)
            {
                cbbNam.Items.Add(i.ToString());
            }
        }
        private void setcbbThang()
        {
            for (int i = 1; i <= 12; i++)
            {
                cbbThang.Items.Add(i.ToString());
            }
        }
        private void setcbbNgay()
        {
            cbbNgay.Items.Clear();
            cbbNgay.Text = "";
            if (cbbThang.SelectedItem.ToString() == "1"
                || cbbThang.SelectedItem.ToString() == "3"
                || cbbThang.SelectedItem.ToString() == "5"
                || cbbThang.SelectedItem.ToString() == "7"
                || cbbThang.SelectedItem.ToString() == "8"
                || cbbThang.SelectedItem.ToString() == "10"
                || cbbThang.SelectedItem.ToString() == "12"
                )
            {
                for (int i = 1; i <= 31; i++)
                {
                    cbbNgay.Items.Add(i.ToString());
                }
            }
            else if (cbbThang.SelectedItem.ToString() == "2" && Convert.ToInt32(cbbNam.SelectedItem.ToString()) % 4 == 0)
            {
                cbbNgay.Items.Clear();
                for (int i = 1; i <= 29; i++)
                {
                    cbbNgay.Items.Add(i.ToString());
                }
            }
            else if (cbbThang.SelectedItem.ToString() == "2")
            {
                cbbNgay.Items.Clear();
                for (int i = 1; i <= 28; i++)
                {
                    cbbNgay.Items.Add(i.ToString());
                }
            }
            else
            {
                for (int i = 1; i <= 30; i++)
                {
                    cbbNgay.Items.Add(i.ToString());
                }
            }
        }
        private void setBackground()
        {
            int Tong = 0;
            foreach (DataGridViewRow i in dataGridView2.Rows)
            {
                Tong += Convert.ToInt32(i.Cells["DoanhThu"].Value.ToString());
            }
            TongDoanhThu.Text = Tong.ToString();
        }
        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbThang.Items.Clear();
            cbbNgay.Items.Clear();
            cbbThang.Text = "";
            cbbNgay.Text = "";
            setcbbThang();
            dataGridView2.DataSource = BLL_QuanLy.Instance.Bll_GetBaoCaoDoanhThuFolowNam(Convert.ToInt32(cbbNam.SelectedItem.ToString()));
            setBackground();
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            setcbbNgay();
            dataGridView2.DataSource = BLL_QuanLy.Instance.Bll_GetBaoCaoDoanhThuFolowNamThang(Convert.ToInt32(cbbNam.SelectedItem.ToString()), Convert.ToInt32(cbbThang.SelectedItem.ToString()));
            setBackground();
        }

        private void cbbNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = BLL_QuanLy.Instance.Bll_GetBaoCaoDoanhThuFolowNamThangNgay(Convert.ToInt32(cbbNam.SelectedItem.ToString()), Convert.ToInt32(cbbThang.SelectedItem.ToString()), Convert.ToInt32(cbbNgay.SelectedItem.ToString()));
            setBackground();
        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            setBackground();
        }
    }
}
