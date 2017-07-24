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
    public partial class gd_quanlykho : Form
    {
        private Form parent;
        public gd_quanlykho(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void gd_quanlykho_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
        
        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
