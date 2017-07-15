using System.Windows.Forms;
using TXT;

namespace PHONGKHAM.GIAODIEN
{
    public partial class gd_khambenh : Form
    {
        private Form parent;
        public bool updateGridView(string path) {
            TXTOBJECT a = new TXTOBJECT(path);                  
            string[] listbn = a.read();                        
            foreach(string str in listbn)
            {
                string[] row = str.Split('-');
                dtgv_dsbn.Rows.Add(row);
            }
            dtgv_dsbn.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgv_dsbn.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgv_dsbn.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return true;
        }

        public void frmClose()
        {
            
        }

        public gd_khambenh(Form parent)
        {
            InitializeComponent();
            string text = "Bác sĩ ";
            string tenbs = "Thuận gay";
            lbl_tenbs.Text = text + tenbs;
            this.parent = parent;
        }

        private void gd_khambenh_Load(object sender, System.EventArgs e)
        {
            updateGridView("F:/GIT/ryan-repository/Project/PHONGKHAM/dsBenhNhan.txt");
        }

        public void Gd_khambenh_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
    }
}
