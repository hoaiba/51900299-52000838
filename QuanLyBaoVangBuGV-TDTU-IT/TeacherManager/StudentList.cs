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

namespace QuanLyBaoVangBuGV_TDTU_IT.TeacherManager
{
    public partial class StudentList : Form
    {
        private string idGV;
        public BUS_GiangVien l;
        public StudentList()
        {
            InitializeComponent();
        }

        public StudentList(string textID) : this()
        {
            idGV = textID;
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            l = new BUS_GiangVien(idGV, "", "", "", "", "", "");
            dataGridView1.DataSource = l.selectSVtrongLop();
        }
    }
}
