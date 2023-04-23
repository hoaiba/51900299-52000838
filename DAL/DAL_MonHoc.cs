using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_MonHoc
    {
        private DTO_MonHoc l;
        
        public DAL_MonHoc(string idMH, string tenMH, string maKhoa, string maGV)
        {
            l = new DTO_MonHoc(idMH, tenMH, maKhoa, maGV);   
        }    

        // Hiển thị tất cả thông tin từ MonHoc
        public DataTable selectQuery()
        {
            string s = "SELECT * FROM MonHoc";
            return Connection.selectQuery(s);
        }
        // Hiển thị thông tin TenMH và TenGV
        public DataTable selectLichHoc()
        {
            string s = "SELECT Ten_MH, HoTen FROM MonHoc, GiangVien WHERE MonHoc.Ma_GV = GiangVien.ID_GV";
            return Connection.selectQuery(s);
        }
    }
}
