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
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            Load_data();
            dtgv_user.Columns["id"].HeaderText = "Tài khoản";
            dtgv_user.Columns["password"].HeaderText = "Mật khẩu";
            dtgv_user.Columns["PhanQuyen"].HeaderText = "Phân quyền";
            dtgv_user.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public void Load_data()
        {
            string data = @"exec dbo.uspLayuser";
            DataTable dt = connect.getDataTable(data);
            dtgv_user.DataSource = dt;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string add = @"exec dbo.uspInsertuser N'" + txb_taikhoan.Text + "',N'" + txb_matkhau.Text + "','" + txb_phanquyen.Text + "'";
            connect.executeQuery(add);
            Load_data();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            string fix = @"exec dbo.uspFixuser N'" + txb_taikhoan.Text + "',N'" + txb_matkhau.Text + "','" + txb_phanquyen.Text + "'";
            connect.executeQuery(fix);
            Load_data();
        }

        private void dtgv_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_user.Rows[e.RowIndex];
            txb_taikhoan.Text = row.Cells[0].Value.ToString();
            txb_matkhau.Text = row.Cells[1].Value.ToString();
            txb_phanquyen.Text = row.Cells[2].Value.ToString();
        }
    }
}
