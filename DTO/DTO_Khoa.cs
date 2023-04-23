using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Khoa
    {
        private string idKhoa, tenKhoa, truongKhoa, sdtKhoa, emailKhoa;

        public string get_idKhoa
        {
            get { return idKhoa; }
            set { idKhoa = value; }
        }
        public string get_tenKhoa
        {
            get { return tenKhoa; }
            set { tenKhoa = value; }
        }
        public string get_truongKhoa
        {
            get { return truongKhoa; }
            set { truongKhoa = value; }
        }
        public string get_sdtKhoa
        {
            get { return sdtKhoa; }
            set { sdtKhoa = value; }
        }
        public string get_emailKhoa
        {
            get { return emailKhoa; }
            set { emailKhoa = value; }
        }
        public DTO_Khoa(string idKhoa, string tenKhoa, string truongKhoa, string sdtKhoa, string emailKhoa)
        {
            this.idKhoa = idKhoa;
            this.tenKhoa = tenKhoa;
            this.truongKhoa = truongKhoa;
            this.sdtKhoa = sdtKhoa;
            this.emailKhoa = emailKhoa;
        }
    }
}
