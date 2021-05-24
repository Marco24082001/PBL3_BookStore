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
    public partial class ThongKe : Form
    {
        public delegate void MyDel(Form childForm);
        public static MyDel Sender;
        public ThongKe()
        {
            InitializeComponent();
            setData();
            setcbbNam();
        }   
        public void setData()
        {
            dataGridView2.DataSource = BLL_QuanLy.Instance.BLL_GetAllDoanhSoBanHang();
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

        private void setBestSeller()
        {
            List<string> lMaNV = new List<string>();
            List<int> money = new List<int>();
            int tong = 0;
            foreach (DataGridViewRow i in dataGridView2.Rows)
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
                foreach (DataGridViewRow dg in dataGridView2.Rows)
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
                lbBestSeller.Text += i;
            }
        }
        private void setBackground()
        {
            int Tong = 0;
            lb1.Text = dataGridView2.Rows.Count.ToString();
            foreach(DataGridViewRow i in dataGridView2.Rows)
            {
                Tong += Convert.ToInt32(i.Cells["DoanhSoBan"].Value.ToString());
            }
            TongDoanhSo.Text = Tong.ToString();
            setBestSeller();
        }

        private void cbbNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbThang.Items.Clear();
            cbbNgay.Items.Clear();
            cbbThang.Text = "";
            cbbNgay.Text = "";
            setcbbThang();
            dataGridView2.DataSource = BLL_QuanLy.Instance.Bll_GetDoanhSoBanHangFolowNam(Convert.ToInt32(cbbNam.SelectedItem.ToString()));
            setBackground();
        }

        private void cbbThang_SelectedIndexChanged(object sender, EventArgs e)
        {
            setcbbNgay();
            dataGridView2.DataSource = BLL_QuanLy.Instance.Bll_GetDoanhSoBanHangFolowNamThang(Convert.ToInt32(cbbNam.SelectedItem.ToString()), Convert.ToInt32(cbbThang.SelectedItem.ToString()));
            setBackground();
        }

        private void cbbNgay_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView2.DataSource = BLL_QuanLy.Instance.Bll_GetDoanhSoBanHangFolowNamThangNgay(Convert.ToInt32(cbbNam.SelectedItem.ToString()), Convert.ToInt32(cbbThang.SelectedItem.ToString()), Convert.ToInt32(cbbNgay.SelectedItem.ToString()));
            setBackground();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            setBackground();
        }
    }
}
