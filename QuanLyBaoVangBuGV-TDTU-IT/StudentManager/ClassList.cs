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
    public partial class ClassList : Form
    {
        public BUS_MonHoc l;
        public ClassList()
        {
            InitializeComponent();
        }

        private void ClassList_Load(object sender, EventArgs e)
        {
            l = new BUS_MonHoc("", "", "", "");
            dataGridView1.DataSource = l.selectLichHoc();
        }
    }
}
