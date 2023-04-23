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
    public partial class TeacherList : Form
    {
        BUS_GiangVien l;
        public TeacherList()
        {
            InitializeComponent();
        }

        private void TeacherList_Load(object sender, EventArgs e)
        {
            l = new BUS_GiangVien("", "", "", "", "", "", "G");
            dgvTeacherList.DataSource = l.selectPhanQuyenG();

            // Resize
            dgvTeacherList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
    }
}
