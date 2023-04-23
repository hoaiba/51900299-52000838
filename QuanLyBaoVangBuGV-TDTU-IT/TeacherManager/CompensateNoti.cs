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
    public partial class CompensateNoti : Form
    {
        public BUS_PhieuBu pb;
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
            pb = new BUS_PhieuBu("", DateTime.Now, "", "");
            dataGridView1.DataSource = pb.selectPhieuBuGV(id);
        }
    }
}
