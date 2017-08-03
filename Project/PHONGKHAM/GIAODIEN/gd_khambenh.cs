using System.Windows.Forms;
using TXT;
using ConnDb;

namespace PHONGKHAM.GIAODIEN
{
    public partial class gd_khambenh : Form
    {
        private Form parent;
        private string tendangnhap;
        private string path;

        public bool updateGridView() {
            dtgv_dsbn.Rows.Clear();
            TXTOBJECT a = new TXTOBJECT(path);                  
            string[] listbn = a.read();                        
            foreach(string str in listbn)
            {
                string[] row = str.Split('-');
                if (row[2] == " true ")
                    dtgv_dsbn.Rows.Add(row);
            }            
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
            path = "F:/GIT/dsbn.txt";
        }

        private void gd_khambenh_Load(object sender, System.EventArgs e)
        {
            updateGridView();
        }

        public void Gd_khambenh_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void btn_thoat_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btn_refreshdsbn_Click(object sender, System.EventArgs e)
        {
            updateGridView();
        }

        private void dtgv_dsbn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {
                txt_hotenbn.Text = dtgv_dsbn.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_sdtbn.Text = dtgv_dsbn.Rows[e.RowIndex].Cells[1].Value.ToString();

                ConnData db = new ConnData();
                db.OpenConnection();

            } catch (System.Exception)
            {
                return;
            }
            
        }
    }
}
