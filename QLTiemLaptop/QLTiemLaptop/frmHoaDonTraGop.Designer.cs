namespace QLTiemLaptop
{
    partial class frmHoaDonTraGop
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
            this.dtgv_tragop = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_deletetg = new System.Windows.Forms.Button();
            this.btn_fixtg = new System.Windows.Forms.Button();
            this.btn_addtg = new System.Windows.Forms.Button();
            this.btn_cleartg = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_ngaybantg = new System.Windows.Forms.DateTimePicker();
            this.txb_tienphaitra = new System.Windows.Forms.TextBox();
            this.txb_thanhtoantrc = new System.Windows.Forms.TextBox();
            this.cbb_hantg = new System.Windows.Forms.ComboBox();
            this.cbb_idkh = new System.Windows.Forms.ComboBox();
            this.cbb_idnv = new System.Windows.Forms.ComboBox();
            this.cbb_idlaptg = new System.Windows.Forms.ComboBox();
            this.txb_tongtientg = new System.Windows.Forms.TextBox();
            this.txb_dongiatg = new System.Windows.Forms.TextBox();
            this.txb_soluongtg = new System.Windows.Forms.TextBox();
            this.txb_cmnd = new System.Windows.Forms.TextBox();
            this.txb_idhoadontg = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_tragop)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgv_tragop);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1521, 664);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dtgv_tragop
            // 
            this.dtgv_tragop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_tragop.Location = new System.Drawing.Point(17, 387);
            this.dtgv_tragop.Name = "dtgv_tragop";
            this.dtgv_tragop.RowHeadersWidth = 51;
            this.dtgv_tragop.RowTemplate.Height = 24;
            this.dtgv_tragop.Size = new System.Drawing.Size(1482, 256);
            this.dtgv_tragop.TabIndex = 2;
            this.dtgv_tragop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_tragop_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Controls.Add(this.btn_deletetg);
            this.panel2.Controls.Add(this.btn_fixtg);
            this.panel2.Controls.Add(this.btn_addtg);
            this.panel2.Controls.Add(this.btn_cleartg);
            this.panel2.Location = new System.Drawing.Point(17, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1482, 48);
            this.panel2.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(1320, 9);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(145, 31);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            // 
            // btn_deletetg
            // 
            this.btn_deletetg.Location = new System.Drawing.Point(1026, 9);
            this.btn_deletetg.Name = "btn_deletetg";
            this.btn_deletetg.Size = new System.Drawing.Size(144, 31);
            this.btn_deletetg.TabIndex = 3;
            this.btn_deletetg.Text = "Xóa";
            this.btn_deletetg.UseVisualStyleBackColor = true;
            // 
            // btn_fixtg
            // 
            this.btn_fixtg.Location = new System.Drawing.Point(704, 9);
            this.btn_fixtg.Name = "btn_fixtg";
            this.btn_fixtg.Size = new System.Drawing.Size(155, 31);
            this.btn_fixtg.TabIndex = 2;
            this.btn_fixtg.Text = "Sửa";
            this.btn_fixtg.UseVisualStyleBackColor = true;
            // 
            // btn_addtg
            // 
            this.btn_addtg.Location = new System.Drawing.Point(369, 9);
            this.btn_addtg.Name = "btn_addtg";
            this.btn_addtg.Size = new System.Drawing.Size(163, 31);
            this.btn_addtg.TabIndex = 1;
            this.btn_addtg.Text = "Thêm";
            this.btn_addtg.UseVisualStyleBackColor = true;
            // 
            // btn_cleartg
            // 
            this.btn_cleartg.Location = new System.Drawing.Point(54, 9);
            this.btn_cleartg.Name = "btn_cleartg";
            this.btn_cleartg.Size = new System.Drawing.Size(144, 31);
            this.btn_cleartg.TabIndex = 0;
            this.btn_cleartg.Text = "Làm mới";
            this.btn_cleartg.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_ngaybantg);
            this.panel1.Controls.Add(this.txb_tienphaitra);
            this.panel1.Controls.Add(this.txb_thanhtoantrc);
            this.panel1.Controls.Add(this.cbb_hantg);
            this.panel1.Controls.Add(this.cbb_idkh);
            this.panel1.Controls.Add(this.cbb_idnv);
            this.panel1.Controls.Add(this.cbb_idlaptg);
            this.panel1.Controls.Add(this.txb_tongtientg);
            this.panel1.Controls.Add(this.txb_dongiatg);
            this.panel1.Controls.Add(this.txb_soluongtg);
            this.panel1.Controls.Add(this.txb_cmnd);
            this.panel1.Controls.Add(this.txb_idhoadontg);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 266);
            this.panel1.TabIndex = 0;
            // 
            // dtp_ngaybantg
            // 
            this.dtp_ngaybantg.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaybantg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaybantg.Location = new System.Drawing.Point(880, 222);
            this.dtp_ngaybantg.Name = "dtp_ngaybantg";
            this.dtp_ngaybantg.ShowUpDown = true;
            this.dtp_ngaybantg.Size = new System.Drawing.Size(196, 22);
            this.dtp_ngaybantg.TabIndex = 26;
            // 
            // txb_tienphaitra
            // 
            this.txb_tienphaitra.Location = new System.Drawing.Point(1269, 219);
            this.txb_tienphaitra.Name = "txb_tienphaitra";
            this.txb_tienphaitra.Size = new System.Drawing.Size(196, 22);
            this.txb_tienphaitra.TabIndex = 25;
            // 
            // txb_thanhtoantrc
            // 
            this.txb_thanhtoantrc.Location = new System.Drawing.Point(1269, 132);
            this.txb_thanhtoantrc.Name = "txb_thanhtoantrc";
            this.txb_thanhtoantrc.Size = new System.Drawing.Size(196, 22);
            this.txb_thanhtoantrc.TabIndex = 24;
            // 
            // cbb_hantg
            // 
            this.cbb_hantg.FormattingEnabled = true;
            this.cbb_hantg.Items.AddRange(new object[] {
            "4",
            "8",
            "12"});
            this.cbb_hantg.Location = new System.Drawing.Point(1269, 45);
            this.cbb_hantg.Name = "cbb_hantg";
            this.cbb_hantg.Size = new System.Drawing.Size(196, 24);
            this.cbb_hantg.TabIndex = 23;
            // 
            // cbb_idkh
            // 
            this.cbb_idkh.FormattingEnabled = true;
            this.cbb_idkh.Location = new System.Drawing.Point(543, 44);
            this.cbb_idkh.Name = "cbb_idkh";
            this.cbb_idkh.Size = new System.Drawing.Size(200, 24);
            this.cbb_idkh.TabIndex = 22;
            // 
            // cbb_idnv
            // 
            this.cbb_idnv.FormattingEnabled = true;
            this.cbb_idnv.Location = new System.Drawing.Point(156, 222);
            this.cbb_idnv.Name = "cbb_idnv";
            this.cbb_idnv.Size = new System.Drawing.Size(200, 24);
            this.cbb_idnv.TabIndex = 21;
            // 
            // cbb_idlaptg
            // 
            this.cbb_idlaptg.FormattingEnabled = true;
            this.cbb_idlaptg.Location = new System.Drawing.Point(156, 132);
            this.cbb_idlaptg.Name = "cbb_idlaptg";
            this.cbb_idlaptg.Size = new System.Drawing.Size(200, 24);
            this.cbb_idlaptg.TabIndex = 20;
            this.cbb_idlaptg.SelectedIndexChanged += new System.EventHandler(this.cbb_idlaptg_SelectedIndexChanged);
            // 
            // txb_tongtientg
            // 
            this.txb_tongtientg.Location = new System.Drawing.Point(880, 132);
            this.txb_tongtientg.Name = "txb_tongtientg";
            this.txb_tongtientg.Size = new System.Drawing.Size(196, 22);
            this.txb_tongtientg.TabIndex = 19;
            // 
            // txb_dongiatg
            // 
            this.txb_dongiatg.Location = new System.Drawing.Point(880, 46);
            this.txb_dongiatg.Name = "txb_dongiatg";
            this.txb_dongiatg.Size = new System.Drawing.Size(196, 22);
            this.txb_dongiatg.TabIndex = 18;
            this.txb_dongiatg.TextChanged += new System.EventHandler(this.txb_dongiatg_TextChanged);
            // 
            // txb_soluongtg
            // 
            this.txb_soluongtg.Location = new System.Drawing.Point(543, 222);
            this.txb_soluongtg.Name = "txb_soluongtg";
            this.txb_soluongtg.Size = new System.Drawing.Size(200, 22);
            this.txb_soluongtg.TabIndex = 17;
            // 
            // txb_cmnd
            // 
            this.txb_cmnd.Location = new System.Drawing.Point(543, 134);
            this.txb_cmnd.Name = "txb_cmnd";
            this.txb_cmnd.Size = new System.Drawing.Size(200, 22);
            this.txb_cmnd.TabIndex = 16;
            // 
            // txb_idhoadontg
            // 
            this.txb_idhoadontg.Location = new System.Drawing.Point(156, 45);
            this.txb_idhoadontg.Name = "txb_idhoadontg";
            this.txb_idhoadontg.Size = new System.Drawing.Size(200, 22);
            this.txb_idhoadontg.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1134, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "Số tiền phải trả:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1137, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(105, 17);
            this.label14.TabIndex = 13;
            this.label14.Text = "Thanh toán trc:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1134, 51);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Thời hạn trả góp:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(798, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 17);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ngày bán:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(798, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 17);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tổng tiền:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(798, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Đơn giá:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(406, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số lượng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "CMND:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã laptop:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn trả góp:";
            // 
            // frmHoaDonTraGop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 688);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmHoaDonTraGop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoaDonTraGop";
            this.Load += new System.EventHandler(this.frmHoaDonTraGop_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_tragop)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbb_hantg;
        private System.Windows.Forms.ComboBox cbb_idkh;
        private System.Windows.Forms.ComboBox cbb_idnv;
        private System.Windows.Forms.ComboBox cbb_idlaptg;
        private System.Windows.Forms.TextBox txb_tongtientg;
        private System.Windows.Forms.TextBox txb_dongiatg;
        private System.Windows.Forms.TextBox txb_soluongtg;
        private System.Windows.Forms.TextBox txb_cmnd;
        private System.Windows.Forms.TextBox txb_idhoadontg;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_ngaybantg;
        private System.Windows.Forms.TextBox txb_tienphaitra;
        private System.Windows.Forms.TextBox txb_thanhtoantrc;
        private System.Windows.Forms.DataGridView dtgv_tragop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_deletetg;
        private System.Windows.Forms.Button btn_fixtg;
        private System.Windows.Forms.Button btn_addtg;
        private System.Windows.Forms.Button btn_cleartg;
    }
}