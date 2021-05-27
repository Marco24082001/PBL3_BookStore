
namespace GUI
{
    partial class BaoCaoDoanhThu
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
            this.cbbNgay = new System.Windows.Forms.ComboBox();
            this.cbbThang = new System.Windows.Forms.ComboBox();
            this.cbbNam = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TongDoanhThu = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sortBtn = new FontAwesome.Sharp.IconButton();
            this.cbbSort = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.backPage = new FontAwesome.Sharp.IconButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.loadBtn = new Guna.UI2.WinForms.Guna2Button();
            this.numDay = new System.Windows.Forms.NumericUpDown();
            this.turnoverChart = new LiveCharts.WinForms.CartesianChart();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbNgay);
            this.groupBox1.Controls.Add(this.cbbThang);
            this.groupBox1.Controls.Add(this.cbbNam);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.TongDoanhThu);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.sortBtn);
            this.groupBox1.Controls.Add(this.cbbSort);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(734, 530);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Doanh thu";
            // 
            // cbbNgay
            // 
            this.cbbNgay.FormattingEnabled = true;
            this.cbbNgay.Location = new System.Drawing.Point(343, 46);
            this.cbbNgay.Name = "cbbNgay";
            this.cbbNgay.Size = new System.Drawing.Size(121, 28);
            this.cbbNgay.TabIndex = 35;
            this.cbbNgay.SelectedIndexChanged += new System.EventHandler(this.cbbNgay_SelectedIndexChanged);
            // 
            // cbbThang
            // 
            this.cbbThang.FormattingEnabled = true;
            this.cbbThang.Location = new System.Drawing.Point(184, 46);
            this.cbbThang.Name = "cbbThang";
            this.cbbThang.Size = new System.Drawing.Size(121, 28);
            this.cbbThang.TabIndex = 36;
            this.cbbThang.SelectedIndexChanged += new System.EventHandler(this.cbbThang_SelectedIndexChanged);
            // 
            // cbbNam
            // 
            this.cbbNam.FormattingEnabled = true;
            this.cbbNam.Location = new System.Drawing.Point(35, 46);
            this.cbbNam.Name = "cbbNam";
            this.cbbNam.Size = new System.Drawing.Size(121, 28);
            this.cbbNam.TabIndex = 37;
            this.cbbNam.SelectedIndexChanged += new System.EventHandler(this.cbbNam_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(35, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(663, 350);
            this.dataGridView1.TabIndex = 34;
            // 
            // TongDoanhThu
            // 
            this.TongDoanhThu.Enabled = false;
            this.TongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TongDoanhThu.Location = new System.Drawing.Point(510, 485);
            this.TongDoanhThu.Name = "TongDoanhThu";
            this.TongDoanhThu.Size = new System.Drawing.Size(189, 27);
            this.TongDoanhThu.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(311, 483);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(193, 29);
            this.label8.TabIndex = 32;
            this.label8.Text = "Tổng doanh thu :";
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
            this.sortBtn.Location = new System.Drawing.Point(35, 478);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(100, 34);
            this.sortBtn.TabIndex = 31;
            this.sortBtn.Text = "Sắp sếp";
            this.sortBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sortBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sortBtn.UseVisualStyleBackColor = false;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // cbbSort
            // 
            this.cbbSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSort.FormattingEnabled = true;
            this.cbbSort.Location = new System.Drawing.Point(141, 482);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.Size = new System.Drawing.Size(110, 28);
            this.cbbSort.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(212, 29);
            this.label10.TabIndex = 25;
            this.label10.Text = "Báo cáo doanh thu";
            // 
            // backPage
            // 
            this.backPage.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.backPage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backPage.IconChar = FontAwesome.Sharp.IconChar.AngleDoubleLeft;
            this.backPage.IconColor = System.Drawing.Color.Blue;
            this.backPage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.backPage.IconSize = 30;
            this.backPage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backPage.Location = new System.Drawing.Point(657, 670);
            this.backPage.Name = "backPage";
            this.backPage.Size = new System.Drawing.Size(147, 48);
            this.backPage.TabIndex = 55;
            this.backPage.Text = "Back Page";
            this.backPage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backPage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.backPage.UseVisualStyleBackColor = false;
            this.backPage.Click += new System.EventHandler(this.backPage_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.guna2HtmlLabel1);
            this.groupBox2.Controls.Add(this.loadBtn);
            this.groupBox2.Controls.Add(this.numDay);
            this.groupBox2.Controls.Add(this.turnoverChart);
            this.groupBox2.Controls.Add(this.iconPictureBox1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(751, 124);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(682, 528);
            this.groupBox2.TabIndex = 56;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Doanh thu";
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
            // numDay
            // 
            this.numDay.Location = new System.Drawing.Point(65, 61);
            this.numDay.Margin = new System.Windows.Forms.Padding(2);
            this.numDay.Name = "numDay";
            this.numDay.Size = new System.Drawing.Size(95, 22);
            this.numDay.TabIndex = 33;
            this.numDay.ValueChanged += new System.EventHandler(this.numDay_ValueChanged);
            // 
            // turnoverChart
            // 
            this.turnoverChart.Location = new System.Drawing.Point(39, 126);
            this.turnoverChart.Margin = new System.Windows.Forms.Padding(2);
            this.turnoverChart.Name = "turnoverChart";
            this.turnoverChart.Size = new System.Drawing.Size(617, 348);
            this.turnoverChart.TabIndex = 28;
            this.turnoverChart.Text = "cartesianChart1";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Sort;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Black;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 29;
            this.iconPictureBox1.Location = new System.Drawing.Point(11, 58);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 29);
            this.iconPictureBox1.TabIndex = 27;
            this.iconPictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 29);
            this.label3.TabIndex = 25;
            this.label3.Text = "Biểu đồ doanh thu";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(169, 59);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(90, 24);
            this.guna2HtmlLabel1.TabIndex = 53;
            this.guna2HtmlLabel1.Text = "Ngày trước";
            // 
            // BaoCaoDoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1444, 753);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.backPage);
            this.Controls.Add(this.groupBox1);
            this.Name = "BaoCaoDoanhThu";
            this.Text = "Quản lý doanh thu";
            this.Load += new System.EventHandler(this.BaoCaoDoanhThu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton backPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TongDoanhThu;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton sortBtn;
        private System.Windows.Forms.ComboBox cbbSort;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbbNgay;
        private System.Windows.Forms.ComboBox cbbThang;
        private System.Windows.Forms.ComboBox cbbNam;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Button loadBtn;
        private System.Windows.Forms.NumericUpDown numDay;
        private LiveCharts.WinForms.CartesianChart turnoverChart;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}