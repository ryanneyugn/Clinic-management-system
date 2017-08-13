using System;
using System.Windows.Forms;

namespace PHONGKHAM.GIAODIEN
{
    public partial class gd_themthuoc : Form
    {
        public gd_themthuoc()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                string path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "config/connection_info.cfg");
                string[] coninfo = System.IO.File.ReadAllLines(path);
                ConnDb.ConnData db = new ConnDb.ConnData(coninfo[0], coninfo[1], coninfo[2], coninfo[3]);

                string insert = "insert into thuoc(ten_thuoc, dvt, so_luong, gia_mua, gia_ban, han_sd) values('" + txt_tenthuoc.Text + "', '" + txt_dvt.Text + "', '" +
                    txt_soluong.Text + "', '" + txt_giamua.Text + "', '" + txt_giaban.Text + "', '" + txt_hsd.Text + "')";                

                db.OpenConnection();
                db.ExecuteNonQuery(insert);
                db.CloseConnection();

                txt_tenthuoc.Clear();
                txt_soluong.Clear();
                txt_hsd.Clear();
                txt_giamua.Clear();
                txt_giaban.Clear();
                txt_dvt.Clear();

                Owner.Activate();
                Activate();
            } catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }
    }
}
