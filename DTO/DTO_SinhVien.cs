using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SinhVien
    {
        private string idSv, hotenSv, emailSv, sdtSv, matkhauSv, phanQuyen;

        public string get_idSv
        {
            get { return idSv; }
            set { idSv = value; }
        }
        public string get_hotenSv
        {
            get { return hotenSv; }
            set { hotenSv = value; }
        }
        public string get_emailSv
        {
            get { return emailSv; }
            set { emailSv = value; }
        }
        public string get_sdtSv
        {
            get { return sdtSv; }
            set { sdtSv = value; }
        }
        public string get_matkhauSv
        {
            get { return matkhauSv; }
            set { matkhauSv = value; }
        }
        public string get_phanQuyen
        {
            get { return phanQuyen; }
            set { phanQuyen = value; }
        }
        public DTO_SinhVien(string idSv, string hotenSv, string emailSv, string sdtSv, string matkhauSv, string phanQuyen)
        {
            this.idSv = idSv;
            this.hotenSv = hotenSv;
            this.emailSv = emailSv;
            this.sdtSv = sdtSv;
            this.matkhauSv = matkhauSv;
            this.phanQuyen = phanQuyen;
        }
    }
}
