using CMS.GIAODIEN;
using PHONGKHAM.GIAODIEN;
using System;
using System.Windows.Forms;

namespace PHONGKHAM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new gd_dangnhap());
        }
    }
}
