using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_MonHoc
    {
        private string idMH, tenMH, thu, maKhoa, maGV;
        private int ca;

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
        public string get_thu
        {
            get { return thu; }
            set { thu = value; }
        }
        public int get_ca
        {
            get { return ca; }
            set { ca = value; }
        }
        public DTO_MonHoc(string idMH, string tenMH, string thu, int ca, string maKhoa, string maGV)
        {
            this.idMH = idMH;
            this.tenMH = tenMH;
            this.thu = thu;
            this.ca = ca;
            this.maKhoa = maKhoa;
            this.maGV = maGV;
        }
    }
}
