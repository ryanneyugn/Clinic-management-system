﻿using System.Windows.Forms;

namespace PHONGKHAM.GIAODIEN
{
    public partial class gd_sieuam : Form
    {
        private Form parent;
        private ConnDb.ConnData db;
        private System.Data.DataTable dt_dscho;
        private System.Data.DataTable dt_temp;
        private string temp_hoten;
        private string temp_address;
        private string temp_phone;
        private string temp_tuoi;
        private string temp_PARA;
        private string temp_nghenghiep;
        private string temp_tiencangd;
        private string temp_tiencanbt;

        public gd_sieuam(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            string path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "config/connection_info.cfg");
            string[] info = System.IO.File.ReadAllLines(path);
            db = new ConnDb.ConnData(info[0], info[1], info[2], info[3]);
        }

        //
        // Update gridview danh sách bệnh nhân
        //
        public bool updateGridView_dscho()
        {
            dtgv_dsbn.Rows.Clear();
            
            try
            {
                db.OpenConnection();
                string sql = "select * from danhsachcho where sieuam like '.%'";
                dt_dscho = db.ExecuteReader(sql);
                foreach (System.Data.DataRow row in dt_dscho.Rows)
                {
                    string stt = row["stt"].ToString();
                    string id = row["idBN"].ToString();
                    sql = "select * from benhnhan where idBN=" + id;
                    dt_temp = db.ExecuteReader(sql);
                    string[] bn = new string[8];
                    bn[0] = stt;
                    for (int i = 0; i < 7; i++)
                    {
                        bn[i + 1] = dt_temp.Rows[0][i].ToString();
                    }
                    dtgv_dsbn.Rows.Add(bn);
                }
                db.CloseConnection();

                try
                {
                    txt_hotenbn.Text = dtgv_dsbn.Rows[dtgv_dsbn.SelectedRows[0].Index].Cells["hoten"].Value.ToString();
                    txt_diachibn.Text = dtgv_dsbn.Rows[dtgv_dsbn.SelectedRows[0].Index].Cells["diachi"].Value.ToString();
                    txt_idbn.Text = dtgv_dsbn.Rows[dtgv_dsbn.SelectedRows[0].Index].Cells["id"].Value.ToString();
                    txt_nghenghiep.Text = dtgv_dsbn.Rows[dtgv_dsbn.SelectedRows[0].Index].Cells["nghenghiep"].Value.ToString();
                    txt_para.Text = dtgv_dsbn.Rows[dtgv_dsbn.SelectedRows[0].Index].Cells["para"].Value.ToString();
                    txt_sdtbn.Text = dtgv_dsbn.Rows[dtgv_dsbn.SelectedRows[0].Index].Cells["sdt"].Value.ToString();
                    txt_tuoibn.Text = dtgv_dsbn.Rows[dtgv_dsbn.SelectedRows[0].Index].Cells["tuoi"].Value.ToString();

                    db.OpenConnection();
                    sql = "select * from benhnhan where idBN=" + txt_idbn.Text;
                    dt_temp = db.ExecuteReader(sql);
                    db.CloseConnection();

                    txt_tiencanbn.Text = dt_temp.Rows[0]["tiencan_bt"].ToString();
                    txt_tiencangd.Text = dt_temp.Rows[0]["tiencan_gd"].ToString();
                    btn_editphieukham.Visible = true;

                    try
                    {
                        chb_sa2d.Checked = false;
                        chb_sahth.Checked = false;
                        chb_sam.Checked = false;
                        chb_sanad.Checked = false;

                        db.OpenConnection();
                        System.Data.DataTable t = db.ExecuteReader("select sieuam from danhsachcho where stt=" + dtgv_dsbn.Rows[dtgv_dsbn.SelectedRows[0].Index].Cells["stt"].Value.ToString());
                        db.CloseConnection();

                        string d = t.Rows[0][0].ToString();
                        string v = d.Trim('.');

                        string[] r = v.Split('-');

                        foreach (string s in r)
                        {
                            if (s == "Thai 2D")
                                chb_sa2d.Checked = true;
                            if (s == "Ngã âm đạo")
                                chb_sanad.Checked = true;
                            if (s == "Hình thái học")
                                chb_sahth.Checked = true;
                            if (s == "Màu")
                                chb_sam.Checked = true;
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                catch
                {
                    return false;
                }                

                return true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }


        }
        //
        // Adjust the readonly property of textboxes.
        //
        private void readonly_textboxes(bool flag)
        {
            txt_hotenbn.ReadOnly = flag;
            txt_diachibn.ReadOnly = flag;
            txt_sdtbn.ReadOnly = flag;
            txt_nghenghiep.ReadOnly = flag;
            txt_para.ReadOnly = flag;
            txt_tuoibn.ReadOnly = flag;
            txt_tiencanbn.ReadOnly = flag;
            txt_tiencangd.ReadOnly = flag;
        }


        private void gd_sieuam_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void gd_sieuam_Load(object sender, System.EventArgs e)
        {
            updateGridView_dscho();
        }

        private void btn_refreshdsbn_Click(object sender, System.EventArgs e)
        {
            txt_hotenbn.Clear();
            txt_idbn.Clear();
            txt_para.Clear();
            txt_sdtbn.Clear();
            txt_tiencanbn.Clear();
            txt_tiencangd.Clear();
            txt_tuoibn.Clear();            
            txt_diachibn.Clear();
            updateGridView_dscho();
        }

        private void dtgv_dsbn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string idbn = dtgv_dsbn.Rows[e.RowIndex].Cells[1].Value.ToString();


                try
                {
                    db.OpenConnection();
                    string sql = "select * from benhnhan where idBN=" + idbn;
                    dt_temp = db.ExecuteReader(sql);
                    db.CloseConnection();

                    txt_hotenbn.Text = dt_temp.Rows[0]["ten"].ToString();
                    txt_idbn.Text = dt_temp.Rows[0]["idBN"].ToString();
                    txt_para.Text = dt_temp.Rows[0]["PARA"].ToString();
                    txt_sdtbn.Text = dt_temp.Rows[0]["phone_num"].ToString();
                    txt_tiencanbn.Text = dt_temp.Rows[0]["tiencan_bt"].ToString();
                    txt_tiencangd.Text = dt_temp.Rows[0]["tiencan_gd"].ToString();
                    txt_tuoibn.Text = dt_temp.Rows[0]["tuoi"].ToString();
                    txt_diachibn.Text = dt_temp.Rows[0]["address"].ToString();
                    txt_nghenghiep.Text = dt_temp.Rows[0]["nghe_nghiep"].ToString();

                    btn_editphieukham.Visible = true;
                }
                catch (System.Exception)
                {
                    return;
                }

            }
            catch
            {
                return;
            }
            
            try
            {
                chb_sa2d.Checked = false;
                chb_sahth.Checked = false;
                chb_sam.Checked = false;
                chb_sanad.Checked = false;

                db.OpenConnection();
                System.Data.DataTable t = db.ExecuteReader("select sieuam from danhsachcho where stt=" + dtgv_dsbn.Rows[e.RowIndex].Cells["stt"].Value.ToString());
                db.CloseConnection();

                string d = t.Rows[0][0].ToString();
                string v = d.Trim('.');

                string[] r = v.Split('-');

                foreach(string s in r)
                {
                    if(s == "Thai 2D")
                        chb_sa2d.Checked = true;
                    if (s == "Ngã âm đạo")
                        chb_sanad.Checked = true;
                    if (s == "Hình thái học")
                        chb_sahth.Checked = true;
                    if (s == "Màu")
                        chb_sam.Checked = true;
                }
            } catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btn_editphieukham_Click(object sender, System.EventArgs e)
        {
            readonly_textboxes(false);
            btn_editphieukham.Visible = false;
            btn_accept.Visible = true;
            btn_cancel.Visible = true;

            temp_hoten = txt_hotenbn.Text;
            temp_address = txt_diachibn.Text;
            temp_phone = txt_sdtbn.Text;
            temp_tuoi = txt_tuoibn.Text;
            temp_PARA = txt_para.Text;
            temp_nghenghiep = txt_nghenghiep.Text;
            temp_tiencangd = txt_tiencangd.Text;
            temp_tiencanbt = txt_tiencanbn.Text;

            groupbox_dsbn.Enabled = false;
        }

        private void btn_accept_Click(object sender, System.EventArgs e)
        {
            readonly_textboxes(true);
            btn_editphieukham.Visible = true;
            btn_accept.Visible = false;
            btn_cancel.Visible = false;

            if (txt_hotenbn.Text != temp_hoten || txt_diachibn.Text != temp_address || txt_sdtbn.Text != temp_phone ||
                txt_tuoibn.Text != temp_tuoi || txt_para.Text != temp_PARA || txt_nghenghiep.Text != temp_nghenghiep ||
                txt_tiencangd.Text != temp_tiencangd || txt_tiencanbn.Text != temp_tiencanbt)
            {
                string sql = "update benhnhan set ten=\"" + txt_hotenbn.Text + "\", address=\"" + txt_diachibn.Text + "\", phone_num=\""
                + txt_sdtbn.Text + "\", tuoi=\"" + txt_tuoibn.Text + "\", PARA=\"" + txt_para.Text + "\", nghe_nghiep=\"" + txt_nghenghiep.Text
                + "\", tiencan_gd=\"" + txt_tiencangd.Text + "\", tiencan_bt=\"" + txt_tiencanbn.Text + "\" where idBN=" + txt_idbn.Text;
                try
                {
                    db.OpenConnection();
                    db.ExecuteNonQuery(sql);
                    db.CloseConnection();
                    updateGridView_dscho();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            groupbox_dsbn.Enabled = true;
        }

        private void btn_cancel_Click(object sender, System.EventArgs e)
        {
            btn_accept.Visible = false;
            btn_cancel.Visible = false;
            btn_editphieukham.Visible = true;
            readonly_textboxes(true);

            txt_hotenbn.Text = temp_hoten;
            txt_diachibn.Text = temp_address;
            txt_sdtbn.Text = temp_phone;
            txt_tuoibn.Text = temp_tuoi;
            txt_para.Text = temp_PARA;
            txt_nghenghiep.Text = temp_nghenghiep;
            txt_tiencangd.Text = temp_tiencangd;
            txt_tiencanbn.Text = temp_tiencanbt;

            groupbox_dsbn.Enabled = true;
        }

        private void chb_sa2d_CheckedChanged(object sender, System.EventArgs e)
        {
            
        }

        private void chb_sa2d_Click(object sender, System.EventArgs e)
        {
            if (chb_sa2d.Checked)
                chb_sa2d.Checked = false;
            else chb_sa2d.Checked = true;
        }

        private void chb_sanad_Click(object sender, System.EventArgs e)
        {
            if (chb_sanad.Checked)
                chb_sanad.Checked = false;
            else chb_sanad.Checked = true;
        }

        private void chb_sahth_Click(object sender, System.EventArgs e)
        {
            if (chb_sahth.Checked)
                chb_sahth.Checked = false;
            else chb_sahth.Checked = true;
        }

        private void chb_sam_Click(object sender, System.EventArgs e)
        {
            if (chb_sam.Checked)
                chb_sam.Checked = false;
            else chb_sam.Checked = true;
        }

        private void btn_del_Click(object sender, System.EventArgs e)
        {
            try
            {
                string query = "delete from danhsachcho where stt=" + dtgv_dsbn.SelectedRows[0].Cells["stt"].Value.ToString();

                db.OpenConnection();
                db.ExecuteNonQuery(query);
                db.CloseConnection();

                updateGridView_dscho();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.CloseConnection();
                return;
            }
        }
    }
}
