using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_SinhVien
    {
        public DAL_SinhVien l;

        public BUS_SinhVien(string idSv, string hotenSv, string emailSv, string sdtSv, string matkhauSv, string phanQuyen)
        {
            l = new DAL_SinhVien(idSv, hotenSv, emailSv, sdtSv, matkhauSv, phanQuyen);
        }

        public DataTable selectQuery()
        {
            return l.selectQuery();
        }    

        // Lấy dữ liệu PhanQuyen từ SinhVien
        public string selectPhanQuyen(string email, string matkhau)
        {
            return l.selectPhanQuyen(email, matkhau);
        }

        // Lấy dữ liệu HoTen từ SinhVien
        public string selectHoTen(string email)
        {
            return l.selectHoTen(email);
        }

        // Lấy dữ liệu ID từ SinhVien
        public string selectID(string email)
        {
            return l.selectID(email);
        }

        // Lấy dữ liệu MatKhau từ SinhVien
        public string selectMatKhau()
        {
            return l.selectMatkhau();
        }

        // Đổi mật khẩu
        public void updateMatKhau()
        {
            l.updateMatKhau();
        }

        // Hiển thị thông tin Lớp học của SinhVien
        public DataTable selectLopSV()
        {
            return l.selectLopSV();
        }
    }
}
