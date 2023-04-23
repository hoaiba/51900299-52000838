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

namespace QuanLyBaoVangBuGV_TDTU_IT.StudentManager
{
    public partial class Schedule : Form
    {
        private string idSV;
        public BUS_Lop l;
        public Schedule()
        {
            InitializeComponent();
        }

        public Schedule(string id) : this()
        {
            idSV = id;
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            l = new BUS_Lop("", "", "");
            dataGridView1.DataSource = l.selectLopSV(idSV);
        }
    }
}
