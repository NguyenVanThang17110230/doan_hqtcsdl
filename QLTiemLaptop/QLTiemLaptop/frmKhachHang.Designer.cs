namespace QLTiemLaptop
{
    partial class frmKhachHang
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
            this.dtgv_khachhang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txb_timkiemten = new System.Windows.Forms.TextBox();
            this.txb_timkiemkh = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txb_sdtkhachhang = new System.Windows.Forms.TextBox();
            this.txb_diachikhachhangg = new System.Windows.Forms.TextBox();
            this.txb_gioitinhkhachhangg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_tenkhachhangg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txb_idkhachhangg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exitkh = new System.Windows.Forms.Button();
            this.btn_deletkhh = new System.Windows.Forms.Button();
            this.btn_fixkhachhang = new System.Windows.Forms.Button();
            this.btn_clearkhachhang = new System.Windows.Forms.Button();
            this.btn_addkhachhang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_khachhang)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_khachhang
            // 
            this.dtgv_khachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_khachhang.Location = new System.Drawing.Point(420, 10);
            this.dtgv_khachhang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgv_khachhang.Name = "dtgv_khachhang";
            this.dtgv_khachhang.RowHeadersWidth = 51;
            this.dtgv_khachhang.RowTemplate.Height = 24;
            this.dtgv_khachhang.Size = new System.Drawing.Size(532, 504);
            this.dtgv_khachhang.TabIndex = 0;
            this.dtgv_khachhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_khachhang_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 504);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(251, 321);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txb_timkiemten);
            this.panel4.Controls.Add(this.txb_timkiemkh);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(14, 275);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(374, 40);
            this.panel4.TabIndex = 14;
            // 
            // txb_timkiemten
            // 
            this.txb_timkiemten.Location = new System.Drawing.Point(174, 11);
            this.txb_timkiemten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_timkiemten.Name = "txb_timkiemten";
            this.txb_timkiemten.Size = new System.Drawing.Size(165, 20);
            this.txb_timkiemten.TabIndex = 2;
            this.txb_timkiemten.TextChanged += new System.EventHandler(this.txb_timkiemten_TextChanged);
            // 
            // txb_timkiemkh
            // 
            this.txb_timkiemkh.Location = new System.Drawing.Point(96, 12);
            this.txb_timkiemkh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_timkiemkh.Name = "txb_timkiemkh";
            this.txb_timkiemkh.Size = new System.Drawing.Size(62, 20);
            this.txb_timkiemkh.TabIndex = 1;
            this.txb_timkiemkh.TextChanged += new System.EventHandler(this.txb_timkiemkh_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tìm Kiếm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txb_sdtkhachhang);
            this.panel3.Controls.Add(this.txb_diachikhachhangg);
            this.panel3.Controls.Add(this.txb_gioitinhkhachhangg);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txb_tenkhachhangg);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txb_idkhachhangg);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(14, 54);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(374, 216);
            this.panel3.TabIndex = 13;
            // 
            // txb_sdtkhachhang
            // 
            this.txb_sdtkhachhang.Location = new System.Drawing.Point(96, 188);
            this.txb_sdtkhachhang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_sdtkhachhang.Name = "txb_sdtkhachhang";
            this.txb_sdtkhachhang.Size = new System.Drawing.Size(243, 23);
            this.txb_sdtkhachhang.TabIndex = 10;
            // 
            // txb_diachikhachhangg
            // 
            this.txb_diachikhachhangg.Location = new System.Drawing.Point(96, 151);
            this.txb_diachikhachhangg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_diachikhachhangg.Name = "txb_diachikhachhangg";
            this.txb_diachikhachhangg.Size = new System.Drawing.Size(243, 23);
            this.txb_diachikhachhangg.TabIndex = 9;
            // 
            // txb_gioitinhkhachhangg
            // 
            this.txb_gioitinhkhachhangg.Location = new System.Drawing.Point(96, 106);
            this.txb_gioitinhkhachhangg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_gioitinhkhachhangg.Name = "txb_gioitinhkhachhangg";
            this.txb_gioitinhkhachhangg.Size = new System.Drawing.Size(243, 23);
            this.txb_gioitinhkhachhangg.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số điện thoại";
            // 
            // txb_tenkhachhangg
            // 
            this.txb_tenkhachhangg.Location = new System.Drawing.Point(96, 60);
            this.txb_tenkhachhangg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_tenkhachhangg.Name = "txb_tenkhachhangg";
            this.txb_tenkhachhangg.Size = new System.Drawing.Size(243, 23);
            this.txb_tenkhachhangg.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // txb_idkhachhangg
            // 
            this.txb_idkhachhangg.Location = new System.Drawing.Point(96, 14);
            this.txb_idkhachhangg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_idkhachhangg.Name = "txb_idkhachhangg";
            this.txb_idkhachhangg.Size = new System.Drawing.Size(243, 23);
            this.txb_idkhachhangg.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(2, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách hàng";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_exitkh);
            this.panel2.Controls.Add(this.btn_deletkhh);
            this.panel2.Controls.Add(this.btn_fixkhachhang);
            this.panel2.Controls.Add(this.btn_clearkhachhang);
            this.panel2.Controls.Add(this.btn_addkhachhang);
            this.panel2.Location = new System.Drawing.Point(14, 321);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(226, 159);
            this.panel2.TabIndex = 12;
            // 
            // btn_exitkh
            // 
            this.btn_exitkh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_exitkh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitkh.Location = new System.Drawing.Point(69, 117);
            this.btn_exitkh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_exitkh.Name = "btn_exitkh";
            this.btn_exitkh.Size = new System.Drawing.Size(88, 28);
            this.btn_exitkh.TabIndex = 16;
            this.btn_exitkh.Text = "Thoát";
            this.btn_exitkh.UseVisualStyleBackColor = false;
            this.btn_exitkh.Click += new System.EventHandler(this.btn_exitkh_Click);
            // 
            // btn_deletkhh
            // 
            this.btn_deletkhh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_deletkhh.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletkhh.Location = new System.Drawing.Point(128, 67);
            this.btn_deletkhh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_deletkhh.Name = "btn_deletkhh";
            this.btn_deletkhh.Size = new System.Drawing.Size(88, 30);
            this.btn_deletkhh.TabIndex = 15;
            this.btn_deletkhh.Text = "Xóa";
            this.btn_deletkhh.UseVisualStyleBackColor = false;
            this.btn_deletkhh.Click += new System.EventHandler(this.btn_deletkhh_Click);
            // 
            // btn_fixkhachhang
            // 
            this.btn_fixkhachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_fixkhachhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_fixkhachhang.Location = new System.Drawing.Point(9, 67);
            this.btn_fixkhachhang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_fixkhachhang.Name = "btn_fixkhachhang";
            this.btn_fixkhachhang.Size = new System.Drawing.Size(88, 30);
            this.btn_fixkhachhang.TabIndex = 14;
            this.btn_fixkhachhang.Text = "Sửa ";
            this.btn_fixkhachhang.UseVisualStyleBackColor = false;
            this.btn_fixkhachhang.Click += new System.EventHandler(this.btn_fixkhachhang_Click);
            // 
            // btn_clearkhachhang
            // 
            this.btn_clearkhachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_clearkhachhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearkhachhang.Location = new System.Drawing.Point(9, 15);
            this.btn_clearkhachhang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_clearkhachhang.Name = "btn_clearkhachhang";
            this.btn_clearkhachhang.Size = new System.Drawing.Size(88, 30);
            this.btn_clearkhachhang.TabIndex = 13;
            this.btn_clearkhachhang.Text = "Làm mới";
            this.btn_clearkhachhang.UseVisualStyleBackColor = false;
            this.btn_clearkhachhang.Click += new System.EventHandler(this.btn_clearkhachhang_Click);
            // 
            // btn_addkhachhang
            // 
            this.btn_addkhachhang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_addkhachhang.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addkhachhang.Location = new System.Drawing.Point(128, 15);
            this.btn_addkhachhang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addkhachhang.Name = "btn_addkhachhang";
            this.btn_addkhachhang.Size = new System.Drawing.Size(88, 30);
            this.btn_addkhachhang.TabIndex = 0;
            this.btn_addkhachhang.Text = "Thêm ";
            this.btn_addkhachhang.UseVisualStyleBackColor = false;
            this.btn_addkhachhang.Click += new System.EventHandler(this.btn_addkhachhang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(74, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(962, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgv_khachhang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách Hàng";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_khachhang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_khachhang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_deletkhh;
        private System.Windows.Forms.Button btn_fixkhachhang;
        private System.Windows.Forms.Button btn_clearkhachhang;
        private System.Windows.Forms.Button btn_addkhachhang;
        private System.Windows.Forms.TextBox txb_sdtkhachhang;
        private System.Windows.Forms.TextBox txb_diachikhachhangg;
        private System.Windows.Forms.TextBox txb_gioitinhkhachhangg;
        private System.Windows.Forms.TextBox txb_tenkhachhangg;
        private System.Windows.Forms.TextBox txb_idkhachhangg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_exitkh;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txb_timkiemkh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_timkiemten;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}