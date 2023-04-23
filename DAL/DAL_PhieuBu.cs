using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhieuBu
    {
        private DTO_PhieuBu l;

        public DAL_PhieuBu(string idPb, DateTime ngaybu, string maPv, string lydo, string trangthai) 
        {
            l = new DTO_PhieuBu(idPb, ngaybu, maPv, lydo, trangthai);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM PhieuBu";
            return Connection.selectQuery(s);
        }
    }
}
