using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveCharts;
using PBL3.BLL;
using LiveCharts.Wpf;
using System.Reflection;

namespace PBL3.UI
{
    public partial class Thongke : Form
    {
        public delegate void MyDel(Form childForm);
        public static MyDel Sender;
        public Thongke()
        {
            InitializeComponent();
            setData();
            setcbbNam();
            setcbbSort();
        }   

        public void setData()
        {
            dataGridView1.DataSource = BLL_QuanLy.Instance.BLL_GetAllDoanhSoBanHang();      
        }

        private void NextPage_Click(object sender, EventArgs e)
        {
            BaoCaoDoanhThu f = new BaoCaoDoanhThu();
            f.Sender = new BaoCaoDoanhThu.MyDel(Sender);
            Sender(f);
        }

        public void setcbbNam()
        {
            for (int i=2000; i<=DateTime.Now.Year;i++)
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

        private void setNumbericYearUpdown()
        {
            num1.Maximum = num2.Maximum = DateTime.Now.Year;
            num1.Minimum = num2.Minimum = 0;
            num1.Value = num1.Maximum;
            num2.Value = num2.Maximum - 1;
            num3.Visible = false;
        }

        private void setNumbericMonthUpdown()
        {
            num1.Maximum = num2.Maximum = 12;
            num1.Minimum = num2.Minimum = 1;
            num1.Value = DateTime.Now.Month;
            num2.Value = num1.Value - 1;
            num3.Maximum = DateTime.Now.Year;
            num3.Minimum = 0;
            num3.Value = num3.Maximum;
            num3.Visible = true;
        }

        public void setcbbSort()
        {
            Type type = typeof(DOANH_SO_BAN_HANG);
            PropertyInfo[] propertyinfo = type.GetProperties();
            foreach (PropertyInfo info in propertyinfo)
            {
                if (info.Name == "NHAN_VIEN") break;
                cbbSort.Items.Add(info.Name);
            }
            cbbSort.SelectedIndex = 0;
        }

        private void setBestSeller()
        {
            lbBestSeller.Text = "";
            if (dataGridView1.Rows.Count == 0)
            {              
                return;
            }
            List<string> lMaNV = new List<string>();
            List<int> money = new List<int>();
            int tong = 0;

            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                if(lMaNV.Count == 0)
                {
                    lMaNV.Add(i.Cells["MaNhanVien"].Value.ToString());
                }
                else
                {
                    for (int j = 0; j < lMaNV.Count; j++)
                    {
                        if (i.Cells["MaNhanVien"].Value.ToString() != lMaNV[j])
                        {
                            lMaNV.Add(i.Cells["MaNhanVien"].Value.ToString());
                        }
                    }
                }
            }

            for(int i = 0; i < lMaNV.Count; i++)
            {
                foreach (DataGridViewRow dg in dataGridView1.Rows)
                {
                    if(lMaNV[i] == dg.Cells["MaNhanVien"].Value.ToString())
                    {
                        tong += Convert.ToInt32(dg.Cells["DoanhSoBan"].Value.ToString());
                    }                    
                }
                money.Add(tong);
                tong = 0;
            }

            List<string> listMa = new List<string>();
            int max = money[0];
            for(int i = 0; i < money.Count; i++)
            {
                if (money[i] > max) max = money[i];  
            }
            for(int i = 0; i < lMaNV.Count; i++)
            {
                if(money[i] == max)
                {
                    listMa.Add(lMaNV[i]);
                }
            }
            foreach(string i in listMa)
            {
                lbBestSeller.Text = BLL_QuanLy.Instance.Bll_GetNameNVByMaNV(i);
            }
        }
        private void setBackground()
        {
            int Tong = 0;
            lb1.Text = dataGridView1.Rows.Count.ToString();
            foreach (DataGridViewRow i in dataGridView1.Rows)
            {
                Tong += Convert.ToInt32(i.Cells["DoanhSoBan"].Value.ToString());
            }
            TongDoanhSo.Text = Tong.ToString();
            setBestSeller();
            dataGridView1.Columns["NHAN_VIEN"].Visible = false;
        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbThang.Items.Clear();
            cbbNgay.Items.Clear();
            cbbThang.Text = "";
            cbbNgay.Text = "";
            setcbbThang();
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetDoanhSoBanHangFolowNam(Convert.ToInt32(cbbNam.SelectedItem.ToString()));
            setBackground();
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            setcbbNgay();
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetDoanhSoBanHangFolowNamThang(Convert.ToInt32(cbbNam.SelectedItem.ToString()), Convert.ToInt32(cbbThang.SelectedItem.ToString()));
            setBackground();
        }

