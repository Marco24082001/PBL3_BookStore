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
using PBL3.BLL;
using LiveCharts;
using LiveCharts.Wpf;

namespace PBL3.UI
{
    public partial class FormBaoCaoDoanhThu : Form
    {
        public delegate void MyDel(Form childForm);
        public MyDel Sender;
        public FormBaoCaoDoanhThu()
        {
            InitializeComponent();
            setData();
            setcbbNam();
            setcbbSort();
            setNumbericDayUpdown();
        }

        public void setData()
        {
            dataGridView1.DataSource = BLL_BaoCaoDoanhThu.Instance.Bll_GetViewBaoCaoDT();
            dataGridView1.Columns["STT"].HeaderText = "Số TT";
            dataGridView1.Columns["TenSach"].HeaderText = "Tên sách";
            dataGridView1.Columns["GiaBan"].HeaderText = "Giá bán";
            dataGridView1.Columns["GiaNhap"].HeaderText = "Giá nhập";
            dataGridView1.Columns["SoLuong"].HeaderText = "Số lượng";
            dataGridView1.Columns["DoanhThu"].HeaderText = "Doanh Thu";
            dataGridView1.Columns["ThoiGian"].DefaultCellStyle.Format = "dd/MM/yyyy";
            dataGridView1.Columns["ThoiGian"].HeaderText = "Thời Gian";
        }

        private void backPage_Click(object sender, EventArgs e)
        {
            FormBaoCaoDoanhSo f = new FormBaoCaoDoanhSo();
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

        public void setcbbSort()
        {
            Type type = typeof(BAO_CAO_DOANH_THU);
            PropertyInfo[] propertyinfo = type.GetProperties();
            foreach (PropertyInfo info in propertyinfo)
            {
                if (info.Name == "SACH") break;
                cbbSort.Items.Add(info.Name);
            }
            cbbSort.SelectedIndex = 0;
        }

        public void setNumbericDayUpdown()
        {
            numDay.Maximum = 365;
            numDay.Minimum = 1;
            numDay.Value = 6;
        }

        private void setBackground()
        {
            int Tong = 0;
            foreach (DataGridViewRow i in dataGridView1.Rows)
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
            dataGridView1.DataSource = BLL_BaoCaoDoanhThu.Instance.Bll_GetViewBCDTFolowNam(Convert.ToInt32(cbbNam.SelectedItem.ToString()));
            setBackground();
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            setcbbNgay();
            dataGridView1.DataSource = BLL_BaoCaoDoanhThu.Instance.Bll_GetViewBCDTFolowNamThang(Convert.ToInt32(cbbNam.SelectedItem.ToString()), Convert.ToInt32(cbbThang.SelectedItem.ToString()));
            setBackground();
        }

        private void cbbNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_BaoCaoDoanhThu.Instance.Bll_GetViewBCDTFolowNamThangNgay(Convert.ToInt32(cbbNam.SelectedItem.ToString()), Convert.ToInt32(cbbThang.SelectedItem.ToString()), Convert.ToInt32(cbbNgay.SelectedItem.ToString()));
            setBackground();
        }

        private void BaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            setBackground();
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            List<int> LSTT = new List<int>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                LSTT.Add((int)dataGridView1.Rows[i].Cells[0].Value);
            }
            string CategorySort = cbbSort.SelectedItem.ToString();
            dataGridView1.DataSource = BLL_BaoCaoDoanhThu.Instance.Bll_Sort_DoanhThu(LSTT, CategorySort);
        }

        private void setChart(int numDay)
        {
            turnoverChart.AxisX.Clear();
            turnoverChart.AxisY.Clear();
            List<string> Lb = new List<string>();
            foreach(DateTime date in BLL_BaoCaoDoanhThu.Instance.Bll_GetListDate(numDay))
            {
                Lb.Add(date.ToShortDateString());
            }

            turnoverChart.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Ngay",
                Labels = Lb
            });
            turnoverChart.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Doanh Thu",
                LabelFormatter = value => value.ToString("N0") + " VND"
            });
        }

        private void loadChart(int numDay)
        {
            turnoverChart.Series.Clear();
            setChart(numDay);
            turnoverChart.Series.Add(BLL_BaoCaoDoanhThu.Instance.Bll_GetValueChart_Turnover(numDay));
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            loadChart((int)numDay.Value);
        }

        private void numDay_ValueChanged(object sender, EventArgs e)
        {
            loadChart((int)numDay.Value);
        }

        private void cbbNam_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbbThang.Items.Clear();
            cbbNgay.Items.Clear();
            cbbThang.Text = "";
            cbbNgay.Text = "";
            setcbbThang();
            dataGridView1.DataSource = BLL_BaoCaoDoanhThu.Instance.Bll_GetViewBCDTFolowNam(Convert.ToInt32(cbbNam.SelectedItem.ToString()));
            setBackground();
        }

        private void cbbThang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            List<SACH> a = new List<SACH>();
            setcbbNgay();
            dataGridView1.DataSource = BLL_BaoCaoDoanhThu.Instance.Bll_GetViewBCDTFolowNamThang(Convert.ToInt32(cbbNam.SelectedItem.ToString()), Convert.ToInt32(cbbThang.SelectedItem.ToString()));
            setBackground();
        }

        private void cbbNgay_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_BaoCaoDoanhThu.Instance.Bll_GetViewBCDTFolowNamThangNgay(Convert.ToInt32(cbbNam.SelectedItem.ToString()), Convert.ToInt32(cbbThang.SelectedItem.ToString()), Convert.ToInt32(cbbNgay.SelectedItem.ToString()));
            setBackground();
        }
    }
}
