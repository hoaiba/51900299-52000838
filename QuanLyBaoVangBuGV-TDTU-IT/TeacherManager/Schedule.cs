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
    public partial class Schedule : Form
    {
        private string idGV;
        public BUS_MonHoc l;
        public Schedule()
        {
            InitializeComponent();
        }

        public Schedule(string textID) : this()
        {
            idGV = textID;
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            l = new BUS_MonHoc("", "", "", 0, "", idGV);
            dataGridView1.DataSource = l.selectLichGV();
        }
    }
}
