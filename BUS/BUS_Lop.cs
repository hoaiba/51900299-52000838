using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_Lop
    {
        public DAL_Lop l;

        public BUS_Lop(string idLop, string maMH, string maSV)
        {
            l = new DAL_Lop(idLop, maMH, maSV);
        }

        public DataTable selectQuery()
        {
            return l.selectQuery();
        }

        // Hiển thị thông tin danh sách Lớp mà SV đang học
        public DataTable selectLopSV(string id)
        {
            return l.selectLopSV(id);
        }

        // Hiển thị thông tin danh sách Lớp mà GV đang dạy
        public DataTable selectLopGV(string id)
        {
            return l.selectLopGV(id);
        }

        // Hiển thị thông tin lớp học vắng cho SinhVien
        public DataTable selectLopVang()
        {
            return l.selectLopVang();
        }

        // Hiểu thị thông tin lớp học bù cho SinhVien
        public DataTable selectLopBu()
        {
            return l.selectLopBu();
        }    
    }
}
