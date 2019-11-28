using QLLaptop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTiemLaptop
{
    public partial class frmHoaDonNhap : Form
    {
        string PhanQuyen="";
        public frmHoaDonNhap()
        {
            InitializeComponent();
            Load_data();
        }
        public frmHoaDonNhap(string PhanQuyen)
        {
            InitializeComponent();
            this.PhanQuyen = PhanQuyen;
        }
        public void Load_data()
        {
            string str = "select * from HoaDonNhap";
            DataTable dt = connect.getDataTable(str);
            dtgv_hoadonnhap.DataSource = dt;
            dtgv_hoadonnhap.AutoResizeColumns();
        }

        

        private void btn_clearnhap_Click(object sender, EventArgs e)
        {
            this.txb_idhoadonnhap.Clear();            
            this.txb_idnhanviennhap.Clear();
            this.txb_idnhacungcapnhap.Clear();
            this.txb_idlapnhap.Clear();
            cbb_tenlapnhap.Text = "";
            this.txb_soluongnhap.Clear();
            this.txb_ngaynhap.Clear();
            this.txb_dongianhap.Clear();
            this.txb_tongtiennhap.Clear();

        }

        private void btn_addnhap_Click(object sender, EventArgs e)
        {
            string them = @"exec dbo.uspInserthoadonnhap N'" + txb_idhoadonnhap.Text + "',N'" + txb_idnhacungcapnhap.Text + "',N'" + txb_idnhanviennhap.Text
                + "',N'" + txb_idlapnhap.Text + "',N'" + cbb_tenlapnhap.Text + "','" + txb_soluongnhap.Text +
                "','" + txb_ngaynhap.Text + "','" + txb_dongianhap.Text + "','" + txb_tongtiennhap.Text + "'";
            connect.executeQuery(them);
            Load_data();
               
        }

        private void btn_fixnhap_Click(object sender, EventArgs e)
        {
            string fix1 = @"exec dbo.uspFixhoadonnhap N'" + txb_idhoadonnhap.Text + "',N'" + txb_idnhanviennhap.Text + "',N'" + txb_idnhacungcapnhap.Text
                + "',N'" + txb_idlapnhap.Text + "',N'" + cbb_tenlapnhap.Text + "','" + txb_soluongnhap.Text +
                "','" + txb_ngaynhap.Text + "','" + txb_dongianhap.Text + "','" + txb_tongtiennhap.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn sửa :" + txb_idhoadonnhap.Text,
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    connect.executeQuery(fix1);
                    MessageBox.Show("Sửa thành công!!");
                    Load_data();
                    this.txb_idhoadonnhap.Clear();
                    this.txb_idnhacungcapnhap.Clear();
                    this.txb_idnhanviennhap.Clear();
                    this.txb_idlapnhap.Clear();
                    cbb_tenlapnhap.Text = "";
                    this.txb_soluongnhap.Clear();
                    this.txb_ngaynhap.Clear();
                    this.txb_dongianhap.Clear();
                    this.txb_tongtiennhap.Clear();
                }
                catch (Exception) { }               
            }           
        }

        private void btn_deletnhap_Click(object sender, EventArgs e)
        {  
                string xoa = @"EXEC dbo.uspDeletehoadonnhap N'" + txb_idhoadonnhap.Text + "'";
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa sách :" + txb_idhoadonnhap.Text,
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        connect.executeQuery(xoa);
                        MessageBox.Show("Xóa thành công!!");
                        Load_data();
                        this.txb_idhoadonnhap.Clear();
                        this.txb_idnhacungcapnhap.Clear();
                        this.txb_idnhanviennhap.Clear();
                        this.txb_idlapnhap.Clear();
                        cbb_tenlapnhap.Text = "";
                        this.txb_soluongnhap.Clear();
                        this.txb_ngaynhap.Clear();
                        this.txb_dongianhap.Clear();
                        this.txb_tongtiennhap.Clear();
                    }
                    catch (Exception)
                    {
                    }
                }
                else if (dialog == DialogResult.No)
                {
                }
                  
        }

        private void btn_innhap_Click(object sender, EventArgs e)
        {

        }

        private void btn_exitnhap_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                Form main = new frmMain();
                main.ShowDialog();
                this.Close();
            }

        }

        private void dtgv_hoadonnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv_hoadonnhap.Rows[e.RowIndex];
                txb_idhoadonnhap.Text = row.Cells[0].Value.ToString();
                txb_idnhanviennhap.Text = row.Cells[1].Value.ToString();
                txb_idnhacungcapnhap.Text = row.Cells[2].Value.ToString();               
                txb_idlapnhap.Text = row.Cells[3].Value.ToString();
                cbb_tenlapnhap.Text = row.Cells[4].Value.ToString();
                txb_soluongnhap.Text = row.Cells[5].Value.ToString();
                txb_ngaynhap.Text = row.Cells[6].Value.ToString();
                txb_dongianhap.Text = row.Cells[7].Value.ToString();
                txb_tongtiennhap.Text = row.Cells[8].Value.ToString();
            }
            catch (Exception) { }
        }
    }
}
