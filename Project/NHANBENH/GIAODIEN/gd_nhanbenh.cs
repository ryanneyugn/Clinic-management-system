using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
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
            update_GV();
            autoCompleteText();
        }
        private void update_GV()
        {
            gv_danhsachcho.Rows.Clear();
            db.OpenConnection();
            string qr = "select ten, address, phone_num, tuoi from benhnhan, danhsachcho where benhnhan.idBN = danhsachcho.idBN";
            DataTable ds_cho = db.ExecuteReader(qr);
            foreach(DataRow r in ds_cho.Rows)
            {
                gv_danhsachcho.Rows.Add(r.ItemArray);
            }
            db.CloseConnection();
        }
        private void Gv_danhsachbenhnhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_hoten.Text = gv_danhsachcho.Rows[e.RowIndex].Cells[0].Value.ToString();
                txt_diachi.Text = gv_danhsachcho.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSDT.Text = gv_danhsachcho.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTuoi.Text = gv_danhsachcho.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch (Exception){

            }
        }   
        private void chkSA_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSA.Checked)
            {
                chklbSA.Enabled = false;
                foreach (int i in chklbSA.CheckedIndices)
                    chklbSA.SetItemChecked(i, false);
            }
            else
                chklbSA.Enabled = true;
        }

        private void chkXN_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkXN.Checked)
            {
                chklbXN.Enabled = false;
                foreach (int i in chklbXN.CheckedIndices)
                    chklbXN.SetItemChecked(i, false);
            }
            else
                chklbXN.Enabled = true;
        }

        private void Gd_nhanbenh_Load(object sender, EventArgs e)
        {
            txt_hoten.Focus();
        }
        void autoCompleteText()
        {
            AutoCompleteStringCollection lst_hoten = new AutoCompleteStringCollection();
            AutoCompleteStringCollection lst_diachi = new AutoCompleteStringCollection();
            AutoCompleteStringCollection lst_sdt = new AutoCompleteStringCollection();
            AutoCompleteStringCollection lst_tuoi = new AutoCompleteStringCollection();

            String query = "select * from benhnhan";
            db.OpenConnection();
            MySqlCommand cmd = new MySqlCommand(query, db.Connection);
            MySqlDataReader reader;

            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string str_hoten = reader.GetString("ten");
                lst_hoten.Add(str_hoten);
                string str_diachi = reader.GetString("address");
                lst_diachi.Add(str_diachi);
                string str_sdt = reader.GetString("phone_num");
                lst_sdt.Add(str_sdt);
                string str_tuoi = reader.GetString("tuoi");
                lst_tuoi.Add(str_tuoi);
            }
            txt_hoten.AutoCompleteCustomSource = lst_hoten;
            txt_diachi.AutoCompleteCustomSource = lst_diachi;
            txtSDT.AutoCompleteCustomSource = lst_sdt;
            txtTuoi.AutoCompleteCustomSource = lst_tuoi;
            db.CloseConnection();
        }

        private void txtSDT_Leave(object sender, EventArgs e)
        {
            Regex pattern = new Regex("^[0-9]{7,11}$");
            if (!pattern.IsMatch(txtSDT.Text))
            {
                MessageBox.Show("Không hợp lệ. Yêu cầu nhập lại.");
                txtSDT.Focus();
            }
        }

        private void txtTuoi_Leave(object sender, EventArgs e)
        {
            Regex pattern = new Regex("^[0-9]{1,3}$");
            if (!pattern.IsMatch(txtTuoi.Text))
            {
                MessageBox.Show("Không hợp lệ. Yêu cầu nhập lại.");
                txtTuoi.Focus();
            }
        }

        private void txtTuoi_TextChanged_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTuoi.Text)&& !String.IsNullOrEmpty(txtSDT.Text)&& !String.IsNullOrEmpty(txt_diachi.Text)&& !String.IsNullOrEmpty(txt_hoten.Text))
            {
                chkSA.Enabled = true;
                chkXN.Enabled = true;
            }
            else
            {
                chkSA.Enabled = false;
                chkSA.Checked = false;
                chkXN.Enabled = false;
                chkXN.Checked = false;
            }
        }

        private void txt_hoten_TextChanged(object sender, EventArgs e)
        {
            //logic
            if (!String.IsNullOrEmpty(txtTuoi.Text) && !String.IsNullOrEmpty(txtSDT.Text) && !String.IsNullOrEmpty(txt_diachi.Text) && !String.IsNullOrEmpty(txt_hoten.Text))
            {
                chkSA.Enabled = true;
                chkXN.Enabled = true;
            }
            else
            {
                chkSA.Enabled = false;
                chkSA.Checked = false;
                chkXN.Enabled = false;
                chkXN.Checked = false;
            }
        }

        private void txt_diachi_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTuoi.Text) && !String.IsNullOrEmpty(txtSDT.Text) && !String.IsNullOrEmpty(txt_diachi.Text) && !String.IsNullOrEmpty(txt_hoten.Text))
            {
                chkSA.Enabled = true;
                chkXN.Enabled = true;
            }
            else
            {
                chkSA.Enabled = false;
                chkSA.Checked = false;
                chkXN.Enabled = false;
                chkXN.Checked = false;
            }
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTuoi.Text) && !String.IsNullOrEmpty(txtSDT.Text) && !String.IsNullOrEmpty(txt_diachi.Text) && !String.IsNullOrEmpty(txt_hoten.Text))
            {
                chkSA.Enabled = true;
                chkXN.Enabled = true;
            }
            else
            {
                chkSA.Enabled = false;
                chkSA.Checked = false;
                chkXN.Enabled = false;
                chkXN.Checked = false;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có xóa?", "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    string sdt = gv_danhsachcho.Rows[gv_danhsachcho.SelectedRows[0].Index].Cells[2].Value.ToString();

                    string qr = "select idBN from benhnhan where phone_num like '" + sdt + "';";
                    DataTable lst_id = db.ExecuteReader(qr);
                    string idBN = String.Empty;
                    if (lst_id.Rows.Count > 0)
                    {
                        idBN = lst_id.Rows[0]["idBN"].ToString();
                    }
                    //
                    db.OpenConnection();
                    string qr1 = "delete from danhsachcho where idBN=" + idBN + ";";
                    db.ExecuteNonQuery(qr1);
                    db.CloseConnection();
                    update_GV();
                    ResetAll();
                }
                catch { }
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {

            db.OpenConnection();
            //check new customer
            string qr = "select * from benhnhan where ten like '" + txt_hoten.Text + "' and address like '" + txt_diachi.Text + "' and phone_num like '" + txtSDT.Text + "' and tuoi like '" + txtTuoi.Text + "'";
            if (!(db.ExecuteReader(qr).Rows.Count > 0))
            {
                string qr2 = "insert into benhnhan(ten, address, phone_num, tuoi, PARA, nghe_nghiep, tiencan_gd, tiencan_bt) values('" + txt_hoten.Text + "', '" + txt_diachi.Text + "', '" + txtSDT.Text + "', " + txtTuoi.Text + ", '', '', '', '')";
                db.ExecuteNonQuery(qr2);
            }
            //get IdBN 
            string qr3 = "select idBN from benhnhan where phone_num like '" + txtSDT.Text + "';";
            DataTable lst_id = db.ExecuteReader(qr3);
            string idBN = String.Empty;
            if(lst_id.Rows.Count > 0)
            {
                idBN = lst_id.Rows[0]["idBN"].ToString();
            }
            //
            string sieu_am = "";
            string xet_nghiem = "";
            for(int i = 0; i< chklbSA.Items.Count; i++)
            {
                if (chklbSA.GetItemChecked(i))
                    sieu_am += (string)chklbSA.Items[i] + ".";
            }
            for(int j = 0; j < chklbXN.Items.Count; j++)
            {
                if (chklbXN.GetItemChecked(j))
                    xet_nghiem += (string)chklbXN.Items[j] + ".";
            }

            string qr4 = "insert into danhsachcho(idBN, khambenh, sieuam, xetnghiem) values(" + idBN + ", '', '" + sieu_am + "', '" + xet_nghiem + "')";
            
            db.ExecuteNonQuery(qr4);
            db.CloseConnection();
            update_GV();
            ResetAll();
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }
        private void ResetAll()
        {
            txt_hoten.Text = "";
            txt_diachi.Text = "";
            txtTuoi.Text = "";
            txtSDT.Text = "";
        }

        private void txt_hoten_KeyDown(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTuoi.Text) && !String.IsNullOrEmpty(txtSDT.Text) && !String.IsNullOrEmpty(txt_diachi.Text) && !String.IsNullOrEmpty(txt_hoten.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chỉnh sửa?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //int curIndex = gv_danhsachcho.CurrentRow.Index;
                        string qr = "update benhnhan set ten = '" + txt_hoten.Text + "' where phone_num like '" + txtSDT.Text + "'";
                        db.OpenConnection();
                        db.ExecuteNonQuery(qr);
                        db.CloseConnection();
                        update_GV();
                        //gv_danhsachcho.CurrentCell
                    }
                }
            }
        }

        private void txt_diachi_KeyDown(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTuoi.Text) && !String.IsNullOrEmpty(txtSDT.Text) && !String.IsNullOrEmpty(txt_diachi.Text) && !String.IsNullOrEmpty(txt_hoten.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chỉnh sửa?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string qr = "update benhnhan set address = '" + txt_diachi.Text + "' where phone_num like '" + txtSDT.Text + "'";
                        db.OpenConnection();
                        db.ExecuteNonQuery(qr);
                        db.CloseConnection();
                        update_GV();
                    }
                }
            }
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTuoi.Text) && !String.IsNullOrEmpty(txtSDT.Text) && !String.IsNullOrEmpty(txt_diachi.Text) && !String.IsNullOrEmpty(txt_hoten.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chỉnh sửa?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string qr = "update benhnhan set phone_num = '" + txtSDT.Text + "' where address like '" + txt_diachi.Text + "'";
                        db.OpenConnection();
                        db.ExecuteNonQuery(qr);
                        db.CloseConnection();
                        update_GV();
                    }
                }
            }
        }

        private void txtTuoi_KeyDown(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTuoi.Text) && !String.IsNullOrEmpty(txtSDT.Text) && !String.IsNullOrEmpty(txt_diachi.Text) && !String.IsNullOrEmpty(txt_hoten.Text))
            {
                if (e.KeyCode == Keys.Enter)
                {
                    DialogResult dialogResult = MessageBox.Show("Bạn có chỉnh sửa?", "Xác nhận", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string qr = "update benhnhan set tuoi = '" + txtTuoi.Text + "' where phone_num like '" + txtSDT.Text + "'";
                        db.OpenConnection();
                        db.ExecuteNonQuery(qr);
                        db.CloseConnection();
                        update_GV();
                    }
                }
            }
        }
    }
}
