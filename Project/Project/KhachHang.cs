using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class KhachHang
    {
        String hoten;

        public String Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        private String sdt;

        public String Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }

        public KhachHang(String hoten, String sdt)
        {
            this.hoten = hoten;
            this.sdt = sdt;
        }

        public KhachHang()
        {
            // TODO: Complete member initialization
            this.hoten = "";
            this.sdt = "";
        }

    }
}
