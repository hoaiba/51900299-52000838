using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_Lop
    {
        private DTO_Lop l;

        public DAL_Lop(string idLop, string maMH, string maSV)
        {
            l = new DTO_Lop(idLop, maMH, maSV);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM Lop";
            return Connection.selectQuery(s);
        }

        // Hiển thị thông tin danh sách Lớp mà SV đang học
        public DataTable selectLopSV(string id)
        {
            string s = "SELECT ID_Lop, Ma_MH, Ma_SV, Ten_MH FROM Lop, MonHoc WHERE Lop.Ma_MH = MonHoc.ID_MH AND Ma_SV = '" + id + "'";
            return Connection.selectQuery(s);
        }
    }
}
