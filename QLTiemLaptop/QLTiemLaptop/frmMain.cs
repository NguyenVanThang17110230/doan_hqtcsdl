using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTiemLaptop
{
    public partial class frmMain : Form
    {
        string PhanQuyen = "";
        public frmMain()
        {
            InitializeComponent();
        }
        public frmMain(string PhanQuyen)
        {
            InitializeComponent();
            this.PhanQuyen = PhanQuyen;
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(PhanQuyen=="1"||PhanQuyen=="4")
            {
                this.Hide();
                Form hbd = new frmHoaDonBan();
                hbd.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(PhanQuyen=="2"||PhanQuyen=="4")
            {
                this.Hide();
                Form hdn = new frmHoaDonNhap();
                hdn.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ttlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ttl = new frmThongTinLap();
            ttl.ShowDialog();
            this.Close();

        }

        private void nccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ncc = new frmNhaCungCap();
            ncc.ShowDialog();
            this.Close();
        }

        private void khToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form kh = new frmKhachHang();
            kh.ShowDialog();
            this.Close();
        }

        private void ttkmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ttkm = new frmThongTinKhuyenMai();
            ttkm.ShowDialog();
            this.Close();
        }

        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dialog==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void tgtoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form tg = new frmHoaDonTraGop();
            tg.ShowDialog();
            this.Close();
        }

        private void tkhdbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new frmThongKeHoaDonBan();
            a.ShowDialog();
            this.Close();
        }

        private void tkhdnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new frmThongKeHoaDonNhap();
            a.ShowDialog();
            this.Close();
        }

        private void tkhdtgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new frmThongKeTraGop();
            a.ShowDialog();
            this.Close();
        }

        private void nvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new frmNhanVien();
            a.ShowDialog();
            this.Close();
        }

        private void luongnvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new frmLuongNhanVien();
            a.ShowDialog();
            this.Close();
        }

        private void tkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form a = new frmQuanLyTaiKhoan();
            a.ShowDialog();
            this.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                Form login = new frmDangNhap();
                login.ShowDialog();
                this.Close();
            }
        }
    }
}
