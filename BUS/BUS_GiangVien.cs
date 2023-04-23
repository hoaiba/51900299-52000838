using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_GiangVien
    {
        public DAL_GiangVien l;

        public BUS_GiangVien(string idGv, string hotenGv, string emailGv, string sdtGv, string matkhauGv, string maKhoa, string phanQuyen)
        {
            l = new DAL_GiangVien(idGv, hotenGv, emailGv, sdtGv, matkhauGv, maKhoa, phanQuyen);
        }

        public void addQuery()
        {
            l.addQuery();
        }

        public void updateQuery()
        {
            l.updateQuery();
        }

        public void deleteQuery()
        {
            l.deleteQuery();
        }

        // Hiển thị tất cả thông tin trong GiangVien
        public DataTable selectQuery()
        {
            return l.selectQuery();
        }

        // Hiển thị thông tin GiangVien cho SinhVien
        public DataTable selectPhanQuyenG()
        {
            return l.selectPhanQuyenG();
        }

        // Lấy dữ liệu PhanQuyen từ GiangVien
        public string selectPhanQuyen(string email, string matkhau)
        {
            return l.selectPhanQuyen(email, matkhau);
        }

        // Lấy dữ liệu HoTen từ GiangVien
        public string selectHoTen(string email)
        {
            return l.selectHoTen(email);
        }
    }
}
