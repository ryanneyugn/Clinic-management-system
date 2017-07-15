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
    public partial class gd_thongke : Form
    {
        private Form parent;
        public gd_thongke(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void gd_thongke_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
