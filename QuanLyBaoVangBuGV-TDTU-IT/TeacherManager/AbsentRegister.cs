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
    public partial class AbsentRegister : Form
    {
        public BUS_PhieuVang l;
        private DateTime d = DateTime.Now;
 
        public AbsentRegister()
        {
            InitializeComponent();
        }

        private void AbsentRegister_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (textID_MH.Text == "" && textReason.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }    
            else if (textReason.Text == "")
            {
                MessageBox.Show("Vui lòng nhập lý do vắng");
            }    
            else if (textID_MH.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã môn học");
            }    
            else
            {
                string id = "";
                l = new BUS_PhieuVang("", d, "", "", "");
                if (l.selectQuery().Rows.Count <= 0)
                {
                    id = "PV001";
                }
                else
                {
                    int k;
                    id = "PV";
                    k = Convert.ToInt32(l.selectQuery().Rows[l.selectQuery().Rows.Count - 1][0].ToString().Substring(2, 3));
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
                l = new BUS_PhieuVang(id, dateCompensate.Value, textReason.Text, "", textID_MH.Text);
                l.addPhieuVang();
                MessageBox.Show("Thêm PhieuVang " + id + " thành công");
            }    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dateCompensate.ResetText();
            textReason.ResetText();
            textID_MH.ResetText();
        }
    }
}
