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
    public partial class CompensateNoti : Form
    {
        public BUS_Lop l;
        private string id;

        public CompensateNoti()
        {
            InitializeComponent();
        }

        public CompensateNoti(string textID) : this()
        {
            id = textID;
        }

        private void CompensateNoti_Load(object sender, EventArgs e)
        {
            l = new BUS_Lop("", "", id);
            dataGridView1.DataSource = l.selectLopBu();
        }
    }
}
