using DTO;
using System;
using System.Collections.Generic;
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

        // Lấy dữ liệu PhanQuyen từ SinhVien
        public string selectPhanQuyen(string email, string matkhau)
        {
            string col = "PhanQuyen";
            string s = "SELECT PhanQuyen FROM SinhVien WHERE Email = '" + email + "' and MatKhau = '" + matkhau + "'";
            return Connection.selectPhanQuyen(s, col);
        }

        // Lấy dữ liệu HoTen từ SinhVien
        public string selectHoTen(string email)
        {
            string col = "HoTen";
            string s = "SELECT HoTen FROM SinhVien WHERE Email = '" + email + "'";
            return Connection.selectHoTen(s, col);
        }

        // Lấy dữ liệu ID từ SinhVien
        public string selectID(string email)
        {
            string col = "ID_SV";
            string s = "SELECT ID_SV FROM SinhVien WHERE Email = '" + email + "'";
            return Connection.selectHoTen(s, col);
        }
    }
}
