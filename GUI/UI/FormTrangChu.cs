using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using PBL3.BLL;
using LiveCharts;

namespace PBL3.UI
{
    public partial class FormTrangChu : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        Thread Luong;
        public string maNV;
        FormCaiDatThongTin user;
        //Constructor

        public FormTrangChu()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 65);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        public void exit()
        {
            this.Close();
        }
        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(250, 212, 53);
            public static Color color2 = Color.FromArgb(124, 65, 245);
            public static Color color3 = Color.FromArgb(135, 206, 250);
            public static Color color4 = Color.FromArgb(24, 161, 251);
        }
        //Method
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //end
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void btnQLDT_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            FormBaoCaoDoanhSo f = new FormBaoCaoDoanhSo();
            FormBaoCaoDoanhSo.Sender = new FormBaoCaoDoanhSo.MyDel(OpenChildForm);
            OpenChildForm(f);
        }

        private void btnQLKS_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            OpenChildForm(new FormQuanLySach());
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            FormQuanLyNhanVien s = new FormQuanLyNhanVien();
            s.Exit_QuanLy += new FormQuanLyNhanVien.Mydel(exit);
            OpenChildForm(s);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.HotPink;
            lblTitleChildForm.Text = "Home";
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void infoNhanVien_Click(object sender, EventArgs e)
        {
            if (user == null)
            {
                user = new FormCaiDatThongTin(maNV);
            }
            user.Show();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            txtTen.Text = BLL_NhanVien.Instance.Bll_GetNameNVByMaNV(maNV);
            set_TopProduct();
            set_RemainProduct();
            set_AllNum();
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            Luong = new Thread(openFormDangNhap);
            Luong.SetApartmentState(ApartmentState.STA);
            Luong.Start();
        }

        private void openFormDangNhap(object newForm)
        {
            FormDangNhap f = new FormDangNhap();
            Application.Run(f);
        }

        private void Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void set_TopProduct()
        {
            chartTopProducts.InnerRadius = 50;
            chartTopProducts.Series = BLL_BaoCaoDoanhThu.Instance.Bll_GetValueChart_Products();
            chartTopProducts.DefaultLegend.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.White);
            chartTopProducts.LegendLocation = LegendLocation.Right;    
        }

        private void set_RemainProduct()
        {
            chartRemainProduct.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Sách",
                Labels = BLL_Sach.Instance.Bll_GetLabel_Remain_Products()
            });

            chartRemainProduct.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Số lượng",
                LabelFormatter = value => value.ToString("N")
            });
            chartRemainProduct.Series = BLL_Sach.Instance.Bll_GetValueChart_Remain_Products();
            chartRemainProduct.DefaultLegend.Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.White);
        }

        private void set_AllNum()
        {
            numDonHang.Text = Convert.ToString(BLL_HoaDonBan.Instance.Bll_getTotal_Sales());
            numDoanhThu.Text = Convert.ToString(BLL_BaoCaoDoanhThu.Instance.Bll_getTotal_TurnOver());
            numNhanVien.Text = Convert.ToString(BLL_NhanVien.Instance.Bll_getTotal_Employees());
            numSach.Text = Convert.ToString(BLL_Sach.Instance.Bll_getTotal_Books());
            numTheLoai.Text = Convert.ToString(BLL_LoaiSach.Instance.Bll_getTotal_Categorys());
            numKhachHang.Text = Convert.ToString(BLL_TKNhanVien.Instance.Bll_getTotal_Customers());
        }
    }
}
