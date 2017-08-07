using System.Windows.Forms;
using ConnDb;
using System.Data;
using System.IO;

namespace PHONGKHAM.GIAODIEN
{
    public partial class gd_dangnhap : Form
    {       
        
        public gd_dangnhap()
        {
            InitializeComponent();
        }

        private void Btn_thoat_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void Btn_ok_Click(object sender, System.EventArgs e)
        {
            if (txt_tendangnhap.Text == "")
            {
                MessageBox.Show("Tên đăng nhập không được để trống.");
                return;
            }

            if (txt_matkhau.Text == "")
            {
                MessageBox.Show("Mật khẩu không được để trống.");
                return;
            }

            // Connection info            

            string path = Path.Combine(Directory.GetCurrentDirectory(), "config/connection_info.cfg");
            string[] coninfo = File.ReadAllLines(path);

            ConnData con = new ConnData(coninfo[0], coninfo[1], coninfo[2], coninfo[3]);
            if (!con.OpenConnection())
            {
                MessageBox.Show(con.ShowErrorMessage());
                return;
            }
            
            string query = "SELECT * FROM bacsi where username=\"" + txt_tendangnhap.Text + "\" and password =\"" + txt_matkhau.Text + "\";  ";

            try
            {
                DataTable dt = con.ExecuteReader(query);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Tên đăng nhập và mật khẩu không trùng khớp. Hãy thử lại.");
                    txt_matkhau.Clear();
                    return;
                }
                else
                {
                    Form f = new gd_trangchu(this, dt.Rows[0]["ten_BS"].ToString());
                    f.Show();
                    Hide();
                }
            } catch(System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return;
            }
            
            if (!con.CloseConnection())
                MessageBox.Show(con.ShowErrorMessage());               
        }

        private void btn_setting_Click(object sender, System.EventArgs e)
        {
            Form f = new Configure();
            f.Show();
        }
    }
}
