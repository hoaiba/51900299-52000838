using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SinhVien
    {
        private DTO_SinhVien l;

        public DAL_SinhVien(string idSv, string hotenSv, string emailSv, string sdtSv, string matkhauSv, string phanQuyen)
        {
            l = new DTO_SinhVien(idSv, hotenSv, emailSv, sdtSv, matkhauSv, phanQuyen);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM SinhVien";
            return Connection.selectQuery(s);
        }

        // Lấy dữ liệu PhanQuyen từ SinhVien
        public string selectPhanQuyen(string email, string matkhau)
        {
            string col = "PhanQuyen";
            string s = "SELECT PhanQuyen FROM SinhVien WHERE Email = '" + email + "' and MatKhau = '" + matkhau + "'";
            return Connection.selectData(s, col);
        }

        // Lấy dữ liệu HoTen từ SinhVien
        public string selectHoTen(string email)
        {
            string col = "HoTen";
            string s = "SELECT HoTen FROM SinhVien WHERE Email = '" + email + "'";
            return Connection.selectData(s, col);
        }

        // Lấy dữ liệu ID từ SinhVien
        public string selectID(string email)
        {
            string col = "ID_SV";
            string s = "SELECT ID_SV FROM SinhVien WHERE Email = '" + email + "'";
            return Connection.selectData(s, col);
        }

        // Lấy dữ liệu MatKhau từ SinhVien
        public string selectMatkhau()
        {
            string col = "MatKhau";
            string s = "SELECT MatKhau FROM SinhVien WHERE ID_SV = '" + l.get_idSv + "'";
            return Connection.selectData(s, col);
        }

        // Đổi mật khẩu
        public void updateMatKhau()
        {
            string s = "UPDATE SinhVien SET MatKhau = '" + l.get_matkhauSv + "' WHERE ID_SV = '" + l.get_idSv + "'";
            Connection.actionQuery(s);
        }

        // Hiển thị thông tin Lớp học của SinhVien
        public DataTable selectLopSV()
        {
            string s = "SELECT ID_Lop, Ma_MH, Ten_MH, Thu, Ca FROM Lop, MonHoc WHERE Lop.Ma_MH = MonHoc.ID_MH AND Ma_SV = '" + l.get_idSv + "'";
            return Connection.selectQuery(s);
        }
    }
}
