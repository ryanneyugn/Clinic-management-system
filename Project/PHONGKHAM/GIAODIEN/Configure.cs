using System;
using System.Windows.Forms;
using System.IO;

namespace PHONGKHAM.GIAODIEN
{
    public partial class Configure : Form
    {
        public Configure()
        {
            InitializeComponent();            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {           
            string dir = System.IO.Directory.GetCurrentDirectory();
            string path = Path.Combine(dir, "config/connection_info.cfg");

            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(txt_sv.Text);
            sw.WriteLine(txt_db.Text);
            sw.WriteLine(txt_uid.Text);
            sw.WriteLine(txt_pw.Text);
            sw.Close();

            Close();
        }
    }
}
