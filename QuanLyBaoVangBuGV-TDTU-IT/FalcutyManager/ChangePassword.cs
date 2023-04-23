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

namespace QuanLyBaoVangBuGV_TDTU_IT.FalcutyManager
{
    public partial class ChangePassword : Form
    {
        public BUS_GiangVien gv;
        private string id;

        public ChangePassword()
        {
            InitializeComponent();
        }

        public ChangePassword(string textID) : this()
        {
            id = textID;
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            gv = new BUS_GiangVien(id, "", "", "", "", "", "");

            // Trường hợp các textbox trống
            if (textMatKhauCu.Text == "" || textMatKhauMoi.Text == "" || textMatKhauXacNhan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập vào");
            }
            // Trường hợp textbox của MatKhau cũ không đúng
            else if (textMatKhauCu.Text != gv.selectMatKhau())
            {
                MessageBox.Show("Mật khẩu không đúng. Vui lòng nhập lại.");
            }
            // Trường hợp textbox của MatKhau cũ giống với MatKhau mới
            else if (textMatKhauCu.Text == textMatKhauMoi.Text || textMatKhauCu.Text == textMatKhauXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu mới trùng với mật khẩu cũ. Vui lòng nhập lại.");
            }
            // Trường họp textbox của Xác nhận MatKhau khác với MatKhau mới
            else if (textMatKhauXacNhan.Text != textMatKhauMoi.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không trùng với mật khẩu mới. Vui lòng nhập lại.");
            }
            else
            {
                gv = new BUS_GiangVien(id, "", "", "", textMatKhauMoi.Text, "", "");
                gv.updateMatKhau();
                MessageBox.Show("Thay đổi mật khẩu thành công");
                this.Dispose();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
