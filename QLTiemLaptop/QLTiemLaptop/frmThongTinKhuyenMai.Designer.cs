namespace QLTiemLaptop
{
    partial class frmThongTinKhuyenMai
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
            this.dtgv_thongtinkhuyenmai = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_deletettkm = new System.Windows.Forms.Button();
            this.btn_fixttkm = new System.Windows.Forms.Button();
            this.btn_addttkm = new System.Windows.Forms.Button();
            this.btn_clearttkm = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_thongtinkm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_tenlapkm = new System.Windows.Forms.TextBox();
            this.txb_idkhuyenmai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongtinkhuyenmai)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_thongtinkhuyenmai
            // 
            this.dtgv_thongtinkhuyenmai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_thongtinkhuyenmai.Location = new System.Drawing.Point(478, 23);
            this.dtgv_thongtinkhuyenmai.Name = "dtgv_thongtinkhuyenmai";
            this.dtgv_thongtinkhuyenmai.RowHeadersWidth = 51;
            this.dtgv_thongtinkhuyenmai.RowTemplate.Height = 24;
            this.dtgv_thongtinkhuyenmai.Size = new System.Drawing.Size(608, 441);
            this.dtgv_thongtinkhuyenmai.TabIndex = 0;
            this.dtgv_thongtinkhuyenmai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_thongtinkhuyenmai_CellClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(436, 441);
            this.panel1.TabIndex = 1;
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(344, 402);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btn_deletettkm);
            this.panel3.Controls.Add(this.btn_fixttkm);
            this.panel3.Controls.Add(this.btn_addttkm);
            this.panel3.Controls.Add(this.btn_clearttkm);
            this.panel3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(17, 304);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(402, 64);
            this.panel3.TabIndex = 10;
            // 
            // btn_deletettkm
            // 
            this.btn_deletettkm.Location = new System.Drawing.Point(316, 19);
            this.btn_deletettkm.Name = "btn_deletettkm";
            this.btn_deletettkm.Size = new System.Drawing.Size(75, 23);
            this.btn_deletettkm.TabIndex = 3;
            this.btn_deletettkm.Text = "Xóa";
            this.btn_deletettkm.UseVisualStyleBackColor = true;
            this.btn_deletettkm.Click += new System.EventHandler(this.btn_deletettkm_Click);
            // 
            // btn_fixttkm
            // 
            this.btn_fixttkm.Location = new System.Drawing.Point(213, 19);
            this.btn_fixttkm.Name = "btn_fixttkm";
            this.btn_fixttkm.Size = new System.Drawing.Size(75, 23);
            this.btn_fixttkm.TabIndex = 2;
            this.btn_fixttkm.Text = "Sửa ";
            this.btn_fixttkm.UseVisualStyleBackColor = true;
            this.btn_fixttkm.Click += new System.EventHandler(this.btn_fixttkm_Click);
            // 
            // btn_addttkm
            // 
            this.btn_addttkm.Location = new System.Drawing.Point(108, 19);
            this.btn_addttkm.Name = "btn_addttkm";
            this.btn_addttkm.Size = new System.Drawing.Size(75, 23);
            this.btn_addttkm.TabIndex = 1;
            this.btn_addttkm.Text = "Thêm";
            this.btn_addttkm.UseVisualStyleBackColor = true;
            this.btn_addttkm.Click += new System.EventHandler(this.btn_addttkm_Click);
            // 
            // btn_clearttkm
            // 
            this.btn_clearttkm.Location = new System.Drawing.Point(8, 19);
            this.btn_clearttkm.Name = "btn_clearttkm";
            this.btn_clearttkm.Size = new System.Drawing.Size(75, 23);
            this.btn_clearttkm.TabIndex = 0;
            this.btn_clearttkm.Text = "Làm mới";
            this.btn_clearttkm.UseVisualStyleBackColor = true;
            this.btn_clearttkm.Click += new System.EventHandler(this.btn_clearttkm_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txb_thongtinkm);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txb_tenlapkm);
            this.panel2.Controls.Add(this.txb_idkhuyenmai);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(17, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 203);
            this.panel2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khuyến mãi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã laptop";
            // 
            // txb_thongtinkm
            // 
            this.txb_thongtinkm.Location = new System.Drawing.Point(151, 149);
            this.txb_thongtinkm.Name = "txb_thongtinkm";
            this.txb_thongtinkm.Size = new System.Drawing.Size(224, 27);
            this.txb_thongtinkm.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Thông tin";
            // 
            // txb_tenlapkm
            // 
            this.txb_tenlapkm.Location = new System.Drawing.Point(151, 88);
            this.txb_tenlapkm.Name = "txb_tenlapkm";
            this.txb_tenlapkm.Size = new System.Drawing.Size(224, 27);
            this.txb_tenlapkm.TabIndex = 6;
            // 
            // txb_idkhuyenmai
            // 
            this.txb_idkhuyenmai.Location = new System.Drawing.Point(151, 26);
            this.txb_idkhuyenmai.Name = "txb_idkhuyenmai";
            this.txb_idkhuyenmai.Size = new System.Drawing.Size(224, 27);
            this.txb_idkhuyenmai.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(59, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN KHUYẾN MÃI";
            // 
            // frmThongTinKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgv_thongtinkhuyenmai);
            this.Name = "frmThongTinKhuyenMai";
            this.Text = "ThongTinKhuyenMai";
            this.Load += new System.EventHandler(this.frmThongTinKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongtinkhuyenmai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_thongtinkhuyenmai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_deletettkm;
        private System.Windows.Forms.Button btn_fixttkm;
        private System.Windows.Forms.Button btn_addttkm;
        private System.Windows.Forms.Button btn_clearttkm;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_thongtinkm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_tenlapkm;
        private System.Windows.Forms.TextBox txb_idkhuyenmai;
        private System.Windows.Forms.Label label1;
    }
}