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

        private void chkSA_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSA.Checked)
            {
                chklbSA.Visible = false;
                foreach (int i in chklbSA.CheckedIndices)
                    chklbSA.SetItemChecked(i, false);
            }
            else
                chklbSA.Visible = true;
        }

        private void chkXN_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkXN.Checked)
            {
                chklbXN.Visible = false;
                foreach (int i in chklbXN.CheckedIndices)
                    chklbXN.SetItemChecked(i, false);
            }
            else
                chklbXN.Visible = true;
        }

        private void Gd_nhanbenh_Load(object sender, EventArgs e)
        {
            txt_hoten.Focus();
        }
    }
}
