
namespace GUI
{
    partial class QLNV
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Xoa = new FontAwesome.Sharp.IconButton();
            this.ChinhSua = new FontAwesome.Sharp.IconButton();
            this.Them = new FontAwesome.Sharp.IconButton();
            this.sortBtn = new FontAwesome.Sharp.IconButton();
            this.cbbSort = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(188, 112);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1083, 490);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "`";
            // 
            // txtName
            // 
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(132, 61);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(149, 36);
            this.txtName.TabIndex = 52;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1021, 363);
            this.dataGridView1.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(245, 29);
            this.label10.TabIndex = 24;
            this.label10.Text = "Danh sách nhân viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Họ và tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(590, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 51);
            this.label1.TabIndex = 26;
            this.label1.Text = "Hiệu Sách ";
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.Xoa.IconColor = System.Drawing.Color.Red;
            this.Xoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Xoa.IconSize = 25;
            this.Xoa.Location = new System.Drawing.Point(510, 627);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(85, 36);
            this.Xoa.TabIndex = 25;
            this.Xoa.Text = "Xóa";
            this.Xoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Xoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Xoa.UseVisualStyleBackColor = false;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // ChinhSua
            // 
            this.ChinhSua.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ChinhSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChinhSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ChinhSua.IconColor = System.Drawing.Color.Blue;
            this.ChinhSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ChinhSua.IconSize = 25;
            this.ChinhSua.Location = new System.Drawing.Point(347, 627);
            this.ChinhSua.Name = "ChinhSua";
            this.ChinhSua.Size = new System.Drawing.Size(131, 36);
            this.ChinhSua.TabIndex = 25;
            this.ChinhSua.Text = "Chỉnh sửa";
            this.ChinhSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ChinhSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ChinhSua.UseVisualStyleBackColor = false;
            this.ChinhSua.Click += new System.EventHandler(this.ChinhSua_Click);
            // 
            // Them
            // 
            this.Them.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.Them.IconColor = System.Drawing.Color.Blue;
            this.Them.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Them.IconSize = 25;
            this.Them.Location = new System.Drawing.Point(220, 627);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(100, 36);
            this.Them.TabIndex = 25;
            this.Them.Text = "Thêm";
            this.Them.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Them.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Them.UseVisualStyleBackColor = false;
            this.Them.Click += new System.EventHandler(this.Them_Click);
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
            this.sortBtn.Location = new System.Drawing.Point(989, 627);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(100, 36);
            this.sortBtn.TabIndex = 46;
            this.sortBtn.Text = "Sắp sếp";
            this.sortBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sortBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.sortBtn.UseVisualStyleBackColor = false;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // cbbSort
            // 
            this.cbbSort.BackColor = System.Drawing.Color.Transparent;
            this.cbbSort.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSort.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSort.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbSort.FocusedState.Parent = this.cbbSort;
            this.cbbSort.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbSort.ForeColor = System.Drawing.Color.Black;
            this.cbbSort.HoverState.Parent = this.cbbSort;
            this.cbbSort.ItemHeight = 30;
            this.cbbSort.ItemsAppearance.Parent = this.cbbSort;
            this.cbbSort.Location = new System.Drawing.Point(1111, 627);
            this.cbbSort.Name = "cbbSort";
            this.cbbSort.ShadowDecoration.Parent = this.cbbSort;
            this.cbbSort.Size = new System.Drawing.Size(130, 36);
            this.cbbSort.TabIndex = 71;
            // 
            // QLNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1444, 753);
            this.Controls.Add(this.cbbSort);
            this.Controls.Add(this.sortBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.ChinhSua);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.groupBox3);
            this.Name = "QLNV";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.QLNV_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton Them;
        private FontAwesome.Sharp.IconButton ChinhSua;
        private FontAwesome.Sharp.IconButton Xoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton sortBtn;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSort;
    }
}