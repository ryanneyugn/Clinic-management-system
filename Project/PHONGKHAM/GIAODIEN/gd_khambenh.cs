using System.Windows.Forms;
using TXT;

namespace PHONGKHAM.GIAODIEN
{
    public partial class gd_khambenh : Form
    {
        private Form parent;
        private string tendangnhap;

        public bool updateGridView(string path) {
            TXTOBJECT a = new TXTOBJECT(path);                  
            string[] listbn = a.read();                        
            foreach(string str in listbn)
            {
                string[] row = str.Split('-');                
                if (row[2] == " true ")
                    dtgv_dsbn.Rows.Add(row);
            }
            dtgv_dsbn.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgv_dsbn.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            dtgv_dsbn.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return true;
        }        

        public gd_khambenh(Form parent, string tendangnhap)
        {
            InitializeComponent();
            string text = "Bác sĩ ";
            this.tendangnhap = tendangnhap;
            string tenbs = tendangnhap;
            lbl_tenbs.Text = text + tenbs;
            this.parent = parent;
        }

        private void gd_khambenh_Load(object sender, System.EventArgs e)
        {
            updateGridView("F:/GIT/dsbn.txt");
        }

        public void Gd_khambenh_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void btn_thoat_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        
    }
}
