using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_GiangVien
    {
        private DTO_GiangVien l;

        public DAL_GiangVien(string idGv, string hotenGv, string emailGv, string sdtGv, string matkhauGv, string maKhoa, string phanQuyen)
        {
            l = new DTO_GiangVien(idGv, hotenGv, emailGv, sdtGv, matkhauGv, maKhoa, phanQuyen);
        }

        public void addQuery()
        {
            string query = "INSERT INTO GIANGVIEN VALUES('" + l.get_idGv + "', N'" + l.get_hotenGv + "', '" + l.get_emailGv +"', "+l.get_sdtGv+"', '"+l.get_matkhauGv+"', '"+l.get_maKhoa+"')";
            Connection.actionQuery(query);
        }

        public void updateQuery()
        {
            string query = "UPDATE GIANGVIEN SET HoTen = '" + l.get_hotenGv + "', Email = '" + l.get_emailGv + "', SDT = '" + l.get_sdtGv + "', MatKhau = '" + l.get_matkhauGv + "' WHERE ID_GV = '" + l.get_idGv + "'";
            Connection.actionQuery(query);
        }

        public void deleteQuery()
        {
            string query = "DELETE FROM GIANGVIEN WHERE ID_GV = '" + l.get_idGv + "'";
            Connection.actionQuery(query);
        }

        // Hiển thị tất cả thông tin trong GiangVien
        public DataTable selectQuery()
        {
            string s = "SELECT * FROM GiangVien";
            return Connection.selectQuery(s);
        }

        // Hiển thị thông tin GiangVien cho SinhVien
        public DataTable selectPhanQuyenG()
        {
            string s = "SELECT ID_GV, HoTen, Email, SDT, Ma_Khoa FROM GiangVien WHERE PhanQuyen = '" + l.get_phanQuyen +"'";
            return Connection.selectQuery(s);
        }

        // Lấy dữ liệu PhanQuyen từ GiangVien
        public string selectPhanQuyen(string email, string matkhau)
        {
            string col = "PhanQuyen";
            string s = "SELECT PhanQuyen FROM GiangVien WHERE Email = '" + email + "' and MatKhau = '" + matkhau + "'";
            return Connection.selectData(s, col);
        }

        // Lấy dữ liệu HoTen từ GiangVien
        public string selectHoTen(string email)
        {
            string col = "HoTen";
            string s = "SELECT HoTen FROM GiangVien WHERE Email = '" + email + "'"; 
            return Connection.selectData(s, col);
        }

        // Láy dữ liệu ID từ GiangVien
        public string selectID(string email)
        {
            string col = "ID_GV";
            string s = "SELECT ID_GV FROM GiangVien WHERE Email = '" + email + "'";
            return Connection.selectData(s, col);
        }

        // Hiển thị thông tin danh sách Lớp mà GV đang dạy
        public DataTable selectLopGV()
        {
            string s = "SELECT ID_Lop, Ma_MH, Ten_MH, Thu, Ca FROM Lop, MonHoc WHERE Lop.Ma_MH = MonHoc.ID_MH AND Ma_GV = '" + l.get_idGv + "'";
            return Connection.selectQuery(s);
        }

        // Hiển thị thông tin danh sách SV trong lớp
        public DataTable selectSVtrongLop()
        {
            string s = "SELECT ID_SV, HoTen, Email, Ten_MH FROM SinhVien, MonHoc, Lop WHERE MonHoc.ID_MH = Lop.Ma_MH AND SinhVien.ID_SV = Lop.Ma_SV AND Ma_GV = '" + l.get_idGv + "'";
            return Connection.selectQuery(s);
        }

        // Lấy dữ liệu MatKhau từ GiangVien
        public string selectMatkhau()
        {
            string col = "MatKhau";
            string s = "SELECT MatKhau FROM GiangVien WHERE ID_GV = '" + l.get_idGv + "'";
            return Connection.selectData(s, col);
        }

        // Đổi mật khẩu
        public void updateMatKhau()
        {
            string s = "UPDATE GiangVien SET MatKhau = '" + l.get_matkhauGv + "' WHERE ID_GV = '" + l.get_idGv + "'";
            Connection.actionQuery(s);
        }
    }
}
