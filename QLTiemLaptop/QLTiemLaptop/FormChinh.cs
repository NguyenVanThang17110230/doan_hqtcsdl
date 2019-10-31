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
    public partial class FormChinh : Form
    {
        public FormChinh()
        {
            InitializeComponent();
        }
        public void Load_Data()
        {
            string str = "select * from HoaDon";
            DataTable dt = connect.getDataTable(str);
            dtgv_hoadon.DataSource = dt;
        }
        private void dtgv_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dtgv_hoadon.Rows[e.RowIndex];
                txt_idhoadon.Text = row.Cells[0].Value.ToString();
                txt_idlap.Text = row.Cells[1].Value.ToString();
                txt_idkhach.Text = row.Cells[2].Value.ToString();
                txt_idnhanvien.Text = row.Cells[3].Value.ToString();
                txt_soluong.Text = row.Cells[4].Value.ToString();
                txt_ngayban.Text = row.Cells[5].Value.ToString();
                txt_dongia.Text = row.Cells[6].Value.ToString();
                txt_sdt.Text = row.Cells[7].Value.ToString();
            }
            catch (Exception) { }
            

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            this.txt_idhoadon.Clear();
            this.txt_idkhach.Clear();
            this.txt_idnhanvien.Clear();
            this.txt_idlap.Clear();
            this.txt_soluong.Clear();
            this.txt_ngayban.Clear();
            this.txt_sdt.Clear();
            this.txt_dongia.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string them = @"exec dbo.uspInserthoadon '" + txt_idhoadon.Text + "','" + txt_idlap.Text
                + "',N'" + txt_idkhach.Text + "',N'" + txt_idnhanvien.Text + "',N'" + txt_soluong.Text +
                "','" + txt_ngayban.Text + "','" + txt_dongia.Text + "','" + txt_sdt.Text + "'";
            connect.executeQuery(them);
            Load_Data();
        }
    }
}
