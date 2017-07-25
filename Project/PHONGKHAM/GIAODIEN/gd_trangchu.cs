using System;
using System.Windows.Forms;

namespace PHONGKHAM.GIAODIEN
{
    public partial class gd_trangchu : Form
    {
        private Form parent;
        private string tendangnhap;

        public gd_trangchu(Form parent, string tendangnhap)
        {
            InitializeComponent();
            this.parent = parent;
            this.tendangnhap = tendangnhap;
        }        

        private void Btn_khambenh_Click(object sender, EventArgs e)
        {            
            Form f = new gd_khambenh(this, tendangnhap);
            f.Show();
            Hide();            
        }

        private void Btn_thongke_Click(object sender, EventArgs e)
        {
            Form f = new gd_thongke(this);
            f.Show();
            Hide();
        }

        private void Btn_quanlykho_Click(object sender, EventArgs e)
        {
            Form f = new gd_quanlykho(this);
            f.Show();
            Hide();
        }

        private void gd_trangchu_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();               
        }

        private void btn_sieuam_Click(object sender, EventArgs e)
        {
            Form f = new gd_sieuam(this);
            f.Show();
            Hide();
        }
    }
}
