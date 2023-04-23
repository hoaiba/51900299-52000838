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
    public partial class fStudentManager : Form
    {
        private string name;
        private string id;
        public fStudentManager()
        {
            InitializeComponent();
        }

        public fStudentManager(string textName, string textID) : this()
        {
            id = textID;
            name = textName;
            lblEmail.Text = name;
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            StudentManager.Schedule f = new StudentManager.Schedule(id);
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btnTeacherList_Click(object sender, EventArgs e)
        {
            StudentManager.TeacherList f = new StudentManager.TeacherList();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btnClassList_Click(object sender, EventArgs e)
        {
            StudentManager.ClassList f = new StudentManager.ClassList();
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btnAbsentNoti_Click(object sender, EventArgs e)
        {
            StudentManager.AbsentNoti f = new StudentManager.AbsentNoti(id);
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btnCompensateNoti_Click(object sender, EventArgs e)
        {
            StudentManager.CompensateNoti f = new StudentManager.CompensateNoti(id);
            f.TopLevel = false;
            panel2.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            StudentManager.ChangePassword f = new StudentManager.ChangePassword(id);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
