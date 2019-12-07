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

namespace QLTiemLaptop
{
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
        {
            InitializeComponent();
        }

        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            txb_nhacungccap.Focus();
            Load_datancc();
        }
        public void Load_datancc()
        {
            string load = @"exec dbo.uspLaynhacc";
            DataTable dt = connect.getDataTable(load);
            dtgv_nhacungcap.DataSource = dt;
        }

        private void btn_exitncc_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_clearncc_Click(object sender, EventArgs e)
        {
            this.txb_nhacungccap.Clear();
            this.txb_tennhacungcap.Clear();
            this.txb_diachi.Clear();
            this.txb_sdt.Clear();

        }

        private void btn_addncc_Click(object sender, EventArgs e)
        {
            string add = @"exec dbo.uspInsertncc N'" + txb_nhacungccap.Text + "',N'" + txb_tennhacungcap.Text + "',N'" + txb_diachi.Text + "',N'" + txb_sdt.Text + "'";
            connect.executeQuery(add);
            Load_datancc();
        }

        private void btn_fixncc_Click(object sender, EventArgs e)
        {
            string fix = @"exec dbo.uspFixncc N'" + txb_nhacungccap.Text + "',N'" + txb_tennhacungcap.Text + "',N'" + txb_diachi.Text + "',N'" + txb_sdt.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn sửa nhà cung cấp", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    connect.executeQuery(fix);
                    Load_datancc();
                }
                catch(Exception)
                {
                    MessageBox.Show("Sửa không được!!!");
                }
            }
        }

        private void btn_deletencc_Click(object sender, EventArgs e)
        {
            string delete = @"exec dbo.uspDeletencc N'" + txb_nhacungccap.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    connect.executeQuery(delete);
                    Load_datancc();
                    this.txb_nhacungccap.Clear();
                    this.txb_tennhacungcap.Clear();
                    this.txb_diachi.Clear();
                    this.txb_sdt.Clear();
                }
                catch(Exception)
                {
                    MessageBox.Show("Không xóa được!!");
                }                                
            }
        }

        private void dtgv_nhacungcap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv_nhacungcap.Rows[e.RowIndex];
                txb_nhacungccap.Text = row.Cells[0].Value.ToString();
                txb_tennhacungcap.Text = row.Cells[1].Value.ToString();
                txb_diachi.Text = row.Cells[2].Value.ToString();
                txb_sdt.Text = row.Cells[3].Value.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Không laod được dữ liệu lên!!!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
                
            
            
        }

        private void txb_searchncc_TextChanged(object sender, EventArgs e)
        {
            string searchid = @"exec dbo.Searchnhacungcap N'" + txb_searchncc.Text + "'";            
            DataTable dt = connect.getDataTable(searchid);            
            dtgv_nhacungcap.DataSource = dt;            
        }

        private void txb_searchname_TextChanged(object sender, EventArgs e)
        {
            string searchname = @"exec dbo.Searchnhacungcap2 N'" + txb_searchname.Text + "'";
            DataTable dt2 = connect.getDataTable(searchname);
            dtgv_nhacungcap.DataSource = dt2;
        }
    }
}
