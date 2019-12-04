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
    public partial class frmThongKeHoaDonNhap : Form
    {
        public frmThongKeHoaDonNhap()
        {
            InitializeComponent();
        }

        private void frmThongKeHoaDonNhap_Load(object sender, EventArgs e)
        {
            Load_data();
        }
        
        public void Load_data()
        {
            string load = @"exec dbo.XemThongKeNhap";
            DataTable dt = connect.getDataTable(load);
            dtgv_thongkenhap.DataSource = dt;
            dtgv_thongkenhap.Columns["tongtien"].HeaderText = "Tổng tiền";
            dtgv_thongkenhap.Columns["IDHoaDonNhap"].HeaderText = "Mã hóa đơn nhập";
            dtgv_thongkenhap.Columns["IDLapNhap"].HeaderText = "Mã laptop";
            dtgv_thongkenhap.Columns["SoLuong"].HeaderText = "Số lượng";
            dtgv_thongkenhap.Columns["SoLuong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgv_thongkenhap.Columns["IDHoaDonNhap"].Width = 115;
            dtgv_thongkenhap.Columns["tongtien"].DefaultCellStyle.Format = "N0";

        }

        private void txb_month_TextChanged(object sender, EventArgs e)
        {
            if (txb_month.Text == "")
            {
                Load_data();
                txb_tongtien.Text = "0";
            }
            else
            {
                string thongke = @"exec dbo.uspThongkehoadonnhap '" + txb_month.Text + "'";
                DataTable dt = connect.getDataTable(thongke);
                dtgv_thongkenhap.DataSource = dt;
                string tongtien = @"exec dbo.TongTienNhap '" + txb_month.Text + "'";
                DataTable dt2 = connect.getDataTable(tongtien);
                txb_tongtien.Text = dt2.Rows[0][0].ToString();
            }

        }
    }
}
