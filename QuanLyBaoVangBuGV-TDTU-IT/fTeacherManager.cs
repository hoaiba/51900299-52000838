using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyBaoVangBuGV_TDTU_IT
{
    public partial class fTeacherManager : Form
    {
        private string name, id;
        public fTeacherManager()
        {
            InitializeComponent();
        }

        public fTeacherManager(string textName, string textID) : this()
        {
            name = textName;
            lblEmail.Text = name;
            id = textID;
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        // Hiển thị màn hình Lịch giảng dạy
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            TeacherManager.Schedule f = new TeacherManager.Schedule(id);
            f.TopLevel = false;
            panel5.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        // Hiển thị màn hình Thông tin báo bù
        private void btnClassList_Click(object sender, EventArgs e)
        {
            TeacherManager.CompensateNoti f = new TeacherManager.CompensateNoti(id);
            f.TopLevel = false;
            panel5.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        // Hiển thị màn hình Danh sách SV
        private void btnStudentList_Click(object sender, EventArgs e)
        {
            TeacherManager.StudentList f = new TeacherManager.StudentList(id);
            f.TopLevel = false;
            panel5.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        // Hiển thị màn hình Thông tin báo vắng
        private void btnAbsentNoti_Click(object sender, EventArgs e)
        {
            TeacherManager.AbsentNoti f = new TeacherManager.AbsentNoti(id);
            f.TopLevel = false;
            panel5.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        // Hiển thị màn hình Đăng ký báo vắng
        private void btnAbsentRegister_Click(object sender, EventArgs e)
        {
            TeacherManager.AbsentRegister f = new TeacherManager.AbsentRegister();
            f.TopLevel = false;
            panel5.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btnCompensateNoti_Click(object sender, EventArgs e)
        {
            TeacherManager.CompensateNoti f = new TeacherManager.CompensateNoti(id);
            f.TopLevel = false;
            panel5.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TeacherManager.ChangePassword f = new TeacherManager.ChangePassword(id);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        // Hiển thị màn hình Đăng ký báo bù
        private void btnCompensateRegister_Click(object sender, EventArgs e)
        {
            TeacherManager.CompensateRegister f = new TeacherManager.CompensateRegister();
            f.TopLevel = false;
            panel5.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }
    }
}
