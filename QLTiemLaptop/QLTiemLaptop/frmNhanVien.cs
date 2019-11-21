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
        private void dtgv_nhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_nhanvien.Rows[e.RowIndex];
            txb_idnhanvien.Text = row.Cells[0].Value.ToString();
            txb_tennhanvien.Text = row.Cells[1].Value.ToString();
            txb_gioitinhnhanvien.Text = row.Cells[2].Value.ToString();
            txb_ngaysinhnhanvien.Text = row.Cells[3].Value.ToString();
            txb_diachinhanvien.Text = row.Cells[4].Value.ToString();
            txb_sdtnhanvien.Text = row.Cells[5].Value.ToString();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            this.Load_datanv();
        }

        private void btn_clearnhanvien_Click(object sender, EventArgs e)
        {
            this.txb_idnhanvien.Clear();
            this.txb_tennhanvien.Clear();
            this.txb_gioitinhnhanvien.Clear();
            this.txb_diachinhanvien.Clear();
            this.txb_ngaysinhnhanvien.Clear();
            this.txb_sdtnhanvien.Clear();

        }

        private void btn_themnhanvien_Click(object sender, EventArgs e)
        {
            string addnv = @"exec dbo.uspInsertnhanvien N'" + txb_idnhanvien.Text + "',N'" + txb_tennhanvien.Text + "',N'" +
                txb_gioitinhnhanvien.Text + "','" + txb_ngaysinhnhanvien.Text + "',N'" + txb_diachinhanvien.Text
                + "',N'" + txb_sdtnhanvien.Text + "'";
            connect.executeQuery(addnv);
            Load_datanv();
        }

        private void btn_fixnhanvien_Click(object sender, EventArgs e)
        {
            string fixnv = @"exec dbo.uspFixnhanvien N'" + txb_idnhanvien.Text + "',N'" + txb_tennhanvien.Text + "',N'" +
                txb_gioitinhnhanvien.Text + "','" + txb_ngaysinhnhanvien.Text + "',N'" + txb_diachinhanvien.Text
                + "',N'" + txb_sdtnhanvien.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn sửa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog==DialogResult.Yes)
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

        private void btn_innhanvien_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoatnhanvien_Click(object sender, EventArgs e)
        {

        }
    }
}
