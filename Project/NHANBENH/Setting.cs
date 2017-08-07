using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Project
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
            getClientIP();
        }

        private void btnGetIP_Click(object sender, EventArgs e)
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach(IPAddress ip in host.AddressList)
            {
                if(ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                    txtServerIP.Text = localIP;
                }
            }
        }

        private void getClientIP()
        {
            IPHostEntry host;
            string localIP = "?";
            host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily.ToString() == "InterNetwork")
                {
                    localIP = ip.ToString();
                    txtServerIP.Text = localIP;
                }
            }
        }
    }
}
