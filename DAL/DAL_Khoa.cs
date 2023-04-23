using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Khoa
    {
        private DTO_Khoa l;

        public DAL_Khoa(string idKhoa, string tenKhoa, string truongKhoa, string sdtKhoa, string emailKhoa)
        {
            l = new DTO_Khoa(idKhoa, tenKhoa, truongKhoa, sdtKhoa, emailKhoa);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM Khoa";
            return Connection.selectQuery(s);
        }
    }
}
