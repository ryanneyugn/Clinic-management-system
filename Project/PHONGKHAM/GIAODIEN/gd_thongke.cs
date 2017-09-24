using System.Windows.Forms;

namespace PHONGKHAM.GIAODIEN
{
    public partial class gd_thongke : Form
    {
        private Form parent;
        private ConnDb.ConnData db;
        private System.Data.DataTable dt;

        // update gridview
        private void updateGridview()
        {
            dataGridView1.Rows.Clear();

            try
            {
                db.OpenConnection();
                dt = db.ExecuteReader("select * from phieukham");
                db.CloseConnection();

                foreach (System.Data.DataRow r in dt.Rows)
                {
                    string[] row = new string[6];
                    string tenbn;
                   
                    db.OpenConnection();
                    System.Data.DataTable temp = db.ExecuteReader("select ten from benhnhan where idBN=" + r["idBN"].ToString());
                    db.CloseConnection();

                    tenbn = temp.Rows[0][0].ToString();                    

                    row[0] = r["idPhieuKham"].ToString();
                    row[1] = r["idBN"].ToString();
                    row[2] = tenbn;
                    row[3] = r["ngay_lap"].ToString();
                    row[4] = r["ten_BS"].ToString();
                    row[5] = r["chan_doan"].ToString();

                    dataGridView1.Rows.Add(row);
                }

            } catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }            
        }

        // Search function
        private void search(string key)
        {
            dataGridView1.Rows.Clear();

            try
            {
                db.OpenConnection();
                dt = db.ExecuteReader("select * from phieukham");
                db.CloseConnection();

                foreach (System.Data.DataRow r in dt.Rows)
                {
                    string[] row = new string[6];
                    string tenbn;

                    db.OpenConnection();
                    System.Data.DataTable temp = db.ExecuteReader("select ten from benhnhan where idBN=" + r["idBN"].ToString());
                    db.CloseConnection();

                    tenbn = temp.Rows[0][0].ToString();

                    row[0] = r["idPhieuKham"].ToString();
                    row[1] = r["idBN"].ToString();
                    row[2] = tenbn;
                    row[3] = r["ngay_lap"].ToString();
                    row[4] = r["ten_BS"].ToString();
                    row[5] = r["chan_doan"].ToString();

                    dataGridView1.Rows.Add(row);
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public gd_thongke(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            string path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "config/connection_info.cfg");
            string[] info = System.IO.File.ReadAllLines(path);
            db = new ConnDb.ConnData(info[0], info[1], info[2], info[3]);
        }

        private void gd_thongke_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void gd_thongke_Load(object sender, System.EventArgs e)
        {
            updateGridview();
        }
    }
}
