using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NHANBENH.GIAODIEN
{
    public partial class Gd_nhanbenh : Form
    {
        private ConnDb.ConnData db;
        public Gd_nhanbenh()
        {
            InitializeComponent();
            string path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "config/connection_info.cfg");
            string[] coninfo = System.IO.File.ReadAllLines(path);
            db = new ConnDb.ConnData(coninfo[0], coninfo[1], coninfo[2], coninfo[3]);
            autoCompleteText();
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
        void autoCompleteText()
        {
            AutoCompleteStringCollection lst = new AutoCompleteStringCollection();

            String query = "select * from benhnhan";
            MySqlDataReader myReader;
            db.OpenConnection();
            myReader = db.Command.ExecuteReader();
            while (myReader.Read())
            {
                string str = myReader.GetString("ten");
                lst.Add(str);
            }
            txt_hoten.AutoCompleteCustomSource = lst;
        }
    }
}
