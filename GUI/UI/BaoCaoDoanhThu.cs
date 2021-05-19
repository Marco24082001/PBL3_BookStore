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
    }
}
