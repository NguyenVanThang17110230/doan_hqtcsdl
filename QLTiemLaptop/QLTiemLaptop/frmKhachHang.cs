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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            this.Load_datakh();           
        }
        public void Load_datakh()
        {
            string load = @"exec dbo.uspLaykhachhang";
            DataTable dtkh = connect.getDataTable(load);
            dtgv_khachhang.DataSource = dtkh;
            dtgv_khachhang.Columns[0].Width = 90;
            dtgv_khachhang.Columns[2].Width = 79;
            dtgv_khachhang.Columns[1].Width = 110;
        }

        private void btn_clearkhachhang_Click(object sender, EventArgs e)
        {
            this.txb_idkhachhangg.Clear();
            this.txb_tenkhachhangg.Clear();
            this.txb_gioitinhkhachhangg.Clear();
            this.txb_diachikhachhangg.Clear();
            this.txb_sdtkhachhang.Clear();

        }

        private void btn_addkhachhang_Click(object sender, EventArgs e)
        {
            string add = @"exec dbo.uspInsertkhachhang N'" + txb_idkhachhangg.Text + "',N'" + txb_tenkhachhangg.Text + "',N'" +
                txb_gioitinhkhachhangg.Text + "',N'" + txb_diachikhachhangg.Text + "',N'" + txb_sdtkhachhang.Text + "'";
            connect.executeQuery(add);
            Load_datakh();
            this.txb_idkhachhangg.Clear();
            this.txb_tenkhachhangg.Clear();
            this.txb_gioitinhkhachhangg.Clear();
            this.txb_diachikhachhangg.Clear();
            this.txb_sdtkhachhang.Clear();

        }

        private void btn_fixkhachhang_Click(object sender, EventArgs e)
        {
            string fix = @"exec dbo.uspFixkhachhang N'" + txb_idkhachhangg.Text + "',N'" + txb_tenkhachhangg.Text + "',N'" +
                txb_gioitinhkhachhangg.Text + "',N'" + txb_diachikhachhangg.Text + "',N'" + txb_sdtkhachhang.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn sửa!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog==DialogResult.Yes)
            {
                connect.executeQuery(fix);
                Load_datakh();
            }
            else
            {

            }

        }

        private void btn_deletkhh_Click(object sender, EventArgs e)
        {
            string xoa = @"exec dbo.uspDeletekhachhang N'" + txb_idkhachhangg.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn xóa!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                connect.executeQuery(xoa);
                Load_datakh();
                this.txb_idkhachhangg.Clear();
                this.txb_tenkhachhangg.Clear();
                this.txb_gioitinhkhachhangg.Clear();
                this.txb_diachikhachhangg.Clear();
                this.txb_sdtkhachhang.Clear();
            }
            else
            {

            }

        }

        private void dtgv_khachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_khachhang.Rows[e.RowIndex];
            txb_idkhachhangg.Text = row.Cells[0].Value.ToString();
            txb_tenkhachhangg.Text = row.Cells[1].Value.ToString();
            txb_gioitinhkhachhangg.Text = row.Cells[2].Value.ToString();
            txb_diachikhachhangg.Text = row.Cells[3].Value.ToString();
            txb_sdtkhachhang.Text = row.Cells[4].Value.ToString();
        }

        private void btn_exitkh_Click(object sender, EventArgs e)
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
        private void txb_timkiemkh_TextChanged(object sender, EventArgs e)
        {
            string searchid = @"exec dbo.SearchKhachHang2 N'" + txb_timkiemkh.Text + "'";
            DataTable dt = connect.getDataTable(searchid);
            dtgv_khachhang.DataSource = dt;

        }

        private void txb_timkiemten_TextChanged(object sender, EventArgs e)
        {
            string searchten = @"exec dbo.SearchKhachHang N'" + txb_timkiemten.Text + "'";
            DataTable dt = connect.getDataTable(searchten);
            dtgv_khachhang.DataSource = dt;
        }
    }
}
