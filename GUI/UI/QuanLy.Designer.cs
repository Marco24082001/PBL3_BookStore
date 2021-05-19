
namespace GUI
{
    partial class QuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLy));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnQLDT = new FontAwesome.Sharp.IconButton();
            this.btnQLKS = new FontAwesome.Sharp.IconButton();
            this.btnQLNV = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.txtTen = new System.Windows.Forms.Label();
            this.DangXuat = new FontAwesome.Sharp.IconButton();
            this.infoNhanVien = new FontAwesome.Sharp.IconPictureBox();
            this.Thoat = new System.Windows.Forms.PictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thoat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnQLDT);
            this.panelMenu.Controls.Add(this.btnQLKS);
            this.panelMenu.Controls.Add(this.btnQLNV);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(238, 803);
            this.panelMenu.TabIndex = 48;
            // 
            // btnQLDT
            // 
            this.btnQLDT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLDT.FlatAppearance.BorderSize = 0;
            this.btnQLDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDT.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLDT.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.btnQLDT.IconColor = System.Drawing.Color.White;
            this.btnQLDT.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLDT.IconSize = 35;
            this.btnQLDT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLDT.Location = new System.Drawing.Point(3, 307);
            this.btnQLDT.Name = "btnQLDT";
            this.btnQLDT.Size = new System.Drawing.Size(235, 65);
            this.btnQLDT.TabIndex = 1;
            this.btnQLDT.Text = "Quản lý doanh thu";
            this.btnQLDT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLDT.UseVisualStyleBackColor = true;
            this.btnQLDT.Click += new System.EventHandler(this.btnQLDT_Click);
            // 
            // btnQLKS
            // 
            this.btnQLKS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLKS.FlatAppearance.BorderSize = 0;
            this.btnQLKS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLKS.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLKS.IconChar = FontAwesome.Sharp.IconChar.BookOpen;
            this.btnQLKS.IconColor = System.Drawing.Color.White;
            this.btnQLKS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLKS.IconSize = 35;
            this.btnQLKS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLKS.Location = new System.Drawing.Point(3, 235);
            this.btnQLKS.Name = "btnQLKS";
            this.btnQLKS.Size = new System.Drawing.Size(235, 65);
            this.btnQLKS.TabIndex = 1;
            this.btnQLKS.Text = "Quản lý kho sách";
            this.btnQLKS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLKS.UseVisualStyleBackColor = true;
            this.btnQLKS.Click += new System.EventHandler(this.btnQLKS_Click);
            // 
            // btnQLNV
            // 
            this.btnQLNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQLNV.FlatAppearance.BorderSize = 0;
            this.btnQLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNV.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQLNV.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnQLNV.IconColor = System.Drawing.Color.White;
            this.btnQLNV.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnQLNV.IconSize = 35;
            this.btnQLNV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQLNV.Location = new System.Drawing.Point(0, 165);
            this.btnQLNV.Name = "btnQLNV";
            this.btnQLNV.Size = new System.Drawing.Size(238, 65);
            this.btnQLNV.TabIndex = 1;
            this.btnQLNV.Text = "Quản lý nhân viên";
            this.btnQLNV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Location = new System.Drawing.Point(0, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(238, 161);
            this.panelLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(48, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(5);
            this.btnHome.Size = new System.Drawing.Size(134, 142);
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelTitleBar.Controls.Add(this.txtTen);
            this.panelTitleBar.Controls.Add(this.DangXuat);
            this.panelTitleBar.Controls.Add(this.infoNhanVien);
            this.panelTitleBar.Controls.Add(this.Thoat);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(238, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1444, 70);
            this.panelTitleBar.TabIndex = 49;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // txtTen
            // 
            this.txtTen.AutoSize = true;
            this.txtTen.Font = new System.Drawing.Font("Century", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtTen.Location = new System.Drawing.Point(1199, 6);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(156, 23);
            this.txtTen.TabIndex = 28;
            this.txtTen.Text = "Tên nhân viên";
            // 
            // DangXuat
            // 
            this.DangXuat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DangXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DangXuat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.DangXuat.IconColor = System.Drawing.Color.Red;
            this.DangXuat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.DangXuat.IconSize = 25;
            this.DangXuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DangXuat.Location = new System.Drawing.Point(1203, 32);
            this.DangXuat.Name = "DangXuat";
            this.DangXuat.Size = new System.Drawing.Size(129, 34);
            this.DangXuat.TabIndex = 29;
            this.DangXuat.Text = "Đăng xuất";
            this.DangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DangXuat.UseVisualStyleBackColor = false;
            this.DangXuat.Click += new System.EventHandler(this.DangXuat_Click);
            // 
            // infoNhanVien
            // 
            this.infoNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.infoNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.infoNhanVien.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.infoNhanVien.IconChar = FontAwesome.Sharp.IconChar.UserCog;
            this.infoNhanVien.IconColor = System.Drawing.SystemColors.HighlightText;
            this.infoNhanVien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.infoNhanVien.IconSize = 70;
            this.infoNhanVien.Location = new System.Drawing.Point(1107, 3);
            this.infoNhanVien.Name = "infoNhanVien";
            this.infoNhanVien.Size = new System.Drawing.Size(86, 70);
            this.infoNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.infoNhanVien.TabIndex = 27;
            this.infoNhanVien.TabStop = false;
            this.infoNhanVien.Click += new System.EventHandler(this.infoNhanVien_Click);
            // 
            // Thoat
            // 
            this.Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Thoat.Dock = System.Windows.Forms.DockStyle.Right;
            this.Thoat.Image = ((System.Drawing.Image)(resources.GetObject("Thoat.Image")));
            this.Thoat.Location = new System.Drawing.Point(1372, 0);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(72, 70);
            this.Thoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Thoat.TabIndex = 2;
            this.Thoat.TabStop = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Century", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(118, 26);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(95, 33);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 45;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(47, 15);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(45, 49);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(238, 70);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1444, 10);
            this.panelShadow.TabIndex = 50;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(238, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1444, 723);
            this.panelDesktop.TabIndex = 51;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1682, 803);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "QuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UxUiQuanLy";
            this.Load += new System.EventHandler(this.QuanLy_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thoat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnQLDT;
        private FontAwesome.Sharp.IconButton btnQLKS;
        private FontAwesome.Sharp.IconButton btnQLNV;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox Thoat;
        private System.Windows.Forms.Label txtTen;
        private FontAwesome.Sharp.IconButton DangXuat;
        private FontAwesome.Sharp.IconPictureBox infoNhanVien;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
    }
}