﻿namespace QLTiemLaptop
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
            this.txb_thanhtoantrc = new System.Windows.Forms.TextBox();
            this.cbb_hantg = new System.Windows.Forms.ComboBox();
            this.cbb_idkh = new System.Windows.Forms.ComboBox();
            this.cbb_idnv = new System.Windows.Forms.ComboBox();
            this.cbb_idlaptg = new System.Windows.Forms.ComboBox();
            this.txb_tongtientg = new System.Windows.Forms.TextBox();
            this.txb_cmnd = new System.Windows.Forms.TextBox();
            this.txb_idhoadontg = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(922, 540);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hóa đơn trả góp";
            // 
            // dtgv_tragop
            // 
            this.dtgv_tragop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_tragop.Location = new System.Drawing.Point(13, 254);
            this.dtgv_tragop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgv_tragop.Name = "dtgv_tragop";
            this.dtgv_tragop.RowHeadersWidth = 51;
            this.dtgv_tragop.RowTemplate.Height = 24;
            this.dtgv_tragop.Size = new System.Drawing.Size(892, 269);
            this.dtgv_tragop.TabIndex = 2;
            this.dtgv_tragop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_tragop_CellClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Controls.Add(this.btn_deletetg);
            this.panel2.Controls.Add(this.btn_fixtg);
            this.panel2.Controls.Add(this.btn_addtg);
            this.panel2.Controls.Add(this.btn_cleartg);
            this.panel2.Location = new System.Drawing.Point(13, 210);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 39);
            this.panel2.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(716, 7);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(109, 25);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_deletetg
            // 
            this.btn_deletetg.Location = new System.Drawing.Point(542, 7);
            this.btn_deletetg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_deletetg.Name = "btn_deletetg";
            this.btn_deletetg.Size = new System.Drawing.Size(108, 25);
            this.btn_deletetg.TabIndex = 3;
            this.btn_deletetg.Text = "Xóa";
            this.btn_deletetg.UseVisualStyleBackColor = true;
            this.btn_deletetg.Click += new System.EventHandler(this.btn_deletetg_Click);
            // 
            // btn_fixtg
            // 
            this.btn_fixtg.Location = new System.Drawing.Point(373, 7);
            this.btn_fixtg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_fixtg.Name = "btn_fixtg";
            this.btn_fixtg.Size = new System.Drawing.Size(116, 25);
            this.btn_fixtg.TabIndex = 2;
            this.btn_fixtg.Text = "Sửa";
            this.btn_fixtg.UseVisualStyleBackColor = true;
            this.btn_fixtg.Click += new System.EventHandler(this.btn_fixtg_Click);
            // 
            // btn_addtg
            // 
            this.btn_addtg.Location = new System.Drawing.Point(193, 7);
            this.btn_addtg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_addtg.Name = "btn_addtg";
            this.btn_addtg.Size = new System.Drawing.Size(122, 25);
            this.btn_addtg.TabIndex = 1;
            this.btn_addtg.Text = "Thêm";
            this.btn_addtg.UseVisualStyleBackColor = true;
            this.btn_addtg.Click += new System.EventHandler(this.btn_addtg_Click);
            // 
            // btn_cleartg
            // 
            this.btn_cleartg.Location = new System.Drawing.Point(22, 7);
            this.btn_cleartg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cleartg.Name = "btn_cleartg";
            this.btn_cleartg.Size = new System.Drawing.Size(108, 25);
            this.btn_cleartg.TabIndex = 0;
            this.btn_cleartg.Text = "Làm mới";
            this.btn_cleartg.UseVisualStyleBackColor = true;
            this.btn_cleartg.Click += new System.EventHandler(this.btn_cleartg_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtp_ngaybantg);
            this.panel1.Controls.Add(this.txb_thanhtoantrc);
            this.panel1.Controls.Add(this.cbb_hantg);
            this.panel1.Controls.Add(this.cbb_idkh);
            this.panel1.Controls.Add(this.cbb_idnv);
            this.panel1.Controls.Add(this.cbb_idlaptg);
            this.panel1.Controls.Add(this.txb_tongtientg);
            this.panel1.Controls.Add(this.txb_cmnd);
            this.panel1.Controls.Add(this.txb_idhoadontg);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(892, 180);
            this.panel1.TabIndex = 0;
            // 
            // dtp_ngaybantg
            // 
            this.dtp_ngaybantg.CustomFormat = "dd/MM/yyyy";
            this.dtp_ngaybantg.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaybantg.Location = new System.Drawing.Point(407, 144);
            this.dtp_ngaybantg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_ngaybantg.Name = "dtp_ngaybantg";
            this.dtp_ngaybantg.ShowUpDown = true;
            this.dtp_ngaybantg.Size = new System.Drawing.Size(148, 20);
            this.dtp_ngaybantg.TabIndex = 26;
            // 
            // txb_thanhtoantrc
            // 
            this.txb_thanhtoantrc.Location = new System.Drawing.Point(707, 144);
            this.txb_thanhtoantrc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_thanhtoantrc.Name = "txb_thanhtoantrc";
            this.txb_thanhtoantrc.Size = new System.Drawing.Size(148, 20);
            this.txb_thanhtoantrc.TabIndex = 24;
            // 
            // cbb_hantg
            // 
            this.cbb_hantg.FormattingEnabled = true;
            this.cbb_hantg.Items.AddRange(new object[] {
            "4",
            "8",
            "12"});
            this.cbb_hantg.Location = new System.Drawing.Point(704, 16);
            this.cbb_hantg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_hantg.Name = "cbb_hantg";
            this.cbb_hantg.Size = new System.Drawing.Size(148, 21);
            this.cbb_hantg.TabIndex = 23;
            // 
            // cbb_idkh
            // 
            this.cbb_idkh.FormattingEnabled = true;
            this.cbb_idkh.Location = new System.Drawing.Point(407, 16);
            this.cbb_idkh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_idkh.Name = "cbb_idkh";
            this.cbb_idkh.Size = new System.Drawing.Size(151, 21);
            this.cbb_idkh.TabIndex = 22;
            // 
            // cbb_idnv
            // 
            this.cbb_idnv.FormattingEnabled = true;
            this.cbb_idnv.Location = new System.Drawing.Point(116, 142);
            this.cbb_idnv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_idnv.Name = "cbb_idnv";
            this.cbb_idnv.Size = new System.Drawing.Size(151, 21);
            this.cbb_idnv.TabIndex = 21;
            // 
            // cbb_idlaptg
            // 
            this.cbb_idlaptg.FormattingEnabled = true;
            this.cbb_idlaptg.Location = new System.Drawing.Point(116, 79);
            this.cbb_idlaptg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_idlaptg.Name = "cbb_idlaptg";
            this.cbb_idlaptg.Size = new System.Drawing.Size(151, 21);
            this.cbb_idlaptg.TabIndex = 20;
            this.cbb_idlaptg.SelectedIndexChanged += new System.EventHandler(this.cbb_idlaptg_SelectedIndexChanged);
            // 
            // txb_tongtientg
            // 
            this.txb_tongtientg.Location = new System.Drawing.Point(704, 79);
            this.txb_tongtientg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_tongtientg.Name = "txb_tongtientg";
            this.txb_tongtientg.Size = new System.Drawing.Size(151, 20);
            this.txb_tongtientg.TabIndex = 19;
            // 
            // txb_cmnd
            // 
            this.txb_cmnd.Location = new System.Drawing.Point(407, 80);
            this.txb_cmnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_cmnd.Name = "txb_cmnd";
            this.txb_cmnd.Size = new System.Drawing.Size(151, 20);
            this.txb_cmnd.TabIndex = 16;
            // 
            // txb_idhoadontg
            // 
            this.txb_idhoadontg.Location = new System.Drawing.Point(116, 19);
            this.txb_idhoadontg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_idhoadontg.Name = "txb_idhoadontg";
            this.txb_idhoadontg.Size = new System.Drawing.Size(151, 20);
            this.txb_idhoadontg.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(602, 142);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Thanh toán trc:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(602, 19);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Thời hạn trả góp:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(304, 142);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Ngày bán:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(602, 81);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Tổng tiền:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(304, 81);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CMND:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 19);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã laptop:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn trả góp:";
            // 
            // frmHoaDonTraGop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 559);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHoaDonTraGop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa Đơn Trả Góp";
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
        private System.Windows.Forms.TextBox txb_cmnd;
        private System.Windows.Forms.TextBox txb_idhoadontg;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_ngaybantg;
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