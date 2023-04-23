using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhieuBu
    {
        private DTO_PhieuBu l;

        public DAL_PhieuBu(string idPb, DateTime ngaybu, string trangthai, string maPv) 
        {
            l = new DTO_PhieuBu(idPb, ngaybu, trangthai, maPv);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM PhieuBu";
            return Connection.selectQuery(s);
        }

        // Thêm dữ liệu PhieuBu
        public void addPhieuBu()
        {
            string s = "INSERT INTO PhieuBu(ID_PB, NgayBu, Ma_PV) VALUES('" + l.get_idPb + "', '" + l.get_ngaybu + "', '" + l.get_maPv + "')";
            Connection.actionQuery(s);
        }

        // Hiển thị thông tin PhieuBu 
        public DataTable selectPhieuBuGV(string id)
        {
            string s = "SELECT ID_PB, NgayBu, Ma_PV, Ten_MH, Ma_GV, PhieuBu.TrangThai FROM PhieuBu, PhieuVang, MonHoc WHERE PhieuBu.Ma_PV = PhieuVang.ID_PV AND MonHoc.ID_MH = PhieuVang.Ma_MH AND Ma_GV = '" + id + "'";
            return Connection.selectQuery(s);
        }

        // Cập nhật dữ liệu Duyệt 
        public void updatePhieuVangDuyet()
        {
            string s = "UPDATE PhieuBu SET TrangThai = N'" + l.get_trangthai + "' WHERE ID_PB = '" + l.get_idPb + "'";
            Connection.actionQuery(s);
        }

        // Cập nhật dữ liệu Không Duyệt 
        public void updatePhieuVangKhongDuyet()
        {
            string s = "UPDATE PhieuBu SET TrangThai = N'" + l.get_trangthai + "' WHERE ID_PB = '" + l.get_idPb + "'";
            Connection.actionQuery(s);
        }
    }
}
