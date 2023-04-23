using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_PhieuBu
    {
        public DAL_PhieuBu l;

        public BUS_PhieuBu(string idPb, DateTime ngaybu, string maPv, string lydo, string trangthai)
        {
            l = new DAL_PhieuBu(idPb, ngaybu, maPv, lydo, trangthai);
        }    

        public DataTable selectQuery()
        {
            return l.selectQuery();
        }
    }
}
