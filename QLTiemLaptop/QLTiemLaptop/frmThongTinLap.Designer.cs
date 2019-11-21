namespace QLTiemLaptop
{
    partial class frmThongTinLap
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_clearttl = new System.Windows.Forms.Button();
            this.btn_inttl = new System.Windows.Forms.Button();
            this.btn_addttl = new System.Windows.Forms.Button();
            this.btn_deletttn = new System.Windows.Forms.Button();
            this.btn_fixttl = new System.Windows.Forms.Button();
            this.dtgv_thongtinlap = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txb_thongtin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.cbb_tennhacc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txb_dongiaa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txb_soluongg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_idnhacc = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txb_tenlapp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txb_idlapp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongtinlap)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.dtgv_thongtinlap);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1134, 573);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin laptop";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btn_clearttl);
            this.panel5.Controls.Add(this.btn_inttl);
            this.panel5.Controls.Add(this.btn_addttl);
            this.panel5.Controls.Add(this.btn_deletttn);
            this.panel5.Controls.Add(this.btn_fixttl);
            this.panel5.Location = new System.Drawing.Point(6, 267);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1120, 47);
            this.panel5.TabIndex = 1;
            // 
            // btn_clearttl
            // 
            this.btn_clearttl.Location = new System.Drawing.Point(11, 3);
            this.btn_clearttl.Name = "btn_clearttl";
            this.btn_clearttl.Size = new System.Drawing.Size(164, 39);
            this.btn_clearttl.TabIndex = 2;
            this.btn_clearttl.Text = "Làm mới";
            this.btn_clearttl.UseVisualStyleBackColor = true;
            this.btn_clearttl.Click += new System.EventHandler(this.btn_clearttl_Click);
            // 
            // btn_inttl
            // 
            this.btn_inttl.Location = new System.Drawing.Point(938, 3);
            this.btn_inttl.Name = "btn_inttl";
            this.btn_inttl.Size = new System.Drawing.Size(163, 39);
            this.btn_inttl.TabIndex = 6;
            this.btn_inttl.Text = "In";
            this.btn_inttl.UseVisualStyleBackColor = true;
            this.btn_inttl.Click += new System.EventHandler(this.btn_inttl_Click);
            // 
            // btn_addttl
            // 
            this.btn_addttl.Location = new System.Drawing.Point(244, 3);
            this.btn_addttl.Name = "btn_addttl";
            this.btn_addttl.Size = new System.Drawing.Size(163, 39);
            this.btn_addttl.TabIndex = 3;
            this.btn_addttl.Text = "Thêm";
            this.btn_addttl.UseVisualStyleBackColor = true;
            this.btn_addttl.Click += new System.EventHandler(this.btn_addttl_Click);
            // 
            // btn_deletttn
            // 
            this.btn_deletttn.Location = new System.Drawing.Point(705, 3);
            this.btn_deletttn.Name = "btn_deletttn";
            this.btn_deletttn.Size = new System.Drawing.Size(163, 39);
            this.btn_deletttn.TabIndex = 5;
            this.btn_deletttn.Text = "Xóa";
            this.btn_deletttn.UseVisualStyleBackColor = true;
            this.btn_deletttn.Click += new System.EventHandler(this.btn_deletttn_Click);
            // 
            // btn_fixttl
            // 
            this.btn_fixttl.Location = new System.Drawing.Point(474, 3);
            this.btn_fixttl.Name = "btn_fixttl";
            this.btn_fixttl.Size = new System.Drawing.Size(163, 39);
            this.btn_fixttl.TabIndex = 4;
            this.btn_fixttl.Text = "Sửa";
            this.btn_fixttl.UseVisualStyleBackColor = true;
            this.btn_fixttl.Click += new System.EventHandler(this.btn_fixttl_Click);
            // 
            // dtgv_thongtinlap
            // 
            this.dtgv_thongtinlap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_thongtinlap.Location = new System.Drawing.Point(6, 320);
            this.dtgv_thongtinlap.Name = "dtgv_thongtinlap";
            this.dtgv_thongtinlap.RowHeadersWidth = 51;
            this.dtgv_thongtinlap.RowTemplate.Height = 24;
            this.dtgv_thongtinlap.Size = new System.Drawing.Size(1120, 247);
            this.dtgv_thongtinlap.TabIndex = 0;
            this.dtgv_thongtinlap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_thongtinlap_CellClick);
            this.dtgv_thongtinlap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_thongtinlap_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(6, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 228);
            this.panel1.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.txb_thongtin);
            this.panel9.Controls.Add(this.label7);
            this.panel9.Location = new System.Drawing.Point(11, 162);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(954, 49);
            this.panel9.TabIndex = 7;
            // 
            // txb_thongtin
            // 
            this.txb_thongtin.Location = new System.Drawing.Point(94, 11);
            this.txb_thongtin.Multiline = true;
            this.txb_thongtin.Name = "txb_thongtin";
            this.txb_thongtin.Size = new System.Drawing.Size(842, 30);
            this.txb_thongtin.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(3, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thông tin";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.cbb_tennhacc);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(341, 88);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 55);
            this.panel6.TabIndex = 4;
            // 
            // cbb_tennhacc
            // 
            this.cbb_tennhacc.FormattingEnabled = true;
            this.cbb_tennhacc.Location = new System.Drawing.Point(144, 13);
            this.cbb_tennhacc.Name = "cbb_tennhacc";
            this.cbb_tennhacc.Size = new System.Drawing.Size(151, 24);
            this.cbb_tennhacc.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(9, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên nhà cung cấp";
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.txb_dongiaa);
            this.panel8.Controls.Add(this.label6);
            this.panel8.Location = new System.Drawing.Point(672, 89);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(294, 54);
            this.panel8.TabIndex = 6;
            // 
            // txb_dongiaa
            // 
            this.txb_dongiaa.Location = new System.Drawing.Point(113, 12);
            this.txb_dongiaa.Name = "txb_dongiaa";
            this.txb_dongiaa.Size = new System.Drawing.Size(163, 22);
            this.txb_dongiaa.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Đơn giá";
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.txb_soluongg);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(672, 15);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(294, 51);
            this.panel7.TabIndex = 5;
            // 
            // txb_soluongg
            // 
            this.txb_soluongg.Location = new System.Drawing.Point(113, 16);
            this.txb_soluongg.Name = "txb_soluongg";
            this.txb_soluongg.Size = new System.Drawing.Size(163, 22);
            this.txb_soluongg.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(12, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số lượng";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.cbb_idnhacc);
            this.panel4.Location = new System.Drawing.Point(341, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 51);
            this.panel4.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Location = new System.Drawing.Point(9, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã nhà cung cấp";
            // 
            // cbb_idnhacc
            // 
            this.cbb_idnhacc.FormattingEnabled = true;
            this.cbb_idnhacc.Location = new System.Drawing.Point(144, 12);
            this.cbb_idnhacc.Name = "cbb_idnhacc";
            this.cbb_idnhacc.Size = new System.Drawing.Size(153, 24);
            this.cbb_idnhacc.TabIndex = 0;
            this.cbb_idnhacc.SelectedIndexChanged += new System.EventHandler(this.cbb_idnhacc_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txb_tenlapp);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(12, 88);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 53);
            this.panel3.TabIndex = 2;
            // 
            // txb_tenlapp
            // 
            this.txb_tenlapp.Location = new System.Drawing.Point(116, 11);
            this.txb_tenlapp.Name = "txb_tenlapp";
            this.txb_tenlapp.Size = new System.Drawing.Size(170, 22);
            this.txb_tenlapp.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên laptop";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txb_idlapp);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 53);
            this.panel2.TabIndex = 1;
            // 
            // txb_idlapp
            // 
            this.txb_idlapp.Location = new System.Drawing.Point(116, 12);
            this.txb_idlapp.Name = "txb_idlapp";
            this.txb_idlapp.Size = new System.Drawing.Size(170, 22);
            this.txb_idlapp.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã laptop";
            // 
            // frmThongTinLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 597);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThongTinLap";
            this.Text = "ThongTinLap";
            this.Load += new System.EventHandler(this.frmThongTinLap_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongtinlap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgv_thongtinlap;
        private System.Windows.Forms.ComboBox cbb_idnhacc;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ComboBox cbb_tennhacc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_thongtin;
        private System.Windows.Forms.TextBox txb_dongiaa;
        private System.Windows.Forms.TextBox txb_soluongg;
        private System.Windows.Forms.TextBox txb_tenlapp;
        private System.Windows.Forms.TextBox txb_idlapp;
        private System.Windows.Forms.Button btn_clearttl;
        private System.Windows.Forms.Button btn_addttl;
        private System.Windows.Forms.Button btn_deletttn;
        private System.Windows.Forms.Button btn_fixttl;
        private System.Windows.Forms.Button btn_inttl;
    }
}