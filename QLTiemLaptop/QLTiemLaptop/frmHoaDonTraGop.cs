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
using System.Data;
using System.Data.SqlClient;

namespace QLTiemLaptop
{
    public partial class frmHoaDonTraGop : Form
    {
        public frmHoaDonTraGop()
        {
            InitializeComponent();
        }

        private void frmHoaDonTraGop_Load(object sender, EventArgs e)
        {
            Load_datatg();
            Load_cbb_idlap();
            Load_cbb_idnv();
            Load_cbb_idkh();
        }
        public void Load_datatg()
        {
            string data = "select * from PhieuTraGop";
            DataTable dt = connect.getDataTable(data);
            dtgv_tragop.DataSource = dt;
        }
        public void Load_cbb_idlap()
        {
            string idlap = "select * from ThongTinLap";
            cbb_idlaptg.DisplayMember = "TenLap";
            cbb_idlaptg.ValueMember = "IDLap";
            cbb_idlaptg.DataSource = connect.getDataTable(idlap);
            cbb_idlaptg.SelectedIndex = -1;
        }
        public void Load_cbb_idnv()
        {
            string idnv = "select * from NhanVien";
            cbb_idnv.DisplayMember = "TenNhanVien";
            cbb_idnv.ValueMember = "IDNhanVien";
            cbb_idnv.DataSource = connect.getDataTable(idnv);
            cbb_idnv.SelectedIndex = -1;
        }
        public void Load_cbb_idkh()
        {
            string idkh = "select * from KhachHang";
            cbb_idkh.DisplayMember = "TenKhachHang";
            cbb_idkh.ValueMember = "IDKhachHang";
            cbb_idkh.DataSource = connect.getDataTable(idkh);
            cbb_idkh.SelectedIndex = -1;
        }
        public void Load_cbb_hantg()
        {

        }
        private void dtgv_tragop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv_tragop.Rows[e.RowIndex];
                txb_idhoadontg.Text = row.Cells[0].Value.ToString();
                cbb_idlaptg.Text = row.Cells[1].Value.ToString();
                cbb_idnv.Text = row.Cells[2].Value.ToString();
                cbb_idkh.Text = row.Cells[3].Value.ToString();
                txb_cmnd.Text = row.Cells[4].Value.ToString();                
                txb_tongtientg.Text = row.Cells[7].Value.ToString();
                dtp_ngaybantg.Text = row.Cells[5].Value.ToString();
                cbb_hantg.Text = row.Cells[6].Value.ToString();
                txb_thanhtoantrc.Text = row.Cells[8].Value.ToString();                
            }
            catch (Exception)
            {
                MessageBox.Show("Không laod được dữ liệu lên!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbb_idlaptg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbb_idlaptg.Text == "")
                {
                    txb_tongtientg.Text = "";
                }
                else
                {
                    string dongia = "select DonGia from ThongTinLap where TenLap=N'" + cbb_idlaptg.Text + "'";
                    DataTable dt = connect.getDataTable(dongia);
                    txb_tongtientg.Text = dt.Rows[0][0].ToString();
                }
            }
            catch (Exception) { MessageBox.Show("lỗi"); }            
            
        }
       
        private void btn_cleartg_Click(object sender, EventArgs e)
        {
            this.txb_idhoadontg.Text = "";
            this.cbb_idlaptg.Text = "";
            this.cbb_idnv.Text = "";
            this.cbb_idkh.Text = "";
            this.txb_cmnd.Text = "";
            this.dtp_ngaybantg.Text = "";
            this.cbb_hantg.Text = "";
            this.txb_tongtientg.Text = "";           
            this.txb_thanhtoantrc.Text = "";
            
        }

        private void btn_addtg_Click(object sender, EventArgs e)
        {
            string add = @"exec dbo.uspInserthoadontg N'" + txb_idhoadontg.Text + "',N'" + cbb_idlaptg.SelectedValue.ToString()
                + "',N'" + cbb_idnv.SelectedValue.ToString() + "',N'" + cbb_idkh.SelectedValue.ToString() + "','" + txb_cmnd.Text
                + "','" + dtp_ngaybantg.Text + "','" + cbb_hantg.Text + "','" + txb_tongtientg.Text + "','" + txb_thanhtoantrc.Text
                + "','" + "" + "','" + "" + "'";
            connect.executeQuery(add);
            Load_datatg();
        }

        private void btn_fixtg_Click(object sender, EventArgs e)
        {
            string fix = @"exec dbo.uspFixhoadontg N'" + txb_idhoadontg.Text + "',N'" + cbb_idlaptg.SelectedValue.ToString()
                + "',N'" + cbb_idnv.SelectedValue.ToString() + "',N'" + cbb_idkh.SelectedValue.ToString() + "','" + txb_cmnd.Text
                + "','" + dtp_ngaybantg.Text + "','" + cbb_hantg.Text + "','" + txb_tongtientg.Text + "','" + txb_thanhtoantrc.Text
                + "','" + "" + "','" + "" + "'";
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn sửa hóa đơn", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    connect.executeQuery(fix);
                    Load_datatg();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không được!!!");
                }
            }
        }

        private void btn_deletetg_Click(object sender, EventArgs e)
        {
            string delete = @"exec dbo.uspDeletehoadontg N'" + txb_idhoadontg.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    connect.executeQuery(delete);
                    Load_datatg();
                    this.txb_idhoadontg.Text = "";
                    this.cbb_idlaptg.Text = "";
                    this.cbb_idnv.Text = "";
                    this.cbb_idkh.Text = "";
                    this.txb_cmnd.Text = "";
                    this.dtp_ngaybantg.Text = "";
                    this.cbb_hantg.Text = "";
                    this.txb_tongtientg.Text = "";
                    this.txb_thanhtoantrc.Text = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Không xóa được!!");
                }


            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {

        }
    }
}
