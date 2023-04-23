using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBaoVangBuGV_TDTU_IT
{
    public partial class fLogin : Form
    {
        public string str = "";
        public BUS_GiangVien gv;
        public BUS_SinhVien sv;
        
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Giảng Viên
            gv = new BUS_GiangVien("", "", textEmail.Text, "", textPassword.Text, "", "");

            // Sinh Viên
            sv = new BUS_SinhVien("", "", textEmail.Text, "", textPassword.Text, "");

            // Nếu đăng nhập có PhanQuyen là G thì di chuyển tới form Teacher
            if (gv.selectPhanQuyen(textEmail.Text, textPassword.Text).Contains("G"))
            {
                fTeacherManager f = new fTeacherManager(gv.selectHoTen(textEmail.Text), gv.selectID(textEmail.Text));
                this.Hide();
                f.ShowDialog();
                this.Show();
            }

            // Nếu đăng nhập có PhanQuyen là G thì di chuyển tới form Falcuty
            else if (gv.selectPhanQuyen(textEmail.Text, textPassword.Text).Contains("K"))
            {
                fFalcutyManager f = new fFalcutyManager(gv.selectHoTen(textEmail.Text), gv.selectID(textEmail.Text));
                this.Hide();
                f.ShowDialog();
                this.Show();
            }

            // Nếu đăng nhập có PhanQuyen là S thì di chuyển tới form Student
            else if (sv.selectPhanQuyen(textEmail.Text, textPassword.Text).Contains("S"))
            {
                fStudentManager f = new fStudentManager(sv.selectHoTen(textEmail.Text), sv.selectID(textEmail.Text));
                this.Hide(); f.ShowDialog();
                this.Show();
            }    
            else
            {
                MessageBox.Show("Đăng nhập không thành công");
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }

        
    }
}
