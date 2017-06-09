using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace Project.GIAODIEN
{
    public partial class gd_nhanbenh : Form
    {
        public gd_nhanbenh()
        {
            InitializeComponent();
        }
        List<String> ds_benhnhan = new List<String>();
        private void btn_XepVaoHangDoi_Click(object sender, EventArgs e)
        {
            ds_benhnhan.Add(txt_hoten.Text);
            gv_danhsachbenhnhan.DataSource = ds_benhnhan;
        }
    }
}