        private void cbbNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetDoanhSoBanHangFolowNamThangNgay(Convert.ToInt32(cbbNam.SelectedItem.ToString()),
                Convert.ToInt32(cbbThang.SelectedItem.ToString()), 
                Convert.ToInt32(cbbNgay.SelectedItem.ToString()));
            setBackground();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            setBackground();
            radioYear.Checked = true;
        }

        private void setChart(string Category)
        {
            salesChart.AxisX.Clear();
            salesChart.AxisY.Clear();
            if(Category == "Year")
            {
                salesChart.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Thang",
                    Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" }
                });
                salesChart.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Doanh So",
                    LabelFormatter = value => value.ToString("N0") + " VND"
                });
                salesChart.LegendLocation = LiveCharts.LegendLocation.Right;
            }
            else
            {
                salesChart.AxisX.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Ngay",
                    Labels = new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" }
                });
                salesChart.AxisY.Add(new LiveCharts.Wpf.Axis
                {
                    Title = "Doanh So",
                    LabelFormatter = value => value.ToString("N0") + " VND"
                });
                salesChart.LegendLocation = LiveCharts.LegendLocation.Right;
            }
        }

        private void loadChart(int num1, int num2, int num3 = -1)
        {
            salesChart.Series.Clear();
            salesChart.Series = BLL_QuanLy.Instance.Bll_GetValueChart_Sales(num1, num2, num3);
        }

        private void radioYear_CheckedChanged(object sender, EventArgs e)
        {
            if(radioYear.Checked)
            {
                setNumbericYearUpdown();
                setChart("Year");
                loadChart((int)num1.Value, (int)num2.Value);
            }
            else
            {
                setNumbericMonthUpdown();
                setChart("Month");
                loadChart((int)num1.Value, (int)num2.Value, (int)num3.Value);
            }

        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (radioYear.Checked)
            {
                loadChart((int)num1.Value, (int)num2.Value);
            }
            else
            {
                loadChart((int)num1.Value, (int)num2.Value, (int)num3.Value);
            }
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            List<int> LSTT = new List<int>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                LSTT.Add((int)dataGridView1.Rows[i].Cells[0].Value);
            }
            string CategorySort = cbbSort.SelectedItem.ToString();
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_Sort_Sales(LSTT, CategorySort);
        }

        private void cbbNam_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbbThang.Items.Clear();
            cbbNgay.Items.Clear();
            cbbThang.Text = "";
            cbbNgay.Text = "";
            setcbbThang();
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetDoanhSoBanHangFolowNam(Convert.ToInt32(cbbNam.SelectedItem.ToString()));
            setBackground();
        }

        private void cbbThang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            setcbbNgay();
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetDoanhSoBanHangFolowNamThang(Convert.ToInt32(cbbNam.SelectedItem.ToString()), Convert.ToInt32(cbbThang.SelectedItem.ToString()));
            setBackground();
        }

        private void cbbNgay_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = BLL_QuanLy.Instance.Bll_GetDoanhSoBanHangFolowNamThangNgay(Convert.ToInt32(cbbNam.SelectedItem.ToString()),
                Convert.ToInt32(cbbThang.SelectedItem.ToString()),
                Convert.ToInt32(cbbNgay.SelectedItem.ToString()));
            setBackground();
        }
    }
}
