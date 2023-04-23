using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhieuVang
    {
        private DTO_PhieuVang l;

        public DAL_PhieuVang(string idPv, DateTime ngayvang, string lydo, string trangthai, string maLop) 
        { 
            l = new DTO_PhieuVang(idPv, ngayvang, lydo, trangthai, maLop);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM PhieuVang";
            return Connection.selectQuery(s);
        }
    }
}
