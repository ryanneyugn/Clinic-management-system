using System.Windows.Forms;
using ConnDb;

namespace PHONGKHAM.GIAODIEN
{
    public partial class gd_dangnhap : Form
    {
        public gd_dangnhap()
        {
            InitializeComponent();
        }

        private void btn_thoat_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btn_ok_Click(object sender, System.EventArgs e)
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

            string connetionString = "server=localconnection;database=phongkham;uid=root;pwd=1;";
            ConnData con = new ConnData(connetionString);
            con.OpenConnec();
            string query = "SELECT * FROM phongkham.nguoidung where username=\"" + txt_tendangnhap + "\" and passwords =\"" + txt_matkhau + "\";  ";
            con.ExecuteNonQuery(query);
            con.CloseConnec();



        }
    }
}
