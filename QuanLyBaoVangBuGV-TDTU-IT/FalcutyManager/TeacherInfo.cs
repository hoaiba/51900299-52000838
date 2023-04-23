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
    public partial class TeacherInfo : Form
    {
        public BUS_GiangVien gv;
        private string phanquyen = "G";

        public TeacherInfo()
        {
            InitializeComponent();
        }

        private void TeacherInfo_Load(object sender, EventArgs e)
        {
            gv = new BUS_GiangVien("", "", "", "", "", "", phanquyen);
            dataGridView1.DataSource = gv.selectPhanQuyenG();
        }
    }
}
