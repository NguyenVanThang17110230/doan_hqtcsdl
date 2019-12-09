namespace QLTiemLaptop
{
    partial class frmNhomLap
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
            this.dtgv_nhomlap = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.txb_ten = new System.Windows.Forms.TextBox();
            this.txb_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_nhomlap)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgv_nhomlap
            // 
            this.dtgv_nhomlap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_nhomlap.Location = new System.Drawing.Point(9, 190);
            this.dtgv_nhomlap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtgv_nhomlap.Name = "dtgv_nhomlap";
            this.dtgv_nhomlap.RowHeadersWidth = 51;
            this.dtgv_nhomlap.RowTemplate.Height = 24;
            this.dtgv_nhomlap.Size = new System.Drawing.Size(364, 188);
            this.dtgv_nhomlap.TabIndex = 0;
            this.dtgv_nhomlap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_nhomlap_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã nhóm lap:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên thể loại:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txb_ten);
            this.panel1.Controls.Add(this.txb_id);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(9, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(365, 174);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_add);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Location = new System.Drawing.Point(248, 6);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 160);
            this.panel2.TabIndex = 10;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(13, 87);
            this.btn_edit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(84, 28);
            this.btn_edit.TabIndex = 9;
            this.btn_edit.Text = "Sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(13, 127);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(84, 28);
            this.btn_delete.TabIndex = 8;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(13, 46);
            this.btn_add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(84, 28);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "Thêm";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(13, 6);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(84, 28);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Làm mới";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // txb_ten
            // 
            this.txb_ten.Location = new System.Drawing.Point(88, 124);
            this.txb_ten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_ten.Name = "txb_ten";
            this.txb_ten.Size = new System.Drawing.Size(157, 23);
            this.txb_ten.TabIndex = 5;
            // 
            // txb_id
            // 
            this.txb_id.Location = new System.Drawing.Point(87, 72);
            this.txb_id.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txb_id.Name = "txb_id";
            this.txb_id.Size = new System.Drawing.Size(157, 23);
            this.txb_id.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(19, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "THÔNG TIN NHÓM LAP";
            // 
            // frmNhomLap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 388);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgv_nhomlap);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNhomLap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhóm Lap";
            this.Load += new System.EventHandler(this.frmNhomLap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_nhomlap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgv_nhomlap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox txb_ten;
        private System.Windows.Forms.TextBox txb_id;
        private System.Windows.Forms.Label label3;
    }
}