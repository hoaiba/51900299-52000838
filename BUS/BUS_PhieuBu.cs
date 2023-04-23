using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_PhieuBu
    {
        public DAL_PhieuBu l;

        public BUS_PhieuBu(string idPb, DateTime ngaybu, string trangthai, string maPv)
        {
            l = new DAL_PhieuBu(idPb, ngaybu, trangthai, maPv);
        }    

        public DataTable selectQuery()
        {
            return l.selectQuery();
        }

        // Thêm dữ liệu PhieuBu
        public void addPhieuBu()
        {
            l.addPhieuBu();
        }

        // Hiển thị thông tin PhieuBu 
        public DataTable selectPhieuBuGV(string id)
        {
            return l.selectPhieuBuGV(id);
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
