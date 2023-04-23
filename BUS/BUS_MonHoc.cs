using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_MonHoc
    {
        public DAL_MonHoc l;
        
        public BUS_MonHoc(string idMH, string tenMH, string maKhoa, string maGV)
        {
            l = new DAL_MonHoc(idMH, tenMH, maKhoa, maGV);    
        }

        // Hiển thị tất cả thông tin
        public DataTable selectQuery()
        {
            return l.selectQuery();
        }

        // Hiển thị thông tin TenMH và TenGV 
        public DataTable selectLichHoc()
        {
            return l.selectLichHoc();
        }
    }
}
