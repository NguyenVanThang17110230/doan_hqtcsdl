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
    public partial class frmLuongNhanVien : Form
    {
        public frmLuongNhanVien()
        {
            InitializeComponent();
        }

        private void frmLuongNhanVien_Load(object sender, EventArgs e)
        {
            Load_data();
            dtgv_Luongnhanvien.Columns["IDNhanVien"].HeaderText = "Mã nhân viên";
            dtgv_Luongnhanvien.Columns["TenNhanVien"].HeaderText = "Tên";
            dtgv_Luongnhanvien.Columns["TenChucVu"].HeaderText = "Chức vụ";
            dtgv_Luongnhanvien.Columns["TongLuong"].HeaderText = "Lương";
            dtgv_Luongnhanvien.Columns["TenNhanVien"].Width = 120;
            dtgv_Luongnhanvien.Columns["TenChucVu"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public void Load_data()
        {
            string data = @"exec dbo.uspLuong";
            DataTable dt = connect.getDataTable(data);
            dtgv_Luongnhanvien.DataSource = dt;
        }
    }
}
