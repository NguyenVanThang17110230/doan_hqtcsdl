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
    public partial class frmThongTinKhuyenMai : Form
    {
        public frmThongTinKhuyenMai()
        {
            InitializeComponent();
        }



       
        public void Load_datattkm()
        {
            string data = "select * from ThongTinKhuyenMai";
            DataTable dt = connect.getDataTable(data);
            dtgv_thongtinkhuyenmai.DataSource = dt;
            dtgv_thongtinkhuyenmai.Columns[2].Width = 203;
        }
        private void frmThongTinKhuyenMai_Load(object sender, EventArgs e)
        {
            Load_datattkm();
        }

        private void btn_clearttkm_Click(object sender, EventArgs e)
        {
            this.txb_idkhuyenmai.Clear();
            this.txb_tenlapkm.Clear();
            this.txb_thongtinkm.Clear();

        }

        private void btn_addttkm_Click(object sender, EventArgs e)
        {
            string add = @"exec dbo.uspInsertthongtinkhuyenmai N'" + txb_idkhuyenmai.Text + "',N'" + txb_tenlapkm.Text + "',N'" + txb_thongtinkm.Text + "'";
            connect.executeQuery(add);
            Load_datattkm();

        }

        private void btn_fixttkm_Click(object sender, EventArgs e)
        {
            string fix = @"exec dbo.uspFixthongtinkhuyenmai N'" + txb_idkhuyenmai.Text + "',N'" + txb_tenlapkm.Text + "',N'" + txb_thongtinkm.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn sửa Thông tin khuyến mãi", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    connect.executeQuery(fix);
                    Load_datattkm();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không được!!!");
                }
            }

        }

        private void btn_deletettkm_Click(object sender, EventArgs e)
        {
            string delete = @"exec dbo.uspDeletethongtinkhuyenmai N'" + txb_idkhuyenmai.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    connect.executeQuery(delete);
                    Load_datattkm();
                    this.txb_idkhuyenmai.Clear();
                    this.txb_tenlapkm.Clear();
                    this.txb_thongtinkm.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("Không xóa được!!");
                }
            }
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();

        }

        private void dtgv_thongtinkhuyenmai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv_thongtinkhuyenmai.Rows[e.RowIndex];
                txb_idkhuyenmai.Text = row.Cells[0].Value.ToString();
                txb_tenlapkm.Text = row.Cells[1].Value.ToString();
                txb_thongtinkm.Text = row.Cells[2].Value.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Không laod được dữ liệu lên!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
