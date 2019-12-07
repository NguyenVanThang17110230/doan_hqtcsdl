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
            if (PhanQuyen == "1" || PhanQuyen == "4")
            {
                Form hbd = new frmHoaDonBan();
                hbd.ShowDialog();
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
                Form hdn = new frmHoaDonNhap();
                hdn.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ttlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(PhanQuyen=="3"||PhanQuyen=="4")
            {
                
                Form ttl = new frmThongTinLap();
                ttl.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void nccToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhanQuyen == "3" || PhanQuyen == "4"||PhanQuyen=="2")
            {
                Form ncc = new frmNhaCungCap();
                ncc.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void khToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhanQuyen == "1" || PhanQuyen == "4")
            {
                Form kh = new frmKhachHang();
                kh.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ttkmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhanQuyen == "3" || PhanQuyen == "4")
            {
                Form ttkm = new frmThongTinKhuyenMai();
                ttkm.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
            if (PhanQuyen == "1" || PhanQuyen == "4")
            {
                Form tg = new frmHoaDonTraGop();
                tg.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tkhdbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new frmThongKeHoaDonBan();
            a.ShowDialog();
            
        }

        private void tkhdnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new frmThongKeHoaDonNhap();
            a.ShowDialog();
            
        }

        private void tkhdtgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new frmThongKeTraGop();
            a.ShowDialog();
            
        }

        private void nvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new frmNhanVien();
            a.ShowDialog();
            
        }

        private void luongnvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form a = new frmLuongNhanVien();
            a.ShowDialog();
            
        }

        private void tkToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form a = new frmQuanLyTaiKhoan();
            a.ShowDialog();
            
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                Form login = new frmDangNhap();
                login.ShowDialog();
                
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PhanQuyen == "4")
            {
                adminToolStripMenuItem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Bạn không có quyền sử dụng!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
