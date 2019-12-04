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
    public partial class frmThongKeHoaDonBan : Form
    {
        public frmThongKeHoaDonBan()
        {
            InitializeComponent();
        }

        private void frmThongKeHoaDonBan_Load(object sender, EventArgs e)
        {
            Load_data();
            
        }
        public void Load_data()
        {
            string load = @"exec XemThongKeBan";
            DataTable dt = connect.getDataTable(load);
            dtgv_thongkeban.DataSource = dt;
            dtgv_thongkeban.Columns["tongtien"].HeaderText = "Tổng tiền";
            dtgv_thongkeban.Columns["IDHoaDonBan"].HeaderText = "Mã hóa đơn bán";
            dtgv_thongkeban.Columns["TenLap"].HeaderText = "Tên laptop";
            dtgv_thongkeban.Columns["SoLuong"].HeaderText = "Số lượng";
            dtgv_thongkeban.Columns["SoLuong"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgv_thongkeban.Columns["IDHoaDonBan"].Width = 110;
        }

        private void txb_month_TextChanged(object sender, EventArgs e)
        {
            if(txb_month.Text=="")
            {
                Load_data();
                txb_tongtien.Text = "0";
            }
            else 
            {
                string thongke = @"exec dbo.uspThongkehoadonban '" + txb_month.Text + "'";
                DataTable dt = connect.getDataTable(thongke);
                dtgv_thongkeban.DataSource = dt;
                string tongtien = @"exec dbo.TongTien '"+txb_month.Text+"'";
                DataTable dt2 = connect.getDataTable(tongtien);
                txb_tongtien.Text = dt2.Rows[0][0].ToString();
            }
            
        }
    }
}
