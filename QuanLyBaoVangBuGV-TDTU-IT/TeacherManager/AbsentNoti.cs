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
    public partial class AbsentNoti : Form
    {
        public BUS_PhieuVang pv;

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
            pv = new BUS_PhieuVang("", DateTime.Now, "", "", "");
            dataGridView1.DataSource = pv.selectPhieuVangGV(id);
        }
    }
}
