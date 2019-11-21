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
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace QLTiemLaptop
{
    public partial class frmHoaDonBan : Form
    {
        public frmHoaDonBan()
        {
            InitializeComponent();
            Load_Data();
            //Load_datanhap();
        }
        //xử lý hóa đơn bán
        public void Load_Data()
        {
            string str = "select * from HoaDonBan";
            DataTable dt = connect.getDataTable(str);
            dtgv_hoadon.DataSource = dt;
            dtgv_hoadon.AutoResizeColumns();
            
        }
        private void dtgv_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv_hoadon.Rows[e.RowIndex];
                txb_idhoadon.Text = row.Cells[0].Value.ToString();
                txb_idlap.Text = row.Cells[1].Value.ToString();
                txb_idkhach.Text = row.Cells[2].Value.ToString();
                txb_idnhanvien.Text = row.Cells[3].Value.ToString();
                txb_soluong.Text = row.Cells[4].Value.ToString();
                txb_ngayban.Text = row.Cells[5].Value.ToString();
                txb_sdt.Text = row.Cells[6].Value.ToString();
                txb_dongia.Text = row.Cells[8].Value.ToString();               
                txb_tongtien.Text = row.Cells[9].Value.ToString();
            }
            catch (Exception) { }
            

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txb_idhoadon.Clear();
            this.txb_idkhach.Clear();
            this.txb_idnhanvien.Clear();
            this.txb_idlap.Clear();
            this.txb_soluong.Clear();
            this.txb_ngayban.Clear();
            this.txb_sdt.Clear();
            this.txb_dongia.Clear();
            this.txb_tongtien.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string them = @"exec dbo.uspInserthoadon N'" + txb_idhoadon.Text + "',N'" + txb_idlap.Text
                + "',N'" + txb_idkhach.Text + "',N'" + txb_idnhanvien.Text + "','" + txb_soluong.Text +
                "','" + txb_ngayban.Text + "',N'" + txb_sdt.Text + "','" + "" + "','" + txb_dongia.Text + "','" + txb_tongtien.Text + "'";
            connect.executeQuery(them);
            Load_Data();
        }

        private void txt_idlap_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_idnhanvien_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string xoa = @"EXEC dbo.uspDeleteHoadon N'" + txb_idhoadon.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có muốn xóa sách :" + txb_idhoadon.Text,
                "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    connect.executeQuery(xoa);
                    MessageBox.Show("Xóa thành công!!");
                    Load_Data();
                    this.txb_idhoadon.Clear();
                    this.txb_idkhach.Clear();
                    this.txb_idnhanvien.Clear();
                    this.txb_idlap.Clear();
                    this.txb_soluong.Clear();
                    this.txb_ngayban.Clear();
                    this.txb_sdt.Clear();
                    this.txb_dongia.Clear();
                    this.txb_tongtien.Clear();
                }
                catch (Exception)
                {
                }
            }
            else if (dialog == DialogResult.No)
            {
            }
        }

        private void btn_fix_Click(object sender, EventArgs e)
        {
            string fix = @"exec dbo.uspFixHoadon N'" + txb_idhoadon.Text + "',N'" + txb_idlap.Text
                + "',N'" + txb_idkhach.Text + "',N'" + txb_idnhanvien.Text + "','" + txb_soluong.Text +
                "','" + txb_ngayban.Text + "',N'" + txb_sdt.Text + "','" + txb_dongia.Text + "'";
            connect.executeQuery(fix);
            MessageBox.Show("Sữa thành công!!");
            Load_Data();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
                Application.Exit();
        }
    }
}
