using System.Windows.Forms;
using ConnDb;
using System.Data;

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
            
            ConnData con = new ConnData();
            if (!con.OpenConnection())
                MessageBox.Show(con.ShowErrorMessage());
            string query = "SELECT * FROM nguoidung where username=\"" + txt_tendangnhap.Text + "\" and passwords =\"" + txt_matkhau.Text + "\";  ";
            DataTable dt = con.ExecuteReader(query);
            if (!con.CloseConnection())
                MessageBox.Show(con.ShowErrorMessage());

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Tên đăng nhập và mật khẩu không trùng khớp. Hãy thử lại.");
                txt_matkhau.Clear();
                return;
            } else
            {
                Form f = new gd_trangchu(this, txt_tendangnhap.Text);
                f.Show();
                Hide();
            }            
        }
    }
}
