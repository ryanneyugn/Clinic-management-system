using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;



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

            var list = new List<KhachHang>()
            {
                new KhachHang {Hoten=txt_hoten.Text, Sdt=txt_sdt.Text}
            };
            var bindingList = new BindingList<KhachHang>(list);
            var source = new BindingSource(bindingList, null);
            gv_danhsachbenhnhan.DataSource = source;
        }
    }
}
