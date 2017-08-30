using ConnDb;
using System.Data;
using System.Windows.Forms;

namespace PHONGKHAM.GIAODIEN
{
    public partial class gd_thongtintoathuoc : Form
    {
        private DataTable dt_donthuoccu;
        private DataTable dt_chitietthuoc;
        private ConnData db;

        public gd_thongtintoathuoc()
        {
            InitializeComponent();
        }

        public gd_thongtintoathuoc(DataTable dt_donthuoccu, DataTable dt_chitietthuoc)
        {
            InitializeComponent();
            this.dt_donthuoccu = dt_donthuoccu;
            this.dt_chitietthuoc = dt_chitietthuoc;            
            string path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "config/connection_info.cfg");
            string[] info = System.IO.File.ReadAllLines(path);
            db = new ConnData(info[0], info[1], info[2], info[3]);
        }

        private void gd_thongtintoathuoc_Load(object sender, System.EventArgs e)
        {
            lbl_idtoathuoc.Text = "ID: " + dt_donthuoccu.Rows[0]["idToaThuoc"].ToString();
            lbl_ngaylap.Text = "Ngày lập: " + dt_donthuoccu.Rows[0]["ngay_lap"].ToString();
            lbl_songay.Text = "Số ngày: " + dt_donthuoccu.Rows[0]["so_ngay"].ToString();
            lbl_tongtien.Text = "Tổng tiền: " + dt_donthuoccu.Rows[0]["tong_tien"].ToString();
            txt_loidan.Text = dt_donthuoccu.Rows[0]["loi_dan"].ToString();
            updategridview();
        }

        private void updategridview()
        {
            foreach(DataRow row in dt_chitietthuoc.Rows)
            {
                //string idthuoc = row["idThuoc"].ToString();

                try
                {
                    
                    //string query = "select ten_thuoc,gia_ban from thuoc where idThuoc=" + idthuoc;

                    //DataTable dt =db.ExecuteReader(query);

                    //string tenthuoc = dt.Rows[0]["ten_thuoc"].ToString();
                    //string giaban = dt.Rows[0]["gia_ban"].ToString();
                    //string duongdung = row["duong_dung"].ToString();
                    //string quycach = row["quy_cach"].ToString();
                    //string sovien = row["so_vien"].ToString();

                    //string[] t = { tenthuoc, duongdung, quycach, sovien, giaban };

                    dataGridView1.Rows.Add(row.ItemArray);
                } catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
