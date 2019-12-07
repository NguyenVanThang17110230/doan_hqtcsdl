using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLLaptop;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace QLTiemLaptop
{
    public partial class frmHoaDonBan : Form
    {
        
        public frmHoaDonBan()
        {
            InitializeComponent();                                 
        }
        //xử lý hóa đơn bán
        public void Load_Data()
        {
            string str = @"exec dbo.uspLayhoadonban";
            DataTable dt = connect.getDataTable(str);
            dtgv_hoadon.DataSource = dt;
            dtgv_hoadon.AutoResizeColumns();
            dtgv_hoadon.Columns[0].HeaderText = "Mã hóa đơn bán";
            dtgv_hoadon.Columns[1].HeaderText = "Mã laptop";
            dtgv_hoadon.Columns[2].HeaderText = "Mã khách hàng";
            dtgv_hoadon.Columns[3].HeaderText = "Mã nhân viên";
            dtgv_hoadon.Columns[4].HeaderText = "Số lượng";
            dtgv_hoadon.Columns[5].HeaderText = "Ngày bán";
            dtgv_hoadon.Columns[6].HeaderText = "Sdt";
            dtgv_hoadon.Columns[7].HeaderText = "Khuyến mãi";
            dtgv_hoadon.Columns[8].HeaderText = "Đơn giá";
            dtgv_hoadon.Columns[9].HeaderText = "Tổng tiền";
            dtgv_hoadon.Columns[8].DefaultCellStyle.Format = "N0";
            dtgv_hoadon.Columns[9].DefaultCellStyle.Format = "N0";
        }
        public void Load_cbb_idlap()
        {
            string idlap = @"exec dbo.uspLaythongtinlap";
            cbb_idlap.DisplayMember = "TenLap";
            cbb_idlap.ValueMember = "IDLap";
            cbb_idlap.DataSource = connect.getDataTable(idlap);
            cbb_idlap.SelectedIndex = -1;
        }
        public void Load_cbb_idkhach()
        {
            string khach = @"exec dbo.uspLaykhachhang";
            cbb_idkhach.DisplayMember = "TenKhachHang";
            cbb_idkhach.ValueMember = "IDKhachHang";
            cbb_idkhach.DataSource = connect.getDataTable(khach);
            cbb_idkhach.SelectedIndex = -1;
        }
        public void Load_cbb_idnv()
        {
            string nv = @"exec dbo.uspLaynhanvien";
            cbb_idnv.DisplayMember = "TenNhanVien";
            cbb_idnv.ValueMember = "IDNhanVien";
            cbb_idnv.DataSource = connect.getDataTable(nv);
            cbb_idnv.SelectedIndex = -1;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txb_idhoadon.Clear();
            this.cbb_idkhach.Text = "";
            this.cbb_idnv.Text = "";
            this.cbb_idlap.Text = "";
            this.txb_soluong.Clear();
            this.dtp_ngayban.Text = "";
            this.txb_sdt.Clear();
            this.txb_dongia.Clear();
            this.txb_tongtien.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                string them = @"exec dbo.uspInserthoadon N'" + txb_idhoadon.Text + "',N'" + cbb_idkhach.SelectedValue.ToString()
               + "',N'" + cbb_idnv.SelectedValue.ToString() + "',N'" + cbb_idlap.SelectedValue.ToString() + "','" + txb_soluong.Text +
               "','" + dtp_ngayban.Text + "',N'" + txb_sdt.Text + "',N'" + "" + "','" + txb_dongia.Text + "','" + txb_tongtien.Text + "'";
                connect.executeQuery(them);
                Load_Data();
            }
            catch(Exception) { MessageBox.Show("Nhập sai rồi!!!"); }
            
        }        
        private void btn_delete_Click(object sender, EventArgs e)
        {
            string xoa = @"EXEC dbo.uspDeleteHoadon N'" + txb_idhoadon.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa hóa đơn:" + txb_idhoadon.Text,
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    connect.executeQuery(xoa);                    
                    Load_Data();
                    this.txb_idhoadon.Clear();
                    this.cbb_idkhach.Text = "";
                    this.cbb_idnv.Text = "";
                    this.cbb_idlap.Text = "";
                    this.txb_soluong.Clear();
                    this.dtp_ngayban.Text = "";
                    this.txb_sdt.Clear();
                    this.txb_dongia.Clear();
                    this.txb_tongtien.Clear();
                }
                catch (Exception)
                {
                }
            }           
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            try 
            {
                string fix = @"exec dbo.uspFixHoadon N'" + txb_idhoadon.Text + "',N'" + cbb_idkhach.SelectedValue.ToString()
                + "',N'" + cbb_idnv.SelectedValue.ToString() + "',N'" + cbb_idlap.SelectedValue.ToString() + "','" + txb_soluong.Text +
                "','" + dtp_ngayban.Text + "',N'" + "" + "',N'" + txb_sdt.Text + "','" + txb_dongia.Text + "','" + txb_tongtien.Text + "'";
                connect.executeQuery(fix);
                Load_Data();
            }
            catch (Exception) { MessageBox.Show("Nhập sai rồi"); }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void dtgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv_hoadon.Rows[e.RowIndex];
                txb_idhoadon.Text = row.Cells[0].Value.ToString();
                cbb_idkhach.Text = row.Cells[2].Value.ToString();
                cbb_idnv.Text = row.Cells[3].Value.ToString();
                cbb_idlap.Text = row.Cells[1].Value.ToString();
                txb_soluong.Text = row.Cells[4].Value.ToString();
                dtp_ngayban.Text = row.Cells[5].Value.ToString();
                txb_sdt.Text = row.Cells[6].Value.ToString();
                txb_dongia.Text = row.Cells[8].Value.ToString();
                txb_tongtien.Text = row.Cells[9].Value.ToString();
            }
            catch (Exception) { }

        }

        private void frmHoaDonBan_Load(object sender, EventArgs e)
        {
            this.Load_Data();
            this.Load_cbb_idlap();
            this.Load_cbb_idkhach();
            this.Load_cbb_idnv();
        }

        private void cbb_idlap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbb_idlap.SelectedIndex==-1)
            {
                txb_dongia.Text = "";
            }
            else
            {
                string dongia = @"exec dbo.uspLaydongiahdb N'" + cbb_idlap.SelectedValue.ToString() + "'";
                DataTable dt = connect.getDataTable(dongia);
                txb_dongia.Text = dt.Rows[0][0].ToString();
            }

        }

        private void txb_soluong_TextChanged(object sender, EventArgs e)
        {
            if(txb_soluong.Text=="")
            {
                txb_tongtien.Text = "";
            }
            else
            {
                string tongtien = @"exec dbo.uspLaytongtienhdb '" + txb_soluong.Text + "',N'"+cbb_idlap.SelectedValue.ToString()+"'";
                DataTable dt2 = connect.getDataTable(tongtien);
                txb_tongtien.Text = dt2.Rows[0][0].ToString();

            }
        }
        private void cbb_idkhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_idkhach.SelectedIndex == -1)
            {
                txb_sdt.Text = "";
            }
            else
            {
                string sdt = @"exec dbo.uspLaysdthdb '" + cbb_idkhach.SelectedValue.ToString() + "'";
                DataTable dt3 = connect.getDataTable(sdt);
                txb_sdt.Text = dt3.Rows[0][0].ToString();
            }
        }
    }
}
