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
        public frmHoaDonNhap()
        {
            InitializeComponent();
            this.Load_data();
            this.Load_cbb_idnv();
            this.Load_cbb_ncc();
            this.cbb_nhanviennhap.SelectedIndex = -1;
            this.cbb_ncc.SelectedIndex = -1;            
        }
        public void Load_data()
        {
            string str = @"exec dbo.uspLayhoadonnhap";
            DataTable dt = connect.getDataTable(str);
            dtgv_hoadonnhap.DataSource = dt;
            dtgv_hoadonnhap.Columns[0].HeaderText = "Mã hóa đơn nhập";
            dtgv_hoadonnhap.Columns[1].HeaderText = "Mã nhân viên";
            dtgv_hoadonnhap.Columns[2].HeaderText = "Mã nhà cc";
            dtgv_hoadonnhap.Columns[3].HeaderText = "Mã laptop";
            dtgv_hoadonnhap.Columns[4].HeaderText = "Tên laptop";
            dtgv_hoadonnhap.Columns[5].HeaderText = "Số lượng";
            dtgv_hoadonnhap.Columns[6].HeaderText = "Ngày bán";
            dtgv_hoadonnhap.Columns[7].HeaderText = "Đơn giá ";
            dtgv_hoadonnhap.Columns[8].HeaderText = "Tổng tiền";
            dtgv_hoadonnhap.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgv_hoadonnhap.Columns[7].DefaultCellStyle.Format = "N0";
            dtgv_hoadonnhap.Columns[8].DefaultCellStyle.Format = "N0";
        }
        public void Load_cbb_idnv()
        {
            string nv = @"exec dbo.uspLaynhanvien";
            cbb_nhanviennhap.DisplayMember = "TenNhanVien";
            cbb_nhanviennhap.ValueMember = "IDNhanVien";
            cbb_nhanviennhap.DataSource = connect.getDataTable(nv);
        }
        public void Load_cbb_ncc()
        {
            string ncc = @"exec dbo.uspLaynhacc";
            cbb_ncc.DisplayMember = "TenNhaCC";
            cbb_ncc.ValueMember = "IDNhaCC";
            cbb_ncc.DataSource = connect.getDataTable(ncc);
        }
        private void btn_clearnhap_Click(object sender, EventArgs e)
        {
            this.txb_idhoadonnhap.Clear();
            this.cbb_ncc.Text = "";
            this.cbb_nhanviennhap.Text = "";
            this.txb_idlapnhap.Clear();
            this.txb_tenlap.Clear();
            this.txb_soluongnhap.Clear();
            this.txb_dongianhap.Clear();
            this.txb_tongtiennhap.Clear();

        }
        private void btn_addnhap_Click(object sender, EventArgs e)
        {
            try
            {
                string them = @"exec dbo.uspInserthoadonnhap N'" + txb_idhoadonnhap.Text + "',N'" + cbb_ncc.SelectedValue.ToString() + "',N'" + cbb_nhanviennhap.SelectedValue.ToString()
                + "',N'" + txb_idlapnhap.Text + "',N'" + txb_tenlap.Text + "','" + txb_soluongnhap.Text +
                "','" + dtp_ngaynhap.Text + "','" + txb_dongianhap.Text + "','" + txb_tongtiennhap.Text + "'";
                connect.executeQuery(them);
                Load_data();
            }
            catch(Exception)
            {
                MessageBox.Show("Nhập sai rồi!!!");
            }
            
               
        }

        private void btn_fixnhap_Click(object sender, EventArgs e)
        {
            try
            {
                string fix1 = @"exec dbo.uspFixhoadonnhap N'" + txb_idhoadonnhap.Text + "',N'" + cbb_ncc.SelectedValue.ToString() + "',N'" + cbb_nhanviennhap.SelectedValue.ToString()
                + "',N'" + txb_idlapnhap.Text + "',N'" + txb_tenlap.Text + "','" + txb_soluongnhap.Text +
                "','" + dtp_ngaynhap.Text + "','" + txb_dongianhap.Text + "','" + txb_tongtiennhap.Text + "'";
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn sửa :" + txb_idhoadonnhap.Text,
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        connect.executeQuery(fix1);
                        Load_data();
                    }
                    catch (Exception) { }
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Nhập sai rồi!!!");
            }
             
        }

        private void btn_deletnhap_Click(object sender, EventArgs e)
        {
            try
            {
                string xoa = @"EXEC dbo.uspDeletehoadonnhap N'" + txb_idhoadonnhap.Text + "'";
                DialogResult dialog = MessageBox.Show("Bạn có muốn xóa sách :" + txb_idhoadonnhap.Text,
                    "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        connect.executeQuery(xoa);
                        Load_data();
                        this.txb_idhoadonnhap.Clear();
                        this.cbb_ncc.Text = "";
                        this.cbb_nhanviennhap.Text = "";
                        this.txb_idlapnhap.Clear();
                        this.txb_tenlap.Clear();
                        this.txb_soluongnhap.Clear();
                        this.txb_dongianhap.Clear();
                        this.txb_tongtiennhap.Clear();
                    }
                    catch (Exception)
                    {
                    }
                }               
            }
            catch (Exception) { MessageBox.Show("Nhập sai!!!"); }                                  
        }
       
        private void btn_exitnhap_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void dtgv_hoadonnhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv_hoadonnhap.Rows[e.RowIndex];
                txb_idhoadonnhap.Text = row.Cells[0].Value.ToString();
                cbb_nhanviennhap.Text = row.Cells[1].Value.ToString();
                cbb_ncc.Text = row.Cells[2].Value.ToString();               
                txb_idlapnhap.Text = row.Cells[3].Value.ToString();
                txb_tenlap.Text = row.Cells[4].Value.ToString();
                txb_soluongnhap.Text = row.Cells[5].Value.ToString();
                dtp_ngaynhap.Text = row.Cells[6].Value.ToString();
                txb_dongianhap.Text = row.Cells[7].Value.ToString();
                txb_tongtiennhap.Text = row.Cells[8].Value.ToString();
            }
            catch (Exception) { }
        }

        private void txb_soluongnhap_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txb_soluongnhap.Text == "" && txb_dongianhap.Text == "")
                {
                    txb_tongtiennhap.Text = "";
                }
                else
                {
                    string tongtien = @"exec dbo.uspLaytongtienhdn '" + txb_soluongnhap.Text + "','" + txb_dongianhap.Text + "'";
                    DataTable dtt = connect.getDataTable(tongtien);
                    txb_tongtiennhap.Text = dtt.Rows[0][0].ToString();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Nhập sai!!!");
            }
            
            
        }
    }
}
