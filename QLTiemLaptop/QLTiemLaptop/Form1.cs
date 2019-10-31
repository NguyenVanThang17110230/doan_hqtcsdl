using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Data.SqlClient;
using System.Data;
using System;
using QLLaptop;

namespace QLTiemLaptop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "" || txt_pass.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tài khoản và mật khẩu", "Thông báo");
                return;
            }
            DataTable dt = connect.getDataTable("select * from MyUser where id = N'" + txt_user.Text
                + "' and password = N'" + txt_pass.Text + "'");
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Xin chào " + txt_user.Text + "! Bạn đã đăng nhập thành công!", "Thông báo");
                this.Hide();
                Form main = new FormChinh();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!", "Thông báo");
                txt_user.Clear();
                txt_pass.Clear();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
