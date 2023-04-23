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
        
        public BUS_MonHoc(string idMH, string tenMH, string thu, int ca, string maKhoa, string maGV)
        {
            l = new DAL_MonHoc(idMH, tenMH, thu, ca, maKhoa, maGV);    
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

        // Hiển thị thông tin Lịch giảng dạy của GiangVien
        public DataTable selectLichGV()
        {
            return l.selectLichGV();
        }
    }
}
