
namespace PBL3.UI
{
    partial class FormThemNhanViens
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
            this.LamMoi = new FontAwesome.Sharp.IconButton();
            this.XacNhan = new FontAwesome.Sharp.IconButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Nu = new System.Windows.Forms.RadioButton();
            this.Nam = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMatKhau = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQueQuan = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCMND = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDanToc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHoTen = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaNV = new Guna.UI2.WinForms.Guna2TextBox();
            this.dateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Thoat = new FontAwesome.Sharp.IconButton();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LamMoi
            // 
            this.LamMoi.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.LamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LamMoi.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.LamMoi.IconColor = System.Drawing.Color.Blue;
            this.LamMoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.LamMoi.IconSize = 25;
            this.LamMoi.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LamMoi.Location = new System.Drawing.Point(240, 424);
            this.LamMoi.Name = "LamMoi";
            this.LamMoi.Size = new System.Drawing.Size(122, 34);
            this.LamMoi.TabIndex = 28;
            this.LamMoi.Text = "Làm mới";
            this.LamMoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.LamMoi.UseVisualStyleBackColor = false;
            this.LamMoi.Click += new System.EventHandler(this.LamMoi_Click);
            // 
            // XacNhan
            // 
            this.XacNhan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.XacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.XacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XacNhan.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.XacNhan.IconColor = System.Drawing.Color.Blue;
            this.XacNhan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.XacNhan.IconSize = 25;
            this.XacNhan.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.XacNhan.Location = new System.Drawing.Point(465, 424);
            this.XacNhan.Name = "XacNhan";
            this.XacNhan.Size = new System.Drawing.Size(127, 34);
            this.XacNhan.TabIndex = 25;
            this.XacNhan.Text = "Xác nhận";
            this.XacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XacNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.XacNhan.UseVisualStyleBackColor = false;
            this.XacNhan.Click += new System.EventHandler(this.XacNhan_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(28, 357);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 20);
            this.label13.TabIndex = 5;
            this.label13.Text = "Mật khẩu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ngày sinh :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Quê quán :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(116, 20);
            this.label11.TabIndex = 4;
            this.label11.Text = "Số điện thoại :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Nu);
            this.groupBox2.Controls.Add(this.Nam);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(428, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(164, 88);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giới tính";
            // 
            // Nu
            // 
            this.Nu.AutoSize = true;
            this.Nu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nu.Location = new System.Drawing.Point(98, 38);
            this.Nu.Name = "Nu";
            this.Nu.Size = new System.Drawing.Size(51, 24);
            this.Nu.TabIndex = 65;
            this.Nu.TabStop = true;
            this.Nu.Text = "Nữ";
            this.Nu.UseVisualStyleBackColor = true;
            // 
            // Nam
            // 
            this.Nam.AutoSize = true;
            this.Nam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nam.Location = new System.Drawing.Point(16, 38);
            this.Nam.Name = "Nam";
            this.Nam.Size = new System.Drawing.Size(65, 24);
            this.Nam.TabIndex = 64;
            this.Nam.TabStop = true;
            this.Nam.Text = "Nam";
            this.Nam.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dân tộc :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Chứng minh thư :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Họ và tên :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã nhân viên :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.txtQueQuan);
            this.groupBox1.Controls.Add(this.txtSdt);
            this.groupBox1.Controls.Add(this.txtCMND);
            this.groupBox1.Controls.Add(this.txtDanToc);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.Thoat);
            this.groupBox1.Controls.Add(this.LamMoi);
            this.groupBox1.Controls.Add(this.XacNhan);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(614, 496);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatKhau.DefaultText = "";
            this.txtMatKhau.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatKhau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatKhau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.DisabledState.Parent = this.txtMatKhau;
            this.txtMatKhau.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatKhau.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.FocusedState.Parent = this.txtMatKhau;
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.ForeColor = System.Drawing.Color.Black;
            this.txtMatKhau.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatKhau.HoverState.Parent = this.txtMatKhau;
            this.txtMatKhau.Location = new System.Drawing.Point(205, 344);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '\0';
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.SelectedText = "";
            this.txtMatKhau.ShadowDecoration.Parent = this.txtMatKhau;
            this.txtMatKhau.Size = new System.Drawing.Size(157, 33);
            this.txtMatKhau.TabIndex = 63;
            // 
            // txtQueQuan
            // 
            this.txtQueQuan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQueQuan.DefaultText = "";
            this.txtQueQuan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQueQuan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQueQuan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQueQuan.DisabledState.Parent = this.txtQueQuan;
            this.txtQueQuan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQueQuan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQueQuan.FocusedState.Parent = this.txtQueQuan;
            this.txtQueQuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQueQuan.ForeColor = System.Drawing.Color.Black;
            this.txtQueQuan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQueQuan.HoverState.Parent = this.txtQueQuan;
            this.txtQueQuan.Location = new System.Drawing.Point(204, 255);
            this.txtQueQuan.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtQueQuan.Name = "txtQueQuan";
            this.txtQueQuan.PasswordChar = '\0';
            this.txtQueQuan.PlaceholderText = "";
            this.txtQueQuan.SelectedText = "";
            this.txtQueQuan.ShadowDecoration.Parent = this.txtQueQuan;
            this.txtQueQuan.Size = new System.Drawing.Size(157, 33);
            this.txtQueQuan.TabIndex = 61;
            // 
            // txtSdt
            // 
            this.txtSdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSdt.DefaultText = "";
            this.txtSdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSdt.DisabledState.Parent = this.txtSdt;
            this.txtSdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSdt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSdt.FocusedState.Parent = this.txtSdt;
            this.txtSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.ForeColor = System.Drawing.Color.Black;
            this.txtSdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSdt.HoverState.Parent = this.txtSdt;
            this.txtSdt.Location = new System.Drawing.Point(204, 215);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.PasswordChar = '\0';
            this.txtSdt.PlaceholderText = "";
            this.txtSdt.SelectedText = "";
            this.txtSdt.ShadowDecoration.Parent = this.txtSdt;
            this.txtSdt.Size = new System.Drawing.Size(157, 33);
            this.txtSdt.TabIndex = 60;
            // 
            // txtCMND
            // 
            this.txtCMND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCMND.DefaultText = "";
            this.txtCMND.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCMND.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCMND.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCMND.DisabledState.Parent = this.txtCMND;
            this.txtCMND.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCMND.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCMND.FocusedState.Parent = this.txtCMND;
            this.txtCMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.ForeColor = System.Drawing.Color.Black;
            this.txtCMND.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCMND.HoverState.Parent = this.txtCMND;
            this.txtCMND.Location = new System.Drawing.Point(204, 174);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.PasswordChar = '\0';
            this.txtCMND.PlaceholderText = "";
            this.txtCMND.SelectedText = "";
            this.txtCMND.ShadowDecoration.Parent = this.txtCMND;
            this.txtCMND.Size = new System.Drawing.Size(157, 33);
            this.txtCMND.TabIndex = 59;
            // 
            // txtDanToc
            // 
            this.txtDanToc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDanToc.DefaultText = "";
            this.txtDanToc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDanToc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDanToc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDanToc.DisabledState.Parent = this.txtDanToc;
            this.txtDanToc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDanToc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDanToc.FocusedState.Parent = this.txtDanToc;
            this.txtDanToc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDanToc.ForeColor = System.Drawing.Color.Black;
            this.txtDanToc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDanToc.HoverState.Parent = this.txtDanToc;
            this.txtDanToc.Location = new System.Drawing.Point(204, 133);
            this.txtDanToc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDanToc.Name = "txtDanToc";
            this.txtDanToc.PasswordChar = '\0';
            this.txtDanToc.PlaceholderText = "";
            this.txtDanToc.SelectedText = "";
            this.txtDanToc.ShadowDecoration.Parent = this.txtDanToc;
            this.txtDanToc.Size = new System.Drawing.Size(157, 33);
            this.txtDanToc.TabIndex = 58;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHoTen.DefaultText = "";
            this.txtHoTen.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHoTen.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHoTen.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.DisabledState.Parent = this.txtHoTen;
            this.txtHoTen.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHoTen.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.FocusedState.Parent = this.txtHoTen;
            this.txtHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoTen.ForeColor = System.Drawing.Color.Black;
            this.txtHoTen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHoTen.HoverState.Parent = this.txtHoTen;
            this.txtHoTen.Location = new System.Drawing.Point(204, 92);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.PasswordChar = '\0';
            this.txtHoTen.PlaceholderText = "";
            this.txtHoTen.SelectedText = "";
            this.txtHoTen.ShadowDecoration.Parent = this.txtHoTen;
            this.txtHoTen.Size = new System.Drawing.Size(157, 33);
            this.txtHoTen.TabIndex = 57;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNV.DefaultText = "";
            this.txtMaNV.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNV.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNV.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.DisabledState.Parent = this.txtMaNV;
            this.txtMaNV.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNV.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.FocusedState.Parent = this.txtMaNV;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.ForeColor = System.Drawing.Color.Black;
            this.txtMaNV.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNV.HoverState.Parent = this.txtMaNV;
            this.txtMaNV.Location = new System.Drawing.Point(204, 50);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.PasswordChar = '\0';
            this.txtMaNV.PlaceholderText = "";
            this.txtMaNV.SelectedText = "";
            this.txtMaNV.ShadowDecoration.Parent = this.txtMaNV;
            this.txtMaNV.Size = new System.Drawing.Size(106, 33);
            this.txtMaNV.TabIndex = 56;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.BorderColor = System.Drawing.Color.Gray;
            this.dateTimePicker1.BorderThickness = 1;
            this.dateTimePicker1.CheckedState.Parent = this.dateTimePicker1;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.FillColor = System.Drawing.SystemColors.Window;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePicker1.HoverState.Parent = this.dateTimePicker1;
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 298);
            this.dateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShadowDecoration.Parent = this.dateTimePicker1;
            this.dateTimePicker1.Size = new System.Drawing.Size(303, 36);
            this.dateTimePicker1.TabIndex = 62;
            this.dateTimePicker1.Value = new System.DateTime(2021, 6, 3, 18, 1, 17, 368);
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.Thoat.IconColor = System.Drawing.Color.Red;
            this.Thoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Thoat.IconSize = 25;
            this.Thoat.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Thoat.Location = new System.Drawing.Point(32, 424);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(110, 34);
            this.Thoat.TabIndex = 30;
            this.Thoat.Text = "Thoát";
            this.Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click_1);
            // 
            // FormThemNhanViens
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(637, 520);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormThemNhanViens";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemNhanViens";
            this.Load += new System.EventHandler(this.ThemNhanViens_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton LamMoi;
        private FontAwesome.Sharp.IconButton XacNhan;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private FontAwesome.Sharp.IconButton Thoat;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateTimePicker1;
        private Guna.UI2.WinForms.Guna2TextBox txtMatKhau;
        private Guna.UI2.WinForms.Guna2TextBox txtQueQuan;
        private Guna.UI2.WinForms.Guna2TextBox txtSdt;
        private Guna.UI2.WinForms.Guna2TextBox txtCMND;
        private Guna.UI2.WinForms.Guna2TextBox txtDanToc;
        private Guna.UI2.WinForms.Guna2TextBox txtHoTen;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNV;
        private System.Windows.Forms.RadioButton Nu;
        private System.Windows.Forms.RadioButton Nam;
    }
}