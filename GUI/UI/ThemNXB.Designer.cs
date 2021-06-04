
namespace GUI
{
    partial class ThemNXB
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
            this.XacNhan = new FontAwesome.Sharp.IconButton();
            this.Thoat = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaNXB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenNXB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.XacNhan);
            this.groupBox1.Controls.Add(this.Thoat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaNXB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenNXB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 307);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // XacNhan
            // 
            this.XacNhan.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.XacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XacNhan.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.XacNhan.IconColor = System.Drawing.Color.Blue;
            this.XacNhan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.XacNhan.IconSize = 20;
            this.XacNhan.Location = new System.Drawing.Point(291, 238);
            this.XacNhan.Name = "XacNhan";
            this.XacNhan.Size = new System.Drawing.Size(122, 34);
            this.XacNhan.TabIndex = 37;
            this.XacNhan.Text = "Xác nhận";
            this.XacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.XacNhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.XacNhan.UseVisualStyleBackColor = false;
            this.XacNhan.Click += new System.EventHandler(this.XacNhan_Click);
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.Thoat.IconColor = System.Drawing.Color.Red;
            this.Thoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Thoat.IconSize = 25;
            this.Thoat.Location = new System.Drawing.Point(36, 238);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(110, 34);
            this.Thoat.TabIndex = 36;
            this.Thoat.Text = "Thoát";
            this.Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Nhà xuất bản";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà xuất bản :";
            // 
            // txtMaNXB
            // 
            this.txtMaNXB.Location = new System.Drawing.Point(199, 93);
            this.txtMaNXB.Name = "txtMaNXB";
            this.txtMaNXB.Size = new System.Drawing.Size(147, 27);
            this.txtMaNXB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên nhà xuất bản :";
            // 
            // txtTenNXB
            // 
            this.txtTenNXB.Location = new System.Drawing.Point(199, 148);
            this.txtTenNXB.Name = "txtTenNXB";
            this.txtTenNXB.Size = new System.Drawing.Size(147, 27);
            this.txtTenNXB.TabIndex = 1;
            // 
            // ThemNXB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(449, 332);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThemNXB";
            this.Text = "ThemNXB";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaNXB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenNXB;
        private FontAwesome.Sharp.IconButton XacNhan;
        private FontAwesome.Sharp.IconButton Thoat;
    }
}