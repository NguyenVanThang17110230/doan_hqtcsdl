namespace QLTiemLaptop
{
    partial class frmQuanLyTaiKhoan
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
            this.dtgv_user = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txb_phanquyen = new System.Windows.Forms.TextBox();
            this.txb_matkhau = new System.Windows.Forms.TextBox();
            this.txb_taikhoan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_user)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_user
            // 
            this.dtgv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_user.Location = new System.Drawing.Point(8, 20);
            this.dtgv_user.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgv_user.Name = "dtgv_user";
            this.dtgv_user.RowHeadersWidth = 51;
            this.dtgv_user.RowTemplate.Height = 24;
            this.dtgv_user.Size = new System.Drawing.Size(332, 254);
            this.dtgv_user.TabIndex = 0;
            this.dtgv_user.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_user_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_update);
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.txb_phanquyen);
            this.panel1.Controls.Add(this.txb_matkhau);
            this.panel1.Controls.Add(this.txb_taikhoan);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(355, 20);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 253);
            this.panel1.TabIndex = 1;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(151, 205);
            this.btn_update.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(76, 24);
            this.btn_update.TabIndex = 8;
            this.btn_update.Text = "Sửa";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(16, 207);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(77, 21);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txb_phanquyen
            // 
            this.txb_phanquyen.Location = new System.Drawing.Point(103, 157);
            this.txb_phanquyen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_phanquyen.Name = "txb_phanquyen";
            this.txb_phanquyen.Size = new System.Drawing.Size(126, 23);
            this.txb_phanquyen.TabIndex = 6;
            // 
            // txb_matkhau
            // 
            this.txb_matkhau.Location = new System.Drawing.Point(103, 110);
            this.txb_matkhau.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_matkhau.Name = "txb_matkhau";
            this.txb_matkhau.Size = new System.Drawing.Size(126, 23);
            this.txb_matkhau.TabIndex = 5;
            // 
            // txb_taikhoan
            // 
            this.txb_taikhoan.Location = new System.Drawing.Point(103, 59);
            this.txb_taikhoan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_taikhoan.Name = "txb_taikhoan";
            this.txb_taikhoan.Size = new System.Drawing.Size(126, 23);
            this.txb_taikhoan.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phân quyền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 284);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgv_user);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmQuanLyTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.frmQuanLyTaiKhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_user)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_user;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txb_phanquyen;
        private System.Windows.Forms.TextBox txb_matkhau;
        private System.Windows.Forms.TextBox txb_taikhoan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}