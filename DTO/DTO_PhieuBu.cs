using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuBu
    {
        private string idPb, maPv, lydo, trangthai;
        private DateTime ngaybu;

        public string get_idPb
        {
            get { return idPb; }
            set { idPb = value; }
        }
        public string get_maPv
        {
            get { return maPv; }
            set { maPv = value; }
        }
        public DateTime get_ngaybu
        {
            get { return ngaybu; }
            set { ngaybu = value; }
        }
        public string get_lydo
        {
            get { return lydo; }
            set { lydo = value; }
        }
        public string get_trangthai
        {
            get { return trangthai; }
            set { trangthai = value; }
        }
        public DTO_PhieuBu(string idPb, DateTime ngaybu, string maPv, string lydo, string trangthai)
        {
            this.idPb = idPb;
            this.ngaybu = ngaybu;
            this.maPv = maPv;
            this.lydo = lydo;
            this.trangthai = trangthai;
        }
    }
}
