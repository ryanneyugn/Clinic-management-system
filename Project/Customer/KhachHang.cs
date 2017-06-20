using System;

namespace Customer
{
    public class KhachHang
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

        private String diachi;

        public String Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        private DateTime ngaysinh;

        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }

        public KhachHang(String hoten, String sdt, String diachi, DateTime ngaysinh)
        {
            this.hoten = hoten;
            this.sdt = sdt;
            this.diachi = diachi;
            this.ngaysinh = ngaysinh;
        }

        public KhachHang()
        {
            // TODO: Complete member initialization
            hoten = "";
            sdt = "";
        }
    }
}
