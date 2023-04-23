using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MonHoc
    {
        private string idMH, tenMH, maKhoa, maGV;

        public string get_idMH
        {
            get { return idMH; }
            set { idMH = value; }
        }
        public string get_tenMH
        {
            get { return tenMH; }
            set { tenMH = value; }
        }
        public string get_maKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }
        public string get_maGV
        {
            get { return maGV; }
            set { maGV = value; }
        }
        public DTO_MonHoc(string idMH, string tenMH, string maKhoa, string maGV)
        {
            this.idMH = idMH;
            this.tenMH = tenMH;
            this.maKhoa = maKhoa;
            this.maGV = maGV;
        }
    }
}
