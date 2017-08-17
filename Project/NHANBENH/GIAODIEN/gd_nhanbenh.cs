using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ConnDb;

namespace NHANBENH.GIAODIEN
{
    public partial class Gd_nhanbenh : Form
    {
        public Gd_nhanbenh()
        {
            InitializeComponent();
        }
        private void Gv_danhsachbenhnhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_hoten.Text = gv_danhsachbenhnhan.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception){

            }
        }   
        private void mtxtTuoi_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(mtxtTuoi.Text))
            {
                chkSA.Visible = false;
                chkSA.Checked = false;
                chkXN.Visible = false;
                chkXN.Checked = false;
            }
            else
            {
                chkSA.Visible = true;
                chkXN.Visible = true;
            }   
        }
    }
}
