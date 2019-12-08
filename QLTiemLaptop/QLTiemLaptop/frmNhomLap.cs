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
    public partial class frmNhomLap : Form
    {
        public frmNhomLap()
        {
            InitializeComponent();
        }

        public void Load_data()
        {
            string load = @"exec dbo.uspLaynhomlap ";
            DataTable dt = connect.getDataTable(load);
            dtgv_nhomlap.DataSource = dt;
            dtgv_nhomlap.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void frmNhomLap_Load(object sender, EventArgs e)
        {
            Load_data();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txb_id.Clear();
            this.txb_ten.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string add = @"exec dbo.uspInsertnhomlap N'" + txb_id.Text + "',N'" + txb_ten.Text + "'";
            connect.executeQuery(add);
            Load_data();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string fix = @"exec dbo.uspFixnhomlap N'" + txb_id.Text + "',N'" + txb_ten.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn sửa nhóm lap", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    connect.executeQuery(fix);
                    Load_data();
                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa không được!!!");
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string delete = @"exec dbo.uspDeletenhomlap N'" + txb_id.Text + "'";
            DialogResult dialog = MessageBox.Show("Bạn có chắc muốn xóa!!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    connect.executeQuery(delete);
                    Load_data();
                    this.txb_id.Clear();
                    this.txb_ten.Clear();
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Không xóa được!!");
                }
            }
        }

        private void dtgv_nhomlap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dtgv_nhomlap.Rows[e.RowIndex];
            txb_id.Text = row.Cells[0].Value.ToString();
            txb_ten.Text = row.Cells[1].Value.ToString();
            
        }
    }
}
