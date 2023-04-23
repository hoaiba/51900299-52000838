using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_PhieuVang
    {
        public DAL_PhieuVang l;

        public BUS_PhieuVang(string idPv, DateTime ngayvang, string lydo, string trangthai, string maLop)
        {
            l = new DAL_PhieuVang(idPv, ngayvang, lydo, trangthai, maLop);
        }

        public DataTable selectQuery()
        {
            return l.selectQuery();
        }

        // Thêm dữ liệu PhieuVang mới
        public void addPhieuVang()
        {
            l.addPhieuVang();
        }

        // Hiển thị thông tin PhieuVang theo GiangVien dạy MonHoc
        public DataTable selectPhieuVangGV(string id)
        {
            return l.selectPhieuVangGV(id);
        }

        // Cập nhật dữ liệu Duyệt 
        public void updatePhieuVangDuyet()
        {
            l.updatePhieuVangDuyet();
        }

        // Cập nhật dữ liệu Không Duyệt 
        public void updatePhieuVangKhongDuyet()
        {
            l.updatePhieuVangKhongDuyet();
        }
    }
}
