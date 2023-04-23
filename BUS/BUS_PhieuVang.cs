using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_PhieuVang
    {
        public DAL_PhieuVang l;

        public BUS_PhieuVang(string idPv, DateTime ngayvang, string lydo, string trangthai, string maLop)
        {
            l = new DAL_PhieuVang(idPv, ngayvang, lydo, trangthai, maLop);
        }

        public DataTable selectQuery()
        {
            return l.selectQuery();
        }
    }
}
