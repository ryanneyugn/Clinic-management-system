using System.Windows.Forms;
using TXT;

namespace PHONGKHAM.GIAODIEN
{
    public partial class gd_khambenh : Form
    {
        public bool updateGridView(string path) {
            TXTOBJECT a = new TXTOBJECT(path);                  
            string[] listbn = a.read();                        
            foreach(string str in listbn)
            {
                string[] row = str.Split('-');
                dtgv_dsbn.Rows.Add(row);
            }                        
            return true;
        }

        public gd_khambenh()
        {
            InitializeComponent();
        }

        private void gd_khambenh_Load(object sender, System.EventArgs e)
        {
            updateGridView("F:/GIT/ryan-repository/Project/PHONGKHAM/dsBenhNhan.txt");
        }
    }
}
