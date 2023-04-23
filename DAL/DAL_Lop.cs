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

        // Hiển thị thông tin danh sách Lớp mà GV đang dạy
        public DataTable selectLopGV(string id)
        {
            string s = "SELECT ID_Lop, Ma_MH, Ten_MH, Thu, Ca FROM Lop, MonHoc WHERE Lop.Ma_MH = MonHoc.ID_MH AND Ma_GV = '" + id + "'";
            return Connection.selectQuery(s);
        }

        // Hiển thị thông tin lớp học vắng cho SinhVien
        public DataTable selectLopVang()
        {
            string s = "SELECT Lop.Ma_MH, Ten_MH, Thu, Ca, NgayVang, LyDo FROM Lop, MonHoc, PhieuVang WHERE Lop.Ma_MH = MonHoc.ID_MH AND MonHoc.ID_MH = PhieuVang.Ma_MH AND Ma_SV = '" + l.get_maSV + "' AND TrangThai = N'Chấp thuận'";
            return Connection.selectQuery(s);
        }

        // Hiểu thị thông tin lớp học bù cho SinhVien
        public DataTable selectLopBu()
        {
            string s = "SELECT Lop.Ma_MH, Ten_MH, Thu, Ca, NgayBu FROM Lop, MonHoc, PhieuBu, PhieuVang WHERE Lop.Ma_MH = MonHoc.ID_MH AND PhieuVang.ID_PV = PhieuBu.Ma_PV AND PhieuVang.Ma_MH = MonHoc.ID_MH AND Ma_SV = '" + l.get_maSV + "' AND PhieuBu.TrangThai = N'Chấp thuận'";
            return Connection.selectQuery(s);
        }
    }
}
