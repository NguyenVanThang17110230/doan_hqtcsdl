namespace QLTiemLaptop
{
    partial class frmThongKeHoaDonBan
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_tongtien = new System.Windows.Forms.TextBox();
            this.txb_month = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgv_thongkeban = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongkeban)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtgv_thongkeban);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(9, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 345);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txb_tongtien);
            this.panel2.Controls.Add(this.txb_month);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 51);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(454, 43);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng số tiền bán lap:";
            // 
            // txb_tongtien
            // 
            this.txb_tongtien.Location = new System.Drawing.Point(326, 11);
            this.txb_tongtien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_tongtien.Name = "txb_tongtien";
            this.txb_tongtien.Size = new System.Drawing.Size(124, 19);
            this.txb_tongtien.TabIndex = 4;
            // 
            // txb_month
            // 
            this.txb_month.Location = new System.Drawing.Point(142, 11);
            this.txb_month.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_month.Name = "txb_month";
            this.txb_month.Size = new System.Drawing.Size(55, 19);
            this.txb_month.TabIndex = 2;
            this.txb_month.TextChanged += new System.EventHandler(this.txb_month_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời điểm muốn thống kê:";
            // 
            // dtgv_thongkeban
            // 
            this.dtgv_thongkeban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_thongkeban.Location = new System.Drawing.Point(12, 105);
            this.dtgv_thongkeban.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgv_thongkeban.Name = "dtgv_thongkeban";
            this.dtgv_thongkeban.RowHeadersWidth = 51;
            this.dtgv_thongkeban.RowTemplate.Height = 24;
            this.dtgv_thongkeban.Size = new System.Drawing.Size(453, 229);
            this.dtgv_thongkeban.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(108, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ HÓA ĐƠN BÁN";
            // 
            // frmThongKeHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 366);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmThongKeHoaDonBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Hóa Đơn Bán";
            this.Load += new System.EventHandler(this.frmThongKeHoaDonBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongkeban)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgv_thongkeban;
        private System.Windows.Forms.TextBox txb_month;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_tongtien;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
    }
}