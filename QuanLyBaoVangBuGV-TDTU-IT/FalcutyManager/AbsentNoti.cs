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
    public partial class AbsentNoti : Form
    {
        public BUS_PhieuVang pv;
        private int dk;
        private string row;
        private string duyet = "Chấp thuận";
        private string khongduyet = "Không chấp thuận";

        public AbsentNoti()
        {
            InitializeComponent();
        }

        private void AbsentNoti_Load(object sender, EventArgs e)
        {
            pv = new BUS_PhieuVang("", DateTime.Now, "", "", "");
            dataGridView1.DataSource = pv.selectQuery();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            row = dataGridView1.Rows[rowIndex].Cells[0].Value.ToString();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            dk = 1;
            btnSave.Enabled = true;
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            dk = 2;
            btnSave.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dk == 1)
            {
                pv = new BUS_PhieuVang(row, DateTime.Now, "", duyet, "");
                pv.updatePhieuVangDuyet();
            }   
            else if (dk == 2)
            {
                pv = new BUS_PhieuVang(row, DateTime.Now, "", khongduyet, "");
                pv.updatePhieuVangKhongDuyet();
            }
        }
    }
}
