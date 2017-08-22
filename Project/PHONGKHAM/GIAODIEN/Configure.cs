using System;
using System.Windows.Forms;
using System.IO;

namespace PHONGKHAM.GIAODIEN
{
    public partial class Configure : Form
    {
        private ToolTip tt;

        public Configure()
        {
            InitializeComponent();
            tt = new ToolTip();
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

        private void Configure_Load(object sender, EventArgs e)
        {
            string dir = System.IO.Directory.GetCurrentDirectory();
            string path = Path.Combine(dir, "config/connection_info.cfg");

            string[] info = File.ReadAllLines(path);

            showToolTip("Current Server: " + info[0], txt_sv);
            showToolTip("Current UID: " + info[2], txt_uid);
            showToolTip("Current Password: " + info[3], txt_pw);
            showToolTip("Current Database: " + info[1], txt_db);
        }

        private void showToolTip(string message, Control control)
        {
            tt.IsBalloon = true;
            tt.InitialDelay = 1;            
            tt.SetToolTip(control, message);            
        }
    }
}
