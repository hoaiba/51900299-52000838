using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Lop
    {
        private string idLop, maMH, maSV;

        public string get_idLop
        {
            get { return idLop; }
            set { idLop = value; }
        }
        public string get_maMH
        {
            get { return maMH; }
            set { maMH = value; }
        }
        public string get_maSV
        {
            get { return maSV; }
            set { maSV = value; }
        }
        public DTO_Lop(string idLop, string maMH, string maSV)
        {
            this.idLop = idLop;
            this.maMH = maMH;
            this.maSV = maSV;
        }
    }
}
