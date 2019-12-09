namespace QLTiemLaptop
{
    partial class frmNhanVien
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
            this.panel10 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_clearnhanvien = new System.Windows.Forms.Button();
            this.btn_themnhanvien = new System.Windows.Forms.Button();
            this.btn_fixnhanvien = new System.Windows.Forms.Button();
            this.btn_xoanhanvien = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txb_sdtnhanvien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txb_diachinhanvien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dtp_ngaysinhnv = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txb_gioitinhnhanvien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txb_tennhanvien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txb_idnhanvien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_nhanvien = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbb_idchucvunv = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txb_searchname = new System.Windows.Forms.TextBox();
            this.txb_searchid = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_nhanvien)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.btn_exit);
            this.panel10.Controls.Add(this.btn_clearnhanvien);
            this.panel10.Controls.Add(this.btn_themnhanvien);
            this.panel10.Controls.Add(this.btn_fixnhanvien);
            this.panel10.Controls.Add(this.btn_xoanhanvien);
            this.panel10.Location = new System.Drawing.Point(127, 433);
            this.panel10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(596, 40);
            this.panel10.TabIndex = 2;
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(490, 7);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(95, 28);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_clearnhanvien
            // 
            this.btn_clearnhanvien.Location = new System.Drawing.Point(13, 7);
            this.btn_clearnhanvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_clearnhanvien.Name = "btn_clearnhanvien";
            this.btn_clearnhanvien.Size = new System.Drawing.Size(95, 28);
            this.btn_clearnhanvien.TabIndex = 7;
            this.btn_clearnhanvien.Text = "Làm mới";
            this.btn_clearnhanvien.UseVisualStyleBackColor = true;
            this.btn_clearnhanvien.Click += new System.EventHandler(this.btn_clearnhanvien_Click);
            // 
            // btn_themnhanvien
            // 
            this.btn_themnhanvien.Location = new System.Drawing.Point(134, 7);
            this.btn_themnhanvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_themnhanvien.Name = "btn_themnhanvien";
            this.btn_themnhanvien.Size = new System.Drawing.Size(96, 28);
            this.btn_themnhanvien.TabIndex = 8;
            this.btn_themnhanvien.Text = "Thêm";
            this.btn_themnhanvien.UseVisualStyleBackColor = true;
            this.btn_themnhanvien.Click += new System.EventHandler(this.btn_themnhanvien_Click);
            // 
            // btn_fixnhanvien
            // 
            this.btn_fixnhanvien.Location = new System.Drawing.Point(254, 7);
            this.btn_fixnhanvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_fixnhanvien.Name = "btn_fixnhanvien";
            this.btn_fixnhanvien.Size = new System.Drawing.Size(96, 28);
            this.btn_fixnhanvien.TabIndex = 9;
            this.btn_fixnhanvien.Text = "Sửa ";
            this.btn_fixnhanvien.UseVisualStyleBackColor = true;
            this.btn_fixnhanvien.Click += new System.EventHandler(this.btn_fixnhanvien_Click);
            // 
            // btn_xoanhanvien
            // 
            this.btn_xoanhanvien.Location = new System.Drawing.Point(376, 7);
            this.btn_xoanhanvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_xoanhanvien.Name = "btn_xoanhanvien";
            this.btn_xoanhanvien.Size = new System.Drawing.Size(95, 28);
            this.btn_xoanhanvien.TabIndex = 10;
            this.btn_xoanhanvien.Text = "Xóa";
            this.btn_xoanhanvien.UseVisualStyleBackColor = true;
            this.btn_xoanhanvien.Click += new System.EventHandler(this.btn_xoanhanvien_Click);
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.txb_sdtnhanvien);
            this.panel9.Controls.Add(this.label6);
            this.panel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(5)))));
            this.panel9.Location = new System.Drawing.Point(6, 411);
            this.panel9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(283, 39);
            this.panel9.TabIndex = 2;
            // 
            // txb_sdtnhanvien
            // 
            this.txb_sdtnhanvien.Location = new System.Drawing.Point(95, 9);
            this.txb_sdtnhanvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_sdtnhanvien.Name = "txb_sdtnhanvien";
            this.txb_sdtnhanvien.Size = new System.Drawing.Size(185, 20);
            this.txb_sdtnhanvien.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 8);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số điện thoại";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.txb_diachinhanvien);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(6, 345);
            this.panel8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(283, 40);
            this.panel8.TabIndex = 1;
            // 
            // txb_diachinhanvien
            // 
            this.txb_diachinhanvien.Location = new System.Drawing.Point(95, 10);
            this.txb_diachinhanvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_diachinhanvien.Name = "txb_diachinhanvien";
            this.txb_diachinhanvien.Size = new System.Drawing.Size(185, 20);
            this.txb_diachinhanvien.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.dtp_ngaysinhnv);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Location = new System.Drawing.Point(6, 275);
            this.panel7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(283, 39);
            this.panel7.TabIndex = 0;
            // 
            // dtp_ngaysinhnv
            // 
            this.dtp_ngaysinhnv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_ngaysinhnv.Location = new System.Drawing.Point(95, 9);
            this.dtp_ngaysinhnv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_ngaysinhnv.Name = "dtp_ngaysinhnv";
            this.dtp_ngaysinhnv.ShowUpDown = true;
            this.dtp_ngaysinhnv.Size = new System.Drawing.Size(184, 20);
            this.dtp_ngaysinhnv.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.txb_gioitinhnhanvien);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Location = new System.Drawing.Point(6, 214);
            this.panel6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(283, 34);
            this.panel6.TabIndex = 2;
            // 
            // txb_gioitinhnhanvien
            // 
            this.txb_gioitinhnhanvien.Location = new System.Drawing.Point(95, 8);
            this.txb_gioitinhnhanvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_gioitinhnhanvien.Name = "txb_gioitinhnhanvien";
            this.txb_gioitinhnhanvien.Size = new System.Drawing.Size(185, 20);
            this.txb_gioitinhnhanvien.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txb_tennhanvien);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Location = new System.Drawing.Point(6, 153);
            this.panel5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(283, 34);
            this.panel5.TabIndex = 1;
            // 
            // txb_tennhanvien
            // 
            this.txb_tennhanvien.Location = new System.Drawing.Point(95, 6);
            this.txb_tennhanvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_tennhanvien.Name = "txb_tennhanvien";
            this.txb_tennhanvien.Size = new System.Drawing.Size(185, 20);
            this.txb_tennhanvien.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhân viên";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txb_idnhanvien);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(6, 15);
            this.panel4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(283, 39);
            this.panel4.TabIndex = 0;
            // 
            // txb_idnhanvien
            // 
            this.txb_idnhanvien.Location = new System.Drawing.Point(95, 13);
            this.txb_idnhanvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_idnhanvien.Name = "txb_idnhanvien";
            this.txb_idnhanvien.Size = new System.Drawing.Size(185, 20);
            this.txb_idnhanvien.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // dtgv_nhanvien
            // 
            this.dtgv_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_nhanvien.Location = new System.Drawing.Point(6, 59);
            this.dtgv_nhanvien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgv_nhanvien.Name = "dtgv_nhanvien";
            this.dtgv_nhanvien.RowHeadersWidth = 51;
            this.dtgv_nhanvien.RowTemplate.Height = 24;
            this.dtgv_nhanvien.Size = new System.Drawing.Size(716, 369);
            this.dtgv_nhanvien.TabIndex = 0;
            this.dtgv_nhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_nhanvien_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Location = new System.Drawing.Point(727, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 464);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbb_idchucvunv);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(6, 85);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 39);
            this.panel2.TabIndex = 3;
            // 
            // cbb_idchucvunv
            // 
            this.cbb_idchucvunv.FormattingEnabled = true;
            this.cbb_idchucvunv.Location = new System.Drawing.Point(95, 11);
            this.cbb_idchucvunv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_idchucvunv.Name = "cbb_idchucvunv";
            this.cbb_idchucvunv.Size = new System.Drawing.Size(183, 21);
            this.cbb_idchucvunv.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã chức vụ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(30, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(288, 26);
            this.label8.TabIndex = 4;
            this.label8.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txb_searchname);
            this.panel3.Controls.Add(this.txb_searchid);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(366, 11);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(356, 43);
            this.panel3.TabIndex = 5;
            // 
            // txb_searchname
            // 
            this.txb_searchname.Location = new System.Drawing.Point(135, 13);
            this.txb_searchname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_searchname.Name = "txb_searchname";
            this.txb_searchname.Size = new System.Drawing.Size(212, 20);
            this.txb_searchname.TabIndex = 2;
            this.txb_searchname.TextChanged += new System.EventHandler(this.txb_searchname_TextChanged);
            // 
            // txb_searchid
            // 
            this.txb_searchid.Location = new System.Drawing.Point(64, 13);
            this.txb_searchid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_searchid.Name = "txb_searchid";
            this.txb_searchid.Size = new System.Drawing.Size(60, 20);
            this.txb_searchid.TabIndex = 1;
            this.txb_searchid.TextChanged += new System.EventHandler(this.txb_searchid_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tìm kiếm:";
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 483);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgv_nhanvien);
            this.Controls.Add(this.panel10);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            this.panel10.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_nhanvien)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txb_sdtnhanvien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txb_diachinhanvien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txb_gioitinhnhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txb_tennhanvien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txb_idnhanvien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_nhanvien;
        private System.Windows.Forms.Button btn_clearnhanvien;
        private System.Windows.Forms.Button btn_themnhanvien;
        private System.Windows.Forms.Button btn_fixnhanvien;
        private System.Windows.Forms.Button btn_xoanhanvien;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtp_ngaysinhnv;
        private System.Windows.Forms.ComboBox cbb_idchucvunv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txb_searchname;
        private System.Windows.Forms.TextBox txb_searchid;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_exit;
    }
}