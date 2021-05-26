
namespace GUI
{
    partial class QuanLySach
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTheLoai = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbSort = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.AddHoaDon = new FontAwesome.Sharp.IconButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMaSach = new System.Windows.Forms.ComboBox();
            this.ThemChiTiet = new FontAwesome.Sharp.IconButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtMaDN = new System.Windows.Forms.TextBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.XoaChiTiet = new FontAwesome.Sharp.IconButton();
            this.ChinhSua = new FontAwesome.Sharp.IconButton();
            this.txtTong = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ThemSach = new FontAwesome.Sharp.IconButton();
            this.XacNhan = new FontAwesome.Sharp.IconButton();
            this.XoaSach = new FontAwesome.Sharp.IconButton();
            this.sortBtn = new FontAwesome.Sharp.IconButton();
            this.Edit = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbTheLoai);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.iconPictureBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(643, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(789, 442);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 49;
            this.label1.Text = "Thể loại :";
            // 
            // cbbTheLoai
            // 
            this.cbbTheLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTheLoai.FormattingEnabled = true;
            this.cbbTheLoai.Location = new System.Drawing.Point(105, 45);
            this.cbbTheLoai.Name = "cbbTheLoai";
            this.cbbTheLoai.Size = new System.Drawing.Size(134, 28);
            this.cbbTheLoai.TabIndex = 48;
            this.cbbTheLoai.SelectedIndexChanged += new System.EventHandler(this.cbbTheLoai_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(744, 351);
            this.dataGridView1.TabIndex = 41;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.iconPictureBox1.Enabled = false;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Blue;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Blue;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 26;
            this.iconPictureBox1.Location = new System.Drawing.Point(274, 45);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(27, 26);
            this.iconPictureBox1.TabIndex = 40;
            this.iconPictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Tên sách :";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(391, 47);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(108, 27);
            this.txtTenSach.TabIndex = 38;
            this.txtTenSach.TextChanged += new System.EventHandler(this.txtTenSach_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 29);
            this.label10.TabIndex = 37;
            this.label10.Text = "List book";
            // 
            // cbbSort
            // 
            this.cbbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.Location = new System.Drawing.Point(1298, 528);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(134, 28);
            this.cbbSort.TabIndex = 45;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.AddHoaDon);
            this.groupBox3.Controls.Add(this.dateTimePicker1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cbbMaSach);
            this.groupBox3.Controls.Add(this.ThemChiTiet);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.txtMaDN);
            this.groupBox3.Controls.Add(this.numericUpDown4);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label27);
            this.groupBox3.Controls.Add(this.XoaChiTiet);
            this.groupBox3.Controls.Add(this.ChinhSua);
            this.groupBox3.Controls.Add(this.txtTong);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(24, 61);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(614, 601);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            // 
            // AddHoaDon
            // 
            this.AddHoaDon.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.AddHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddHoaDon.IconChar = FontAwesome.Sharp.IconChar.FileMedical;
            this.AddHoaDon.IconColor = System.Drawing.Color.Blue;
            this.AddHoaDon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.AddHoaDon.IconSize = 30;
            this.AddHoaDon.Location = new System.Drawing.Point(326, 48);
            this.AddHoaDon.Name = "AddHoaDon";
            this.AddHoaDon.Size = new System.Drawing.Size(117, 36);
            this.AddHoaDon.TabIndex = 68;
            this.AddHoaDon.Text = "Hóa đơn";
            this.AddHoaDon.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddHoaDon.UseVisualStyleBackColor = false;
            this.AddHoaDon.Click += new System.EventHandler(this.AddHoaDon_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(426, 118);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 27);
            this.dateTimePicker1.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(322, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "Ngày nhập :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(426, 185);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 27);
            this.textBox1.TabIndex = 65;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(322, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 64;
            this.label3.Text = "Ghi chú :";
            // 
            // cbbMaSach
            // 
            this.cbbMaSach.FormattingEnabled = true;
            this.cbbMaSach.Location = new System.Drawing.Point(147, 117);
            this.cbbMaSach.Name = "cbbMaSach";
            this.cbbMaSach.Size = new System.Drawing.Size(150, 28);
            this.cbbMaSach.TabIndex = 63;
            // 
            // ThemChiTiet
            // 
            this.ThemChiTiet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ThemChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThemChiTiet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemChiTiet.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ThemChiTiet.IconColor = System.Drawing.Color.Blue;
            this.ThemChiTiet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ThemChiTiet.IconSize = 20;
            this.ThemChiTiet.Location = new System.Drawing.Point(30, 239);
            this.ThemChiTiet.Name = "ThemChiTiet";
            this.ThemChiTiet.Size = new System.Drawing.Size(149, 34);
            this.ThemChiTiet.TabIndex = 62;
            this.ThemChiTiet.Text = "Thêm chi tiết";
            this.ThemChiTiet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemChiTiet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ThemChiTiet.UseVisualStyleBackColor = false;
            this.ThemChiTiet.Click += new System.EventHandler(this.ThemChiTiet_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(30, 328);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(551, 212);
            this.dataGridView2.TabIndex = 41;
            // 
            // txtMaDN
            // 
            this.txtMaDN.Location = new System.Drawing.Point(147, 50);
            this.txtMaDN.Name = "txtMaDN";
            this.txtMaDN.Size = new System.Drawing.Size(150, 27);
            this.txtMaDN.TabIndex = 54;
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown4.Location = new System.Drawing.Point(147, 186);
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(150, 27);
            this.numericUpDown4.TabIndex = 53;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(25, 188);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 20);
            this.label25.TabIndex = 49;
            this.label25.Text = "Số lượng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Mã đơn nhập :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(23, 120);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(78, 20);
            this.label27.TabIndex = 51;
            this.label27.Text = "Mã sách:";
            // 
            // XoaChiTiet
            // 
            this.XoaChiTiet.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.XoaChiTiet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XoaChiTiet.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.XoaChiTiet.IconColor = System.Drawing.Color.Red;
            this.XoaChiTiet.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.XoaChiTiet.IconSize = 25;
            this.XoaChiTiet.Location = new System.Drawing.Point(158, 546);
            this.XoaChiTiet.Name = "XoaChiTiet";
            this.XoaChiTiet.Size = new System.Drawing.Size(106, 34);
            this.XoaChiTiet.TabIndex = 22;
            this.XoaChiTiet.Text = "Xóa";
            this.XoaChiTiet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.XoaChiTiet.UseVisualStyleBackColor = false;
            this.XoaChiTiet.Click += new System.EventHandler(this.XoaChiTiet_Click);
            // 
            // ChinhSua
            // 
            this.ChinhSua.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChinhSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ChinhSua.IconColor = System.Drawing.Color.Blue;
            this.ChinhSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ChinhSua.IconSize = 25;
            this.ChinhSua.Location = new System.Drawing.Point(27, 546);
            this.ChinhSua.Name = "ChinhSua";
            this.ChinhSua.Size = new System.Drawing.Size(124, 34);
            this.ChinhSua.TabIndex = 21;
            this.ChinhSua.Text = "Chỉnh sửa";
            this.ChinhSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChinhSua.UseVisualStyleBackColor = false;
            this.ChinhSua.Click += new System.EventHandler(this.ChinhSua_Click);
            // 
            // txtTong
            // 
            this.txtTong.Enabled = false;
            this.txtTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTong.Location = new System.Drawing.Point(395, 550);
            this.txtTong.Name = "txtTong";
            this.txtTong.Size = new System.Drawing.Size(186, 27);
            this.txtTong.TabIndex = 16;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(286, 553);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "Tổng cộng";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 29);
            this.label13.TabIndex = 7;
            this.label13.Text = "Chi tiết hóa đơn";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(163, 29);
            this.label14.TabIndex = 10;
            this.label14.Text = "Hóa đơn nhập";
            // 
            // ThemSach
            // 
            this.ThemSach.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ThemSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ThemSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThemSach.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.ThemSach.IconColor = System.Drawing.Color.Blue;
            this.ThemSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ThemSach.IconSize = 20;
            this.ThemSach.Location = new System.Drawing.Point(667, 522);
            this.ThemSach.Name = "ThemSach";
            this.ThemSach.Size = new System.Drawing.Size(164, 34);
            this.ThemSach.TabIndex = 39;
            this.ThemSach.Text = "Thêm sách mới";
            this.ThemSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ThemSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ThemSach.UseVisualStyleBackColor = false;
            this.ThemSach.Click += new System.EventHandler(this.ThemSach_Click);
            // 
            // XacNhan
            // 
            this.XacNhan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.XacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XacNhan.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.XacNhan.IconColor = System.Drawing.Color.Blue;
            this.XacNhan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.XacNhan.IconSize = 25;
            this.XacNhan.Location = new System.Drawing.Point(519, 677);
            this.XacNhan.Name = "XacNhan";
            this.XacNhan.Size = new System.Drawing.Size(119, 34);
            this.XacNhan.TabIndex = 49;
            this.XacNhan.Text = " Xác nhận";
            this.XacNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.XacNhan.UseVisualStyleBackColor = false;
            this.XacNhan.Click += new System.EventHandler(this.XacNhan_Click);
            // 
            // XoaSach
            // 
            this.XoaSach.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.XoaSach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XoaSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XoaSach.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.XoaSach.IconColor = System.Drawing.Color.Red;
            this.XoaSach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.XoaSach.IconSize = 20;
            this.XoaSach.Location = new System.Drawing.Point(991, 522);
            this.XoaSach.Name = "XoaSach";
            this.XoaSach.Size = new System.Drawing.Size(78, 34);
            this.XoaSach.TabIndex = 36;
            this.XoaSach.Text = "Xóa";
            this.XoaSach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XoaSach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.XoaSach.UseVisualStyleBackColor = false;
            this.XoaSach.Click += new System.EventHandler(this.XoaSach_Click);
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
            this.sortBtn.Location = new System.Drawing.Point(1178, 524);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(100, 34);
            this.sortBtn.TabIndex = 37;
            this.sortBtn.Text = "Sắp sếp";
            this.sortBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sortBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sortBtn.UseVisualStyleBackColor = false;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.Edit.IconColor = System.Drawing.Color.Blue;
            this.Edit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Edit.IconSize = 20;
            this.Edit.Location = new System.Drawing.Point(853, 522);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(121, 34);
            this.Edit.TabIndex = 38;
            this.Edit.Text = "Chỉnh sửa";
            this.Edit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1444, 753);
            this.Controls.Add(this.XacNhan);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.cbbSort);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.XoaSach);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.ThemSach);
            this.Name = "QuanLySach";
            this.Text = "Quản lý kho sách";
            this.Load += new System.EventHandler(this.QuanLySach_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton XoaSach;
        private FontAwesome.Sharp.IconButton sortBtn;
        private FontAwesome.Sharp.IconButton Edit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.ComboBox cbbSort;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTheLoai;
        private FontAwesome.Sharp.IconButton XacNhan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbbMaSach;
        private FontAwesome.Sharp.IconButton ThemChiTiet;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label25;
        private FontAwesome.Sharp.IconButton ThemSach;
        private System.Windows.Forms.Label label27;
        private FontAwesome.Sharp.IconButton XoaChiTiet;
        private System.Windows.Forms.TextBox txtTong;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaDN;
        private System.Windows.Forms.DataGridView dataGridView2;
        private FontAwesome.Sharp.IconButton ChinhSua;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton AddHoaDon;
    }
}