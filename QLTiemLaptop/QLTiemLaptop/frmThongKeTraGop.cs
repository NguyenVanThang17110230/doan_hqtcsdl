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
    public partial class frmThongKeTraGop : Form
    {
        public frmThongKeTraGop()
        {
            InitializeComponent();
        }

        private void frmThongKeTraGop_Load(object sender, EventArgs e)
        {
            Load_data();
            dtgv_thongketg.Columns["IDHoaDonTraGop"].HeaderText = "Mã hóa đơn trả góp";
            dtgv_thongketg.Columns["TenLap"].HeaderText = "Tên laptop";
            dtgv_thongketg.Columns["ThanhToanTruoc"].HeaderText = "Thanh toán trước";
            dtgv_thongketg.Columns["TienConThieu"].HeaderText = "Tiền còn thiếu";
            dtgv_thongketg.Columns["ThanhToanTruoc"].Width = 115;
            dtgv_thongketg.Columns["TenLap"].Width = 90;
            dtgv_thongketg.Columns["IDHoaDonTraGop"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        public void Load_data()
        {
            string data = @"exec dbo.uspThongketg";
            DataTable dt = connect.getDataTable(data);
            dtgv_thongketg.DataSource = dt;
        }

        private void txb_month_TextChanged(object sender, EventArgs e)
        {
            if (txb_month.Text == "")
            {
                Load_data();
                txb_tongtien.Text = "0";
                txb_congno.Text = "0";
            }
            else
            {
                string thongke = @"exec dbo.uspThongkehoadontg '" + txb_month.Text + "'";
                DataTable dt = connect.getDataTable(thongke);
                dtgv_thongketg.DataSource = dt;
                string tongtien = @"exec dbo.uspTongtientratrc '" + txb_month.Text + "'";
                DataTable dt2 = connect.getDataTable(tongtien);
                txb_tongtien.Text = dt2.Rows[0][0].ToString();
                string congno = @"exec dbo.uspTongtienthieu '" + txb_month.Text + "'";
                DataTable dt3 = connect.getDataTable(congno);
                txb_congno.Text = dt3.Rows[0][0].ToString();
            }
        }
    }
}
