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
        
        public DAL_MonHoc(string idMH, string tenMH, string thu, int ca, string maKhoa, string maGV)
        {
            l = new DTO_MonHoc(idMH, tenMH, thu, ca, maKhoa, maGV);   
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

        // Hiển thị thông tin Lịch giảng dạy của GiangVien
        public DataTable selectLichGV()
        {
            string s = "SELECT * FROM MonHoc WHERE Ma_GV = '" + l.get_maGV + "'";
            return Connection.selectQuery(s);
        }
    }
}
