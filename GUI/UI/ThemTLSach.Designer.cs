
namespace GUI
{
    partial class ThemTLSach
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaLS = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenLS = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OK = new FontAwesome.Sharp.IconButton();
            this.label8 = new System.Windows.Forms.Label();
            this.Thoat = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại sách :";
            // 
            // txtMaLS
            // 
            this.txtMaLS.Location = new System.Drawing.Point(220, 104);
            this.txtMaLS.Name = "txtMaLS";
            this.txtMaLS.Size = new System.Drawing.Size(131, 27);
            this.txtMaLS.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại sách :";
            // 
            // txtTenLS
            // 
            this.txtTenLS.Location = new System.Drawing.Point(220, 159);
            this.txtTenLS.Name = "txtTenLS";
            this.txtTenLS.Size = new System.Drawing.Size(131, 27);
            this.txtTenLS.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OK);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Thoat);
            this.groupBox1.Controls.Add(this.txtMaLS);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTenLS);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 311);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OK.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.OK.IconColor = System.Drawing.Color.Blue;
            this.OK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.OK.IconSize = 20;
            this.OK.Location = new System.Drawing.Point(229, 244);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(122, 34);
            this.OK.TabIndex = 32;
            this.OK.Text = "Xác nhận";
            this.OK.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 29);
            this.label8.TabIndex = 11;
            this.label8.Text = "Thể loại";
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
            this.Thoat.Location = new System.Drawing.Point(54, 244);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(110, 34);
            this.Thoat.TabIndex = 31;
            this.Thoat.Text = "Thoát";
            this.Thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // ThemTLSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(243)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(407, 338);
            this.Controls.Add(this.groupBox1);
            this.Name = "ThemTLSach";
            this.Text = "ThemTLSach";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaLS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenLS;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton Thoat;
        private FontAwesome.Sharp.IconButton OK;
    }
}