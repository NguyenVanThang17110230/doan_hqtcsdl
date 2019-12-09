namespace QLTiemLaptop
{
    partial class frmThongKeHoaDonNhap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgv_thongkenhap = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txb_tongtien = new System.Windows.Forms.TextBox();
            this.txb_month = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongkenhap)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtgv_thongkenhap);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 346);
            this.panel1.TabIndex = 0;
            // 
            // dtgv_thongkenhap
            // 
            this.dtgv_thongkenhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_thongkenhap.Location = new System.Drawing.Point(7, 98);
            this.dtgv_thongkenhap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgv_thongkenhap.Name = "dtgv_thongkenhap";
            this.dtgv_thongkenhap.RowHeadersWidth = 51;
            this.dtgv_thongkenhap.RowTemplate.Height = 24;
            this.dtgv_thongkenhap.Size = new System.Drawing.Size(462, 236);
            this.dtgv_thongkenhap.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txb_tongtien);
            this.panel2.Controls.Add(this.txb_month);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(7, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(462, 39);
            this.panel2.TabIndex = 1;
            // 
            // txb_tongtien
            // 
            this.txb_tongtien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_tongtien.Location = new System.Drawing.Point(326, 7);
            this.txb_tongtien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_tongtien.Name = "txb_tongtien";
            this.txb_tongtien.Size = new System.Drawing.Size(124, 23);
            this.txb_tongtien.TabIndex = 3;
            // 
            // txb_month
            // 
            this.txb_month.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_month.Location = new System.Drawing.Point(170, 6);
            this.txb_month.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_month.Name = "txb_month";
            this.txb_month.Size = new System.Drawing.Size(65, 23);
            this.txb_month.TabIndex = 2;
            this.txb_month.TextChanged += new System.EventHandler(this.txb_month_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(248, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tổng tiền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thời điểm muốn thống kê:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(88, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ HÓA ĐƠN NHẬP";
            // 
            // frmThongKeHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 366);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmThongKeHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Hóa Đơn Nhập";
            this.Load += new System.EventHandler(this.frmThongKeHoaDonNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongkenhap)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_thongkenhap;
        private System.Windows.Forms.TextBox txb_tongtien;
        private System.Windows.Forms.TextBox txb_month;
        private System.Windows.Forms.Label label3;
    }
}