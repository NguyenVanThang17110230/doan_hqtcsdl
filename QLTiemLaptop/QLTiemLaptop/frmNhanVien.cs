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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        
        public void Load_datanv()
        {
            string str = "select * from NhanVien";
            DataTable dt = connect.getDataTable(str);
            dtgv_nhanvien.DataSource = dt;
        }
        public void Load_cbb_idchucvu()
        {
            string loadchucvu = "select * from ChucVu";
            cbb_idchucvunv.ValueMember = "IDChucVu";
            cbb_idchucvunv.DisplayMember = "TenChucVu";
            
            cbb_idchucvunv.DataSource = connect.getDataTable(loadchucvu);
        }
        private void dtgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_nhanvien.Rows[e.RowIndex];
            txb_idnhanvien.Text = row.Cells[0].Value.ToString();
            cbb_idchucvunv.Text = row.Cells[1].Value.ToString();
            txb_tennhanvien.Text = row.Cells[2].Value.ToString();
            txb_gioitinhnhanvien.Text = row.Cells[3].Value.ToString();
            dtp_ngaysinhnv.Text = row.Cells[4].Value.ToString();
            txb_diachinhanvien.Text = row.Cells[5].Value.ToString();
            txb_sdtnhanvien.Text = row.Cells[6].Value.ToString();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            this.Load_datanv();
            this.Load_cbb_idchucvu();
            cbb_idchucvunv.SelectedIndex = -1;
            dtgv_nhanvien.Columns["GioiTinh"].HeaderText = "Giới tính";
            dtgv_nhanvien.Columns["IDNhanVien"].HeaderText = "Mã nhân viên";
            dtgv_nhanvien.Columns["TenNhanVien"].HeaderText = "Tên";
            dtgv_nhanvien.Columns["DiaChi"].HeaderText = "Địa chỉ";
            dtgv_nhanvien.Columns["IDChucVu"].HeaderText = "Mã chức vụ";
            dtgv_nhanvien.Columns["Sdt"].HeaderText = "Số điện thoại";
            dtgv_nhanvien.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dtgv_nhanvien.Columns["GioiTinh"].Width = 75;
            dtgv_nhanvien.Columns["IDChucVu"].Width = 90;
            dtgv_nhanvien.Columns["TenNhanVien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btn_clearnhanvien_Click(object sender, EventArgs e)
        {
            this.txb_idnhanvien.Clear();
            this.cbb_idchucvunv.SelectedIndex=-1;
            this.txb_tennhanvien.Clear();
            this.txb_gioitinhnhanvien.Clear();
            this.txb_diachinhanvien.Clear();
            this.txb_sdtnhanvien.Clear();
            this.cbb_idchucvunv.SelectedIndex = -1;

        }

        private void btn_themnhanvien_Click(object sender, EventArgs e)
        {
            string addnv = @"exec dbo.uspInsertnhanvien N'" + txb_idnhanvien.Text + "',N'"+cbb_idchucvunv.SelectedValue.ToString()+"',N'" + txb_tennhanvien.Text + "',N'" +
                txb_gioitinhnhanvien.Text + "','" + dtp_ngaysinhnv.Text + "',N'" + txb_diachinhanvien.Text
                + "',N'" + txb_sdtnhanvien.Text + "'";
            connect.executeQuery(addnv);
            Load_datanv();
        }

        private void btn_fixnhanvien_Click(object sender, EventArgs e)
        {
            string fixnv = @"exec dbo.uspFixnhanvien N'" + txb_idnhanvien.Text + "',N'" + cbb_idchucvunv.SelectedValue.ToString() + "',N'" + txb_tennhanvien.Text + "',N'" +
                txb_gioitinhnhanvien.Text + "','" + dtp_ngaysinhnv.Text + "',N'" + txb_diachinhanvien.Text
                + "',N'" + txb_sdtnhanvien.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                connect.executeQuery(fixnv);
                Load_datanv();

            }
        }

        private void btn_xoanhanvien_Click(object sender, EventArgs e)
        {
            string deletnv = @"exec dbo.uspDeletenhanvien N'" + txb_idnhanvien.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                connect.executeQuery(deletnv);
                Load_datanv();

            }
        }

        private void txb_searchid_TextChanged(object sender, EventArgs e)
        {
            string searchid = @"exec dbo.Searchnhanvien N'" + txb_searchid.Text + "'";
            DataTable dt = connect.getDataTable(searchid);
            dtgv_nhanvien.DataSource = dt;
        }
        private void txb_searchname_TextChanged(object sender, EventArgs e)
        {
            string searchname = @"exec dbo.Searchnhanvien2 N'" + txb_searchname.Text + "'";
            DataTable dt2 = connect.getDataTable(searchname);
            dtgv_nhanvien.DataSource = dt2;
        }
    }
}
