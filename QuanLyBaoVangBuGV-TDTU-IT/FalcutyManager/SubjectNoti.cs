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
    public partial class SubjectNoti : Form
    {
        public BUS_MonHoc mh;

        public SubjectNoti()
        {
            InitializeComponent();
        }

        private void SubjectNoti_Load(object sender, EventArgs e)
        {
            mh = new BUS_MonHoc("", "", "", 0, "", "");
            dataGridView1.DataSource = mh.selectQuery();
        }
    }
}
