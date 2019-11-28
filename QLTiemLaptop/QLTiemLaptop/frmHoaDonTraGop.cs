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
            string idlap = "select IDLap from ThongTinLap";
            cbb_idlaptg.DisplayMember = "IDLap";
            cbb_idlaptg.DataSource = connect.getDataTable(idlap);
            cbb_idlaptg.SelectedIndex = -1;
        }
        public void Load_cbb_idnv()
        {
            string idnv = "select IDNhanVien from NhanVien";
            cbb_idnv.DisplayMember = "IDNhanVien";
            cbb_idnv.DataSource = connect.getDataTable(idnv);
            cbb_idnv.SelectedIndex = -1;
        }
        public void Load_cbb_idkh()
        {
            string idkh = "select IDKhachHang from KhachHang";
            cbb_idkh.DisplayMember = "IDKhachHang";
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
                txb_soluongtg.Text = row.Cells[5].Value.ToString();
                txb_dongiatg.Text = row.Cells[6].Value.ToString();
                txb_tongtientg.Text = row.Cells[7].Value.ToString();
                dtp_ngaybantg.Text = row.Cells[8].Value.ToString();
                cbb_hantg.Text = row.Cells[9].Value.ToString();
                txb_thanhtoantrc.Text = row.Cells[10].Value.ToString();
                txb_tienphaitra.Text = row.Cells[11].Value.ToString();

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
                    txb_dongiatg.Text = "";
                }
                else
                {
                    string dongia = "select DonGia from ThongTinLap where IDLap=N'" + cbb_idlaptg.Text + "'";
                    DataTable dt = connect.getDataTable(dongia);
                    txb_dongiatg.Text = dt.Rows[0][0].ToString();
                }
            }
            catch (Exception) { MessageBox.Show("lỗi"); }            
            
        }

        private void txb_dongiatg_TextChanged(object sender, EventArgs e)
        {
            try 
            {
                if(txb_soluongtg.Text=="" && txb_dongiatg.Text=="")
                {
                    txb_tongtientg.Text = "";
                }
                else
                {
                }
            }
            catch (Exception) { }
        }
    }
}
