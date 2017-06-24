using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PHONGKHAM.GIAODIEN
{
    public partial class gd_trangchu : Form
    {
        public gd_trangchu()
        {
            InitializeComponent();
        }

        public void frmClose()
        {

        }

        private void btn_khambenh_Click(object sender, EventArgs e)
        {
            Hide();
            Form f = new gd_khambenh();
            f.Show();
        }
    }
}
