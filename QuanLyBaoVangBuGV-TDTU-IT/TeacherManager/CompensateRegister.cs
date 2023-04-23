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
    public partial class CompensateRegister : Form
    {
        public BUS_PhieuBu pb;

        public CompensateRegister()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (textID_PV.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã phiếu vắng");
            }
            else
            {
                string id = "";
                pb = new BUS_PhieuBu("", DateTime.Now , "", "");
                if (pb.selectQuery().Rows.Count <= 0)
                {
                    id = "PB001";
                }
                else
                {
                    int k;
                    id = "PB";
                    k = Convert.ToInt32(pb.selectQuery().Rows[pb.selectQuery().Rows.Count - 1][0].ToString().Substring(2, 3));
                    k = k + 1;
                    if (k < 10)
                    {
                        id = id + "00";
                    }
                    else if (k < 100)
                    {
                        id = id + "0";
                    }
                    id = id + k.ToString();
                }
                pb = new BUS_PhieuBu(id, dateCompensate.Value, "", textID_PV.Text);
                pb.addPhieuBu();
                MessageBox.Show("Thêm PhieuBu " + id + " thành công");
            }
        }
    }
}
