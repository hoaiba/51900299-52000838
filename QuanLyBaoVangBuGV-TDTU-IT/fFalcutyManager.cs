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
    public partial class fFalcutyManager : Form
    {
        private string name;
        private string id;

        public fFalcutyManager()
        {
            InitializeComponent();
        }

        public fFalcutyManager(string textName, string textID) : this()
        {
            name = textName;
            lblEmail.Text = name;
            id = textID;
        }

        private void lblLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Dispose();
        }

        private void btnSubjectNoti_Click(object sender, EventArgs e)
        {
            FalcutyManager.SubjectNoti f = new FalcutyManager.SubjectNoti();
            f.TopLevel = false;
            panel5.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btnAbsentNoti_Click(object sender, EventArgs e)
        {
            FalcutyManager.AbsentNoti f = new FalcutyManager.AbsentNoti();
            f.TopLevel = false;
            panel5.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btnCompensateNoti_Click(object sender, EventArgs e)
        {
            FalcutyManager.CompensateNoti f = new FalcutyManager.CompensateNoti();
            f.TopLevel = false;
            panel5.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void btnTeacherInfo_Click(object sender, EventArgs e)
        {
            FalcutyManager.TeacherInfo f = new FalcutyManager.TeacherInfo();
            f.TopLevel = false;
            panel5.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FalcutyManager.ChangePassword f = new FalcutyManager.ChangePassword(id);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnStudentInfo_Click(object sender, EventArgs e)
        {
            FalcutyManager.StudentInfo f = new FalcutyManager.StudentInfo();
            f.TopLevel = false;
            panel5.Controls.Add(f);
            f.BringToFront();
            f.Show();
        }
    }
}
