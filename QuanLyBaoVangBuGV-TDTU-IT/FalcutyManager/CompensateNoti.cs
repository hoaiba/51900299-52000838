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
    public partial class CompensateNoti : Form
    {
        public BUS_PhieuBu pb;
        private int dk;
        private string row;
        private string duyet = "Chấp thuận";
        private string khongduyet = "Không chấp thuận";

        public CompensateNoti()
        {
            InitializeComponent();
        }

        private void CompensateNoti_Load(object sender, EventArgs e)
        {
            pb = new BUS_PhieuBu("", DateTime.Now, "", "");
            dataGridView1.DataSource = pb.selectQuery();
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
                pb = new BUS_PhieuBu(row, DateTime.Now, duyet, "");
                pb.updatePhieuVangDuyet();
            }
            else if (dk == 2)
            {
                pb = new BUS_PhieuBu(row, DateTime.Now, khongduyet, "");
                pb.updatePhieuVangKhongDuyet();
            }
        }
    }
}
