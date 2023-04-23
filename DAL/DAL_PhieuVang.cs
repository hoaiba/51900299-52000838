using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_PhieuVang
    {
        private DTO_PhieuVang l;

        public DAL_PhieuVang(string idPv, DateTime ngayvang, string lydo, string trangthai, string maMH) 
        { 
            l = new DTO_PhieuVang(idPv, ngayvang, lydo, trangthai, maMH);
        }

        public DataTable selectQuery()
        {
            string s = "SELECT * FROM PhieuVang";
            return Connection.selectQuery(s);
        }

        // Thêm dữ liệu PhieuVang
        public void addPhieuVang()
        {
            string s = "INSERT INTO PhieuVang(ID_PV, NgayVang, LyDo, Ma_MH) VALUES('" + l.get_idPv + "', '" + l.get_ngayvang + "', N'" + l.get_lydo + "', '" + l.get_maMH + "')";
            Connection.actionQuery(s);
        }

        // Hiển thị thông tin PhieuVang theo GiangVien dạy MonHoc
        public DataTable selectPhieuVangGV(string id)
        {
            string s = "SELECT ID_PV, NgayVang, LyDo, Ma_MH, Ten_MH, Thu, Ca, TrangThai FROM PhieuVang, MonHoc WHERE PhieuVang.Ma_MH = MonHoc.ID_MH AND Ma_GV = '" + id + "'";
            return Connection.selectQuery(s);
        }

        // Cập nhật dữ liệu Duyệt 
        public void updatePhieuVangDuyet()
        {
            string s = "UPDATE PhieuVang SET TrangThai = N'" + l.get_trangthai + "' WHERE ID_PV = '" + l.get_idPv + "'";
            Connection.actionQuery(s);
        }

        // Cập nhật dữ liệu Không Duyệt 
        public void updatePhieuVangKhongDuyet()
        {
            string s = "UPDATE PhieuVang SET TrangThai = N'" + l.get_trangthai + "' WHERE ID_PV = '" + l.get_idPv + "'";
            Connection.actionQuery(s);
        }
    }
}
