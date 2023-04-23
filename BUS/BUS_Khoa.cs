using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Khoa
    {
        DAL_Khoa l;

        public BUS_Khoa(string idKhoa, string tenKhoa, string truongKhoa, string sdtKhoa, string emailKhoa)
        {
            l = new DAL_Khoa(idKhoa, tenKhoa, truongKhoa, sdtKhoa, emailKhoa);
        }

        public DataTable selectQuery()
        {
            return l.selectQuery();
        }
    }
}
