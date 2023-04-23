using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_PhieuVang
    {
        private string idPv, maMH, lydo, trangthai;
        private DateTime ngayvang;
        
        public string get_idPv
        {
            get { return idPv; }
            set { idPv = value; }
        }
        public string get_maMH
        {
            get { return maMH; }
            set { maMH = value; }
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
        public DateTime get_ngayvang
        {
            get { return ngayvang; }
            set { ngayvang = value; }
        }
        public DTO_PhieuVang(string idPv, DateTime ngayvang, string lydo, string trangthai, string maMH)
        {
            this.idPv = idPv;
            this.ngayvang = ngayvang;
            this.lydo = lydo;
            this.trangthai = trangthai;
            this.maMH = maMH;
        }
    }
}
