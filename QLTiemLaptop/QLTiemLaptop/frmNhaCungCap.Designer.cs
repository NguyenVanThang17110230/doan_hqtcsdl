namespace QLTiemLaptop
{
    partial class frmNhaCungCap
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
            this.dtgv_nhacungcap = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_exitncc = new System.Windows.Forms.Button();
            this.btn_deletencc = new System.Windows.Forms.Button();
            this.btn_clearncc = new System.Windows.Forms.Button();
            this.btn_fixncc = new System.Windows.Forms.Button();
            this.btn_addncc = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txb_sdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txb_tennhacungcap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txb_diachi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_nhacungccap = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_searchncc = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txb_searchname = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_nhacungcap)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_nhacungcap
            // 
            this.dtgv_nhacungcap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_nhacungcap.Location = new System.Drawing.Point(443, 65);
            this.dtgv_nhacungcap.Name = "dtgv_nhacungcap";
            this.dtgv_nhacungcap.RowHeadersWidth = 51;
            this.dtgv_nhacungcap.RowTemplate.Height = 24;
            this.dtgv_nhacungcap.Size = new System.Drawing.Size(565, 453);
            this.dtgv_nhacungcap.TabIndex = 0;
            this.dtgv_nhacungcap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_nhacungcap_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 506);
            this.panel1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btn_exitncc);
            this.panel6.Controls.Add(this.btn_deletencc);
            this.panel6.Controls.Add(this.btn_clearncc);
            this.panel6.Controls.Add(this.btn_fixncc);
            this.panel6.Controls.Add(this.btn_addncc);
            this.panel6.Location = new System.Drawing.Point(262, 102);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(140, 388);
            this.panel6.TabIndex = 5;
            // 
            // btn_exitncc
            // 
            this.btn_exitncc.Location = new System.Drawing.Point(16, 343);
            this.btn_exitncc.Name = "btn_exitncc";
            this.btn_exitncc.Size = new System.Drawing.Size(112, 31);
            this.btn_exitncc.TabIndex = 7;
            this.btn_exitncc.Text = "Thoát";
            this.btn_exitncc.UseVisualStyleBackColor = true;
            this.btn_exitncc.Click += new System.EventHandler(this.btn_exitncc_Click);
            // 
            // btn_deletencc
            // 
            this.btn_deletencc.Location = new System.Drawing.Point(16, 270);
            this.btn_deletencc.Name = "btn_deletencc";
            this.btn_deletencc.Size = new System.Drawing.Size(112, 32);
            this.btn_deletencc.TabIndex = 6;
            this.btn_deletencc.Text = "Xóa";
            this.btn_deletencc.UseVisualStyleBackColor = true;
            this.btn_deletencc.Click += new System.EventHandler(this.btn_deletencc_Click);
            // 
            // btn_clearncc
            // 
            this.btn_clearncc.Location = new System.Drawing.Point(16, 35);
            this.btn_clearncc.Name = "btn_clearncc";
            this.btn_clearncc.Size = new System.Drawing.Size(112, 32);
            this.btn_clearncc.TabIndex = 3;
            this.btn_clearncc.Text = "Làm mới";
            this.btn_clearncc.UseVisualStyleBackColor = true;
            this.btn_clearncc.Click += new System.EventHandler(this.btn_clearncc_Click);
            // 
            // btn_fixncc
            // 
            this.btn_fixncc.Location = new System.Drawing.Point(16, 189);
            this.btn_fixncc.Name = "btn_fixncc";
            this.btn_fixncc.Size = new System.Drawing.Size(112, 32);
            this.btn_fixncc.TabIndex = 5;
            this.btn_fixncc.Text = "Sửa ";
            this.btn_fixncc.UseVisualStyleBackColor = true;
            this.btn_fixncc.Click += new System.EventHandler(this.btn_fixncc_Click);
            // 
            // btn_addncc
            // 
            this.btn_addncc.Location = new System.Drawing.Point(16, 113);
            this.btn_addncc.Name = "btn_addncc";
            this.btn_addncc.Size = new System.Drawing.Size(112, 32);
            this.btn_addncc.TabIndex = 4;
            this.btn_addncc.Text = "Thêm";
            this.btn_addncc.UseVisualStyleBackColor = true;
            this.btn_addncc.Click += new System.EventHandler(this.btn_addncc_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(35, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(336, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "THÔNG TIN NHÀ CUNG CẤP";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.txb_sdt);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(13, 407);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(243, 83);
            this.panel5.TabIndex = 0;
            // 
            // txb_sdt
            // 
            this.txb_sdt.Location = new System.Drawing.Point(6, 47);
            this.txb_sdt.Name = "txb_sdt";
            this.txb_sdt.Size = new System.Drawing.Size(220, 22);
            this.txb_sdt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txb_tennhacungcap);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(13, 204);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(243, 81);
            this.panel3.TabIndex = 1;
            // 
            // txb_tennhacungcap
            // 
            this.txb_tennhacungcap.Location = new System.Drawing.Point(6, 45);
            this.txb_tennhacungcap.Name = "txb_tennhacungcap";
            this.txb_tennhacungcap.Size = new System.Drawing.Size(220, 22);
            this.txb_tennhacungcap.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên nhà cung cấp";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txb_diachi);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(13, 306);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(243, 83);
            this.panel4.TabIndex = 0;
            // 
            // txb_diachi
            // 
            this.txb_diachi.Location = new System.Drawing.Point(6, 49);
            this.txb_diachi.Name = "txb_diachi";
            this.txb_diachi.Size = new System.Drawing.Size(220, 22);
            this.txb_diachi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txb_nhacungccap);
            this.panel2.Location = new System.Drawing.Point(13, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 81);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhà cung cấp";
            // 
            // txb_nhacungccap
            // 
            this.txb_nhacungccap.Location = new System.Drawing.Point(6, 45);
            this.txb_nhacungccap.Name = "txb_nhacungccap";
            this.txb_nhacungccap.Size = new System.Drawing.Size(220, 22);
            this.txb_nhacungccap.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tìm kiếm:";
            // 
            // txb_searchncc
            // 
            this.txb_searchncc.Location = new System.Drawing.Point(96, 9);
            this.txb_searchncc.Name = "txb_searchncc";
            this.txb_searchncc.Size = new System.Drawing.Size(94, 22);
            this.txb_searchncc.TabIndex = 2;
            this.txb_searchncc.TextChanged += new System.EventHandler(this.txb_searchncc_TextChanged);
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.txb_searchname);
            this.panel7.Controls.Add(this.txb_searchncc);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Location = new System.Drawing.Point(443, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(565, 43);
            this.panel7.TabIndex = 3;
            // 
            // txb_searchname
            // 
            this.txb_searchname.Location = new System.Drawing.Point(207, 9);
            this.txb_searchname.Name = "txb_searchname";
            this.txb_searchname.Size = new System.Drawing.Size(334, 22);
            this.txb_searchname.TabIndex = 3;
            this.txb_searchname.TextChanged += new System.EventHandler(this.txb_searchname_TextChanged);
            // 
            // frmNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 530);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgv_nhacungcap);
            this.Name = "frmNhaCungCap";
            this.Text = "frmNhaCungCap";
            this.Load += new System.EventHandler(this.frmNhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_nhacungcap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgv_nhacungcap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txb_sdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txb_tennhacungcap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txb_diachi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_nhacungccap;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_clearncc;
        private System.Windows.Forms.Button btn_addncc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_exitncc;
        private System.Windows.Forms.Button btn_deletencc;
        private System.Windows.Forms.Button btn_fixncc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_searchncc;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txb_searchname;
    }
}