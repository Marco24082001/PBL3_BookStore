
namespace GUI
{
    partial class Thongke
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbBestSeller = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbSort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TongDoanhSo = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbbNgay = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbThang = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbbNam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sortBtn = new FontAwesome.Sharp.IconButton();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.num3 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.num2 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.num1 = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.loadBtn = new Guna.UI2.WinForms.Guna2Button();
            this.radioYear = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.radioMonth = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.salesChart = new LiveCharts.WinForms.CartesianChart();
            this.label3 = new System.Windows.Forms.Label();
            this.NextPage = new FontAwesome.Sharp.IconButton();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.dOANHSOBANHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANHSOBANHANGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 26;
            this.label1.Text = "Best seller :";
            // 
            // lbBestSeller
            // 
            this.lbBestSeller.AutoSize = true;
            this.lbBestSeller.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBestSeller.Location = new System.Drawing.Point(216, 52);
            this.lbBestSeller.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbBestSeller.Name = "lbBestSeller";
            this.lbBestSeller.Size = new System.Drawing.Size(0, 28);
            this.lbBestSeller.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(531, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 29);
            this.label4.TabIndex = 29;
            this.label4.Text = "Tổng đơn hàng :";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Century", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(738, 54);
            this.lb1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(0, 28);
            this.lb1.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbSort);
            this.groupBox1.Controls.Add(this.TongDoanhSo);
            this.groupBox1.Controls.Add(this.cbbNgay);
            this.groupBox1.Controls.Add(this.cbbThang);
            this.groupBox1.Controls.Add(this.cbbNam);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.iconPictureBox2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.sortBtn);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(49, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(635, 530);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh thu";
            // 
            // cbbSort
            // 
            this.cbbSort.BackColor = System.Drawing.Color.Transparent;
            this.cbbSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSort.FocusedState.Parent = this.cbbSort;
            this.cbbSort.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSort.ForeColor = System.Drawing.Color.Black;
            this.cbbSort.HoverState.Parent = this.cbbSort;
            this.cbbSort.ItemHeight = 30;
            this.cbbSort.ItemsAppearance.Parent = this.cbbSort;
            this.cbbSort.Location = new System.Drawing.Point(139, 476);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.ShadowDecoration.Parent = this.cbbSort;
            this.cbbSort.Size = new System.Drawing.Size(122, 36);
            this.cbbSort.TabIndex = 71;
            // 
            // TongDoanhSo
            // 
            this.TongDoanhSo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TongDoanhSo.DefaultText = "";
            this.TongDoanhSo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TongDoanhSo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TongDoanhSo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TongDoanhSo.DisabledState.Parent = this.TongDoanhSo;
            this.TongDoanhSo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TongDoanhSo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TongDoanhSo.FocusedState.Parent = this.TongDoanhSo;
            this.TongDoanhSo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongDoanhSo.ForeColor = System.Drawing.Color.Black;
            this.TongDoanhSo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TongDoanhSo.HoverState.Parent = this.TongDoanhSo;
            this.TongDoanhSo.Location = new System.Drawing.Point(458, 476);
            this.TongDoanhSo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TongDoanhSo.Name = "TongDoanhSo";
            this.TongDoanhSo.PasswordChar = '\0';
            this.TongDoanhSo.PlaceholderText = "";
            this.TongDoanhSo.SelectedText = "";
            this.TongDoanhSo.ShadowDecoration.Parent = this.TongDoanhSo;
            this.TongDoanhSo.Size = new System.Drawing.Size(147, 36);
            this.TongDoanhSo.TabIndex = 74;
            // 
            // cbbNgay
            // 
            this.cbbNgay.BackColor = System.Drawing.Color.Transparent;
            this.cbbNgay.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNgay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNgay.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNgay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNgay.FocusedState.Parent = this.cbbNgay;
            this.cbbNgay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNgay.ForeColor = System.Drawing.Color.Black;
            this.cbbNgay.HoverState.Parent = this.cbbNgay;
            this.cbbNgay.ItemHeight = 30;
            this.cbbNgay.ItemsAppearance.Parent = this.cbbNgay;
            this.cbbNgay.Location = new System.Drawing.Point(387, 55);
            this.cbbNgay.Name = "cbbNgay";
            this.cbbNgay.ShadowDecoration.Parent = this.cbbNgay;
            this.cbbNgay.Size = new System.Drawing.Size(145, 36);
            this.cbbNgay.TabIndex = 72;
            this.cbbNgay.SelectedIndexChanged += new System.EventHandler(this.cbbNgay_SelectedIndexChanged_1);
            // 
            // cbbThang
            // 
            this.cbbThang.BackColor = System.Drawing.Color.Transparent;
            this.cbbThang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbThang.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbThang.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbThang.FocusedState.Parent = this.cbbThang;
            this.cbbThang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbThang.ForeColor = System.Drawing.Color.Black;
            this.cbbThang.HoverState.Parent = this.cbbThang;
            this.cbbThang.ItemHeight = 30;
            this.cbbThang.ItemsAppearance.Parent = this.cbbThang;
            this.cbbThang.Location = new System.Drawing.Point(228, 55);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.ShadowDecoration.Parent = this.cbbThang;
            this.cbbThang.Size = new System.Drawing.Size(145, 36);
            this.cbbThang.TabIndex = 71;
            this.cbbThang.SelectedIndexChanged += new System.EventHandler(this.cbbThang_SelectedIndexChanged_1);
            // 
            // cbbNam
            // 
            this.cbbNam.BackColor = System.Drawing.Color.Transparent;
            this.cbbNam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbNam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbNam.FocusedState.Parent = this.cbbNam;
            this.cbbNam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbNam.ForeColor = System.Drawing.Color.Black;
            this.cbbNam.HoverState.Parent = this.cbbNam;
            this.cbbNam.ItemHeight = 30;
            this.cbbNam.ItemsAppearance.Parent = this.cbbNam;
            this.cbbNam.Location = new System.Drawing.Point(68, 55);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.ShadowDecoration.Parent = this.cbbNam;
            this.cbbNam.Size = new System.Drawing.Size(145, 36);
            this.cbbNam.TabIndex = 70;
            this.cbbNam.SelectedIndexChanged += new System.EventHandler(this.cbbNam_SelectedIndexChanged_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeight = 47;
            this.dataGridView1.Location = new System.Drawing.Point(31, 116);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(574, 338);
            this.dataGridView1.TabIndex = 36;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.iconPictureBox2.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Sort;
            this.iconPictureBox2.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 29;
            this.iconPictureBox2.Location = new System.Drawing.Point(31, 58);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 29);
            this.iconPictureBox2.TabIndex = 35;
            this.iconPictureBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(266, 479);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 29);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tổng doanh số :";
            // 
            // sortBtn
            // 
            this.sortBtn.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.sortBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortBtn.IconChar = FontAwesome.Sharp.IconChar.Sort;
            this.sortBtn.IconColor = System.Drawing.Color.Blue;
            this.sortBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.sortBtn.IconSize = 20;
            this.sortBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sortBtn.Location = new System.Drawing.Point(31, 477);
            this.sortBtn.Margin = new System.Windows.Forms.Padding(2);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(100, 34);
            this.sortBtn.TabIndex = 31;
            this.sortBtn.Text = "Sắp sếp";
            this.sortBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sortBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sortBtn.UseVisualStyleBackColor = false;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(220, 29);
            this.label10.TabIndex = 25;
            this.label10.Text = "Doanh số bán hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblMonth);
            this.groupBox2.Controls.Add(this.num3);
            this.groupBox2.Controls.Add(this.num2);
            this.groupBox2.Controls.Add(this.num1);
            this.groupBox2.Controls.Add(this.iconPictureBox1);
            this.groupBox2.Controls.Add(this.loadBtn);
            this.groupBox2.Controls.Add(this.radioYear);
            this.groupBox2.Controls.Add(this.radioMonth);
            this.groupBox2.Controls.Add(this.salesChart);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(688, 131);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(715, 528);
            this.groupBox2.TabIndex = 53;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doanh thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(596, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 18);
            this.label2.TabIndex = 76;
            this.label2.Text = "Năm";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(496, 492);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(49, 18);
            this.lblMonth.TabIndex = 75;
            this.lblMonth.Text = "Tháng";
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.Transparent;
            this.num3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num3.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.num3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.num3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.num3.DisabledState.Parent = this.num3;
            this.num3.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.num3.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.num3.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.num3.FocusedState.Parent = this.num3;
            this.num3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.num3.ForeColor = System.Drawing.Color.Black;
            this.num3.Location = new System.Drawing.Point(263, 52);
            this.num3.Name = "num3";
            this.num3.ShadowDecoration.Parent = this.num3;
            this.num3.Size = new System.Drawing.Size(83, 36);
            this.num3.TabIndex = 74;
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.Transparent;
            this.num2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.num2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.num2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.num2.DisabledState.Parent = this.num2;
            this.num2.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.num2.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.num2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.num2.FocusedState.Parent = this.num2;
            this.num2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.num2.ForeColor = System.Drawing.Color.Black;
            this.num2.Location = new System.Drawing.Point(165, 52);
            this.num2.Name = "num2";
            this.num2.ShadowDecoration.Parent = this.num2;
            this.num2.Size = new System.Drawing.Size(83, 36);
            this.num2.TabIndex = 73;
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.Transparent;
            this.num1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.num1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.num1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.num1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.num1.DisabledState.Parent = this.num1;
            this.num1.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.num1.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.num1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.num1.FocusedState.Parent = this.num1;
            this.num1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.num1.ForeColor = System.Drawing.Color.Black;
            this.num1.Location = new System.Drawing.Point(66, 52);
            this.num1.Name = "num1";
            this.num1.ShadowDecoration.Parent = this.num1;
            this.num1.Size = new System.Drawing.Size(83, 36);
            this.num1.TabIndex = 72;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Sort;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 29;
            this.iconPictureBox1.Location = new System.Drawing.Point(29, 55);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 29);
            this.iconPictureBox1.TabIndex = 53;
            this.iconPictureBox1.TabStop = false;
            // 
            // loadBtn
            // 
            this.loadBtn.BorderRadius = 15;
            this.loadBtn.CheckedState.Parent = this.loadBtn;
            this.loadBtn.CustomImages.Parent = this.loadBtn;
            this.loadBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadBtn.ForeColor = System.Drawing.Color.White;
            this.loadBtn.HoverState.Parent = this.loadBtn;
            this.loadBtn.Location = new System.Drawing.Point(508, 61);
            this.loadBtn.Name = "loadBtn";
            this.loadBtn.ShadowDecoration.Parent = this.loadBtn;
            this.loadBtn.Size = new System.Drawing.Size(125, 31);
            this.loadBtn.TabIndex = 52;
            this.loadBtn.Text = "Load";
            this.loadBtn.Click += new System.EventHandler(this.loadBtn_Click);
            // 
            // radioYear
            // 
            this.radioYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.radioYear.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioYear.CheckedState.BorderThickness = 0;
            this.radioYear.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioYear.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioYear.CheckedState.Parent = this.radioYear;
            this.radioYear.ImeMode = System.Windows.Forms.ImeMode.On;
            this.radioYear.Location = new System.Drawing.Point(564, 488);
            this.radioYear.Margin = new System.Windows.Forms.Padding(4);
            this.radioYear.Name = "radioYear";
            this.radioYear.ShadowDecoration.Parent = this.radioYear;
            this.radioYear.Size = new System.Drawing.Size(25, 25);
            this.radioYear.TabIndex = 30;
            this.radioYear.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioYear.UncheckedState.BorderThickness = 2;
            this.radioYear.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioYear.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioYear.UncheckedState.Parent = this.radioYear;
            this.radioYear.CheckedChanged += new System.EventHandler(this.radioYear_CheckedChanged);
            // 
            // radioMonth
            // 
            this.radioMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.radioMonth.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioMonth.CheckedState.BorderThickness = 0;
            this.radioMonth.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.radioMonth.CheckedState.InnerColor = System.Drawing.Color.White;
            this.radioMonth.CheckedState.Parent = this.radioMonth;
            this.radioMonth.ImeMode = System.Windows.Forms.ImeMode.On;
            this.radioMonth.Location = new System.Drawing.Point(464, 488);
            this.radioMonth.Margin = new System.Windows.Forms.Padding(4);
            this.radioMonth.Name = "radioMonth";
            this.radioMonth.ShadowDecoration.Parent = this.radioMonth;
            this.radioMonth.Size = new System.Drawing.Size(25, 25);
            this.radioMonth.TabIndex = 29;
            this.radioMonth.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.radioMonth.UncheckedState.BorderThickness = 2;
            this.radioMonth.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.radioMonth.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.radioMonth.UncheckedState.Parent = this.radioMonth;
            // 
            // salesChart
            // 
            this.salesChart.Location = new System.Drawing.Point(39, 126);
            this.salesChart.Margin = new System.Windows.Forms.Padding(2);
            this.salesChart.Name = "salesChart";
            this.salesChart.Size = new System.Drawing.Size(599, 348);
            this.salesChart.TabIndex = 28;
            this.salesChart.Text = "cartesianChart1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Biểu đồ doanh số";
            // 
            // NextPage
            // 
            this.NextPage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.NextPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NextPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPage.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleRight;
            this.NextPage.IconColor = System.Drawing.Color.Blue;
            this.NextPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NextPage.IconSize = 30;
            this.NextPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NextPage.Location = new System.Drawing.Point(658, 670);
            this.NextPage.Margin = new System.Windows.Forms.Padding(2);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(148, 48);
            this.NextPage.TabIndex = 54;
            this.NextPage.Text = "Next Page";
            this.NextPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NextPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.NextPage.UseVisualStyleBackColor = false;
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // dOANHSOBANHANGBindingSource
            // 
            this.dOANHSOBANHANGBindingSource.DataSource = typeof(GUI.DOANH_SO_BAN_HANG);
            // 
            // Thongke
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1444, 752);
            this.Controls.Add(this.NextPage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbBestSeller);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Thongke";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý doanh thu";
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dOANHSOBANHANGBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBestSeller;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton sortBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton NextPage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LiveCharts.WinForms.CartesianChart salesChart;
        private Guna.UI2.WinForms.Guna2Button loadBtn;
        private System.Windows.Forms.BindingSource dOANHSOBANHANGBindingSource;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private Guna.UI2.WinForms.Guna2ComboBox cbbNgay;
        private Guna.UI2.WinForms.Guna2ComboBox cbbThang;
        private Guna.UI2.WinForms.Guna2ComboBox cbbNam;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSort;
        private Guna.UI2.WinForms.Guna2TextBox TongDoanhSo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Guna.UI2.WinForms.Guna2NumericUpDown num3;
        private Guna.UI2.WinForms.Guna2NumericUpDown num2;
        private Guna.UI2.WinForms.Guna2NumericUpDown num1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton radioYear;
        private Guna.UI2.WinForms.Guna2CustomRadioButton radioMonth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMonth;
    }
}