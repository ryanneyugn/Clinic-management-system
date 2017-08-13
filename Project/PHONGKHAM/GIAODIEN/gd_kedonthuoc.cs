using System.Windows.Forms;
using System.Data;
using ConnDb;
using MySql.Data.MySqlClient;

namespace PHONGKHAM.GIAODIEN
{
    public partial class Gd_kedonthuoc : Form
    {
        private string[] info;
        private string sqldatetime;
        private ConnData db;
        private DataTable dsthuoc;        
        private string idpk;

        //
        // Constructors
        //
        public Gd_kedonthuoc()
        {
            InitializeComponent();
            dtgv_donthuoc.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgv_dsthuoc.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            string path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "config/connection_info.cfg");
            string[] coninfo = System.IO.File.ReadAllLines(path);
            db = new ConnData(coninfo[0], coninfo[1], coninfo[2], coninfo[3]);            
        }

        public Gd_kedonthuoc(string[] info, string sqldatetime, string idpk)
        {
            InitializeComponent();
            dtgv_donthuoc.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgv_dsthuoc.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.info = info;
            this.sqldatetime = sqldatetime;
            this.idpk = idpk;
            string path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "config/connection_info.cfg");
            string[] coninfo = System.IO.File.ReadAllLines(path);
            db = new ConnData(coninfo[0], coninfo[1], coninfo[2], coninfo[3]);
        }        

        //
        // Update datagridview danh sách các loại thuốc
        //
        private void update_gridview_dsthuoc(string query)
        {
            dtgv_dsthuoc.Rows.Clear();            

            try
            {
                db.OpenConnection();
                dsthuoc = db.ExecuteReader(query);

                foreach(DataRow row in dsthuoc.Rows)
                {
                    dtgv_dsthuoc.Rows.Add(row.ItemArray);
                }
                db.CloseConnection();
            } catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //
        // Generated methods
        //
        private void Gd_kedonthuoc_Load(object sender, System.EventArgs e)
        {
            txt_hotenbn.Text = info[0];
            txt_tuoibn.Text = info[1];
            txt_diachi.Text = info[2];
            txt_sdt.Text = info[3];
            txt_chandoan.Text = info[4];
            dtgv_donthuoc.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgv_dsthuoc.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            lbl_idpk.Text = "ID phiếu khám:" + idpk;

            update_gridview_dsthuoc("select * from thuoc");
        }       

        private void btn_tim_Click(object sender, System.EventArgs e)
        {            
            string key = txt_timkiem.Text;
            if (key == "search...")
                return;
            string query = "SELECT* FROM qlpk.thuoc WHERE(idThuoc LIKE '%" + key + "%') OR(ten_thuoc  LIKE '%" + key + "%') or(dvt LIKE '%" + key + "%') or(so_luong LIKE '%" + key + "%') or(gia_mua LIKE '%" + key + "%') or(gia_ban LIKE '%" + key + "%') or(han_sd LIKE '%" + key + "%');";
            update_gridview_dsthuoc(query);
        }

        private void btn_add_Click(object sender, System.EventArgs e)
        {                        
            string idthuoc = dtgv_dsthuoc.Rows[dtgv_dsthuoc.SelectedRows[0].Index].Cells["id"].Value.ToString();
            string tenthuoc = dtgv_dsthuoc.Rows[dtgv_dsthuoc.SelectedRows[0].Index].Cells["ten_thuoc"].Value.ToString();
            string dongia = dtgv_dsthuoc.Rows[dtgv_dsthuoc.SelectedRows[0].Index].Cells["giaban"].Value.ToString();
            foreach(DataGridViewRow r in dtgv_donthuoc.Rows)
            {
                if(r.Cells["idthuoc"].Value.ToString() == idthuoc)
                {
                    MessageBox.Show("Loại thuốc này đã được thêm vào đơn thuốc trước đó, xin vui lòng kiểm tra lại.");
                    return;
                }
            }
            string[] row = { idthuoc, tenthuoc, "", dongia, "", "", "" };
            dtgv_donthuoc.Rows.Add(row);
        }

        private void btn_del_Click(object sender, System.EventArgs e)
        {
            try
            {
                dtgv_donthuoc.Rows.RemoveAt(dtgv_donthuoc.SelectedRows[0].Index);
            } catch (System.Exception ex)
            {
                MessageBox.Show("Xin hãy chọn loại thuốc cần xóa khỏi đơn thuốc. Err: " + ex.Message);
            }
            
        }

        private void btn_print_Click(object sender, System.EventArgs e)
        {
            string query = "insert into toathuoc (ngay_lap, so_ngay, loi_dan, tong_tien, idPhieuKham) values ('" + lbl_digitalclock.Text + "', '" + txt_songay.Text + "', '" + txt_loidan.Text + "', '" + txt_tongtien.Text + "', '" + idpk + "')";

            try
            {
                db.OpenConnection();
                db.ExecuteNonQuery(query);
                db.CloseConnection();
            } catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }        
        
        private void txt_timkiem_Leave(object sender, System.EventArgs e)
        {
            if (txt_timkiem.Text == "")
            {
                update_gridview_dsthuoc("select* from thuoc");
                txt_timkiem.Text = "search...";
            }                
        }

        private void txt_timkiem_Enter(object sender, System.EventArgs e)
        {
            if(txt_timkiem.Text == "search...")
                txt_timkiem.Clear();
        }

        private void btn_exit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        //
        // Digital clock
        //
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            lbl_digitalclock.Text = System.DateTime.Now.ToString();
        }
    }
}
