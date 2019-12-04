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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_month = new System.Windows.Forms.TextBox();
            this.dtgv_thongkeban = new System.Windows.Forms.DataGridView();
            this.txb_tongtien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongkeban)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dtgv_thongkeban);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 424);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(144, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ HÓA ĐƠN BÁN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời điểm muốn thống kê:";
            // 
            // txb_month
            // 
            this.txb_month.Location = new System.Drawing.Point(190, 13);
            this.txb_month.Name = "txb_month";
            this.txb_month.Size = new System.Drawing.Size(72, 22);
            this.txb_month.TabIndex = 2;
            this.txb_month.TextChanged += new System.EventHandler(this.txb_month_TextChanged);
            // 
            // dtgv_thongkeban
            // 
            this.dtgv_thongkeban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_thongkeban.Location = new System.Drawing.Point(16, 129);
            this.dtgv_thongkeban.Name = "dtgv_thongkeban";
            this.dtgv_thongkeban.RowHeadersWidth = 51;
            this.dtgv_thongkeban.RowTemplate.Height = 24;
            this.dtgv_thongkeban.Size = new System.Drawing.Size(604, 282);
            this.dtgv_thongkeban.TabIndex = 3;
            // 
            // txb_tongtien
            // 
            this.txb_tongtien.Location = new System.Drawing.Point(435, 13);
            this.txb_tongtien.Name = "txb_tongtien";
            this.txb_tongtien.Size = new System.Drawing.Size(164, 22);
            this.txb_tongtien.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng số tiền bán lap:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txb_tongtien);
            this.panel2.Controls.Add(this.txb_month);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(16, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(604, 53);
            this.panel2.TabIndex = 6;
            // 
            // frmThongKeHoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 451);
            this.Controls.Add(this.panel1);
            this.Name = "frmThongKeHoaDonBan";
            this.Text = "frmThongKeHoaDonBan";
            this.Load += new System.EventHandler(this.frmThongKeHoaDonBan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_thongkeban)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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