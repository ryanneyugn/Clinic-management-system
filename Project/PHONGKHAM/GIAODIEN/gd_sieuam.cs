using System.Windows.Forms;

namespace PHONGKHAM.GIAODIEN
{
    public partial class gd_sieuam : Form
    {
        private Form parent;

        public gd_sieuam(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void gd_sieuam_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
