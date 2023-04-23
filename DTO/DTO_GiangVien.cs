using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_GiangVien
    {
        private string idGv, hotenGv, emailGv, sdtGv, matkhauGv, maKhoa, phanQuyen;

        public string get_idGv
        {
            get { return idGv; }
            set { idGv = value; }
        }
        public string get_hotenGv
        {
            get { return hotenGv; }
            set { hotenGv = value; }
        }
        public string get_emailGv
        {
            get { return emailGv; }
            set { emailGv = value; }
        }

        public string get_sdtGv
        {
            get { return sdtGv; }
            set { sdtGv = value; }
        }
        public string get_matkhauGv
        {
            get { return matkhauGv; }
            set { matkhauGv = value; }
        }
        public string get_maKhoa
        {
            get { return maKhoa; }
            set { maKhoa = value; }
        }
        public string get_phanQuyen
        {
            get { return phanQuyen; }
            set { phanQuyen = value; }
        }
        public DTO_GiangVien(string idGv, string hotenGv, string emailGv, string sdtGv, string matkhauGv, string maKhoa, string phanQuyen)
        {
            this.idGv = idGv;
            this.hotenGv = hotenGv;
            this.emailGv = emailGv;
            this.sdtGv = sdtGv;
            this.matkhauGv = matkhauGv;
            this.maKhoa = maKhoa;
            this.phanQuyen = phanQuyen;
        }
    }
}
