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
    }
}
