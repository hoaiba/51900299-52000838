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
    public partial class AbsentNoti : Form
    {
        public BUS_Lop l;
        private string id;

        public AbsentNoti()
        {
            InitializeComponent();
        }

        public AbsentNoti(string textID) : this()
        {
            id = textID;
        }

        private void AbsentNoti_Load(object sender, EventArgs e)
        {
            l = new BUS_Lop("", "", id);
            dataGridView1.DataSource = l.selectLopVang();
        }
    }
}
