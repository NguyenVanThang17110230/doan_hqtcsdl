using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using QLLaptop;
using System.Data.SqlClient;
namespace QLTiemLaptop
{
    public partial class frmThongTinLap : Form
    {
        public frmThongTinLap()
        {
            InitializeComponent();
           
           
        }
        public void Load_cbb_idncc()
        {
            string str = "select IDNhaCC from NhaCC";
            cbb_idnhacc.DisplayMember = "IDNhaCC";
            cbb_idnhacc.DataSource = connect.getDataTable(str);

        }
        
        public void Load_thongtinlap()
        {
            string ttl = "select * from ThongTinLap";
            DataTable dt = connect.getDataTable(ttl);
            dtgv_thongtinlap.DataSource=dt;
        }

        private void frmThongTinLap_Load(object sender, EventArgs e)
        {
            this.Load_cbb_idncc();
            this.Load_thongtinlap();
        }

        private void btn_clearttl_Click(object sender, EventArgs e)
        {
            this.txb_idlapp.Clear();
            this.txb_tenlapp.Clear();
            cbb_idnhacc.Text = "";
            cbb_tennhacc.Text = "";
            this.txb_soluongg.Clear();
            this.txb_dongiaa.Clear();
            this.txb_thongtin.Clear();

        }

        private void btn_addttl_Click(object sender, EventArgs e)
        {
            string them= @"exec dbo.uspInsertthongtinlap N'" + txb_idlapp.Text + "',N'" + txb_tenlapp.Text
                + "',N'" + cbb_idnhacc.Text + "',N'" + cbb_tennhacc.Text + "','" + txb_soluongg.Text
                + "','" + txb_dongiaa.Text + "',N'" + txb_thongtin.Text + "'";
            connect.executeQuery(them);
            Load_thongtinlap();
        }

        private void btn_fixttl_Click(object sender, EventArgs e)
        {
            string fixttl = @"exec dbo.uspFixthongtinlap N'" + txb_idlapp.Text + "',N'" + txb_tenlapp.Text 
                + "',N'" + cbb_idnhacc.Text + "',N'"+cbb_tennhacc.Text +"','"+txb_soluongg.Text
                +"','"+txb_dongiaa.Text+"',N'"+txb_thongtin.Text+"'";
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn sửa thông tin lap", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog==DialogResult.Yes)
            {
                connect.executeQuery(fixttl);
                Load_thongtinlap();
                this.txb_idlapp.Clear();
                this.txb_tenlapp.Clear();
                cbb_idnhacc.Text = "";
                cbb_tennhacc.Text = "";
                this.txb_soluongg.Clear();
                this.txb_dongiaa.Clear();
                this.txb_thongtin.Clear();

            }

        }

        private void btn_deletttn_Click(object sender, EventArgs e)
        {
            string deletettn = @"exec dbo.uspDeletethongtinlap N'" + txb_idlapp.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog==DialogResult.Yes)
            {
                connect.executeQuery(deletettn);
                Load_thongtinlap();
                this.txb_idlapp.Clear();
                this.txb_tenlapp.Clear();
                cbb_idnhacc.Text = "";
                cbb_tennhacc.Text = "";
                this.txb_soluongg.Clear();
                this.txb_dongiaa.Clear();
                this.txb_thongtin.Clear();
            }

        }

        private void btn_inttl_Click(object sender, EventArgs e)
        {

        }

        private void dtgv_thongtinlap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_thongtinlap.Rows[e.RowIndex];
            txb_idlapp.Text = row.Cells[0].Value.ToString();
            txb_tenlapp.Text = row.Cells[1].Value.ToString();
            cbb_idnhacc.Text = row.Cells[2].Value.ToString();
            cbb_tennhacc.Text = row.Cells[3].Value.ToString();
            txb_soluongg.Text = row.Cells[4].Value.ToString();
            txb_dongiaa.Text = row.Cells[5].Value.ToString();
            txb_thongtin.Text = row.Cells[6].Value.ToString();
            
        }

        private void cbb_idnhacc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strt = "select TenNhaCC from NhaCC where IDNhaCC='" + cbb_idnhacc.Text + "'";
            cbb_tennhacc.DisplayMember = "TenNhaCC";
            cbb_tennhacc.DataSource = connect.getDataTable(strt);
        }

        private void dtgv_thongtinlap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_thongtinlap.Rows[e.RowIndex];
            txb_idlapp.Text = row.Cells[0].Value.ToString();
            txb_tenlapp.Text = row.Cells[1].Value.ToString();
            cbb_idnhacc.Text = row.Cells[2].Value.ToString();
            cbb_tennhacc.Text = row.Cells[3].Value.ToString();
            txb_soluongg.Text = row.Cells[4].Value.ToString();
            txb_dongiaa.Text = row.Cells[5].Value.ToString();
            txb_thongtin.Text = row.Cells[6].Value.ToString();
        }
    }
}
