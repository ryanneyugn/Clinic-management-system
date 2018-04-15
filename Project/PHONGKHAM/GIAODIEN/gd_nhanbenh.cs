using System;
using System.Windows.Forms;
using PHONGKHAM.GIAODIEN;

namespace CMS.GIAODIEN
{
    public partial class gd_nhanbenh : Form
    {
        private ConnDb.ConnData db;
        private System.Data.DataTable dt_dscho;
        private System.Data.DataTable dt_dsbn;
        private System.Data.DataTable dt_temp;
        private string temp_hoten;
        private string temp_address;
        private string temp_phone;
        private string temp_tuoi;
        private string temp_PARA;
        private string temp_nghenghiep;
        private string temp_tiencangd;
        private string temp_tiencanbt;
        private Form parent;        

        private void showinfo(string idbn)
        {
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
            }
            catch (System.Exception)
            {
                return;
            }
        }

        private void loaddsbn(string query)
        {
            dtgv_timkiem.Rows.Clear();            
            
            try
            {
                db.OpenConnection();
                dt_dsbn = db.ExecuteReader(query);
                db.CloseConnection();

                foreach (System.Data.DataRow r in dt_dsbn.Rows)
                {
                    dtgv_timkiem.Rows.Add(r.ItemArray);
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                db.CloseConnection();
                return;
            }            
        }

        private void updateDscho()
        {
            dtgv_dsbn.Rows.Clear();
            try
            {
                string sql = "select * from danhsachcho";
                db.OpenConnection();
                dt_dscho = db.ExecuteReader(sql);
                foreach (System.Data.DataRow row in dt_dscho.Rows)
                {
                    string stt = row["stt"].ToString();
                    string id = row["idBN"].ToString();
                    sql = "select ten from benhnhan where idBN=" + id;
                    dt_temp = db.ExecuteReader(sql);
                    string[] bn = new string[6];
                    bn[0] = stt;
                    bn[1] = id;
                    bn[2] = dt_temp.Rows[0]["ten"].ToString();
                    bn[3] = row["khambenh"].ToString();
                    bn[4] = row["sieuam"].ToString();
                    bn[5] = row["xetnghiem"].ToString();
                    dtgv_dsbn.Rows.Add(bn);
                }
                db.CloseConnection();

                if(dtgv_dsbn.SelectedRows.Count > 0)
                {
                    btn_del.Enabled = true;
                } else
                {
                    btn_del.Enabled = false;
                }

            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
                db.CloseConnection();
                return;
            }            

            if (dtgv_dsbn.Rows.Count > 0)
                btn_alter.Enabled = false;
            else btn_alter.Enabled = true;
        }

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

        public gd_nhanbenh(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            string path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "config/connection_info.cfg");
            string[] info = System.IO.File.ReadAllLines(path);
            db = new ConnDb.ConnData(info[0], info[1], info[2], info[3]);
        }

        private void gd_nhanbenh_Load(object sender, EventArgs e)
        {
            chlb_sieuam.Enabled = chlb_xetnghiem.Enabled = false;            
            txt_hotenbn.Focus();
            loaddsbn("select * from benhnhan where ten like '%" + txt_hotenbn.Text + "%'");
            updateDscho();
        }

        private void btn_refreshdsbn_Click(object sender, EventArgs e)
        {
            updateDscho();
        }

        private void dtgv_dsbn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                chb_sieuam.Checked = chb_xetnghiem.Checked = true;
                chb_sieuam.Checked = chb_xetnghiem.Checked = false;
                chb_khambenh.Checked = false;
                groupbox_dichvu.Enabled = false;

                readonly_textboxes(true);
                btn_editphieukham.Visible = false;

                string idbn = dtgv_dsbn.Rows[e.RowIndex].Cells[1].Value.ToString();
                showinfo(idbn);
                if (dtgv_dsbn.Rows[e.RowIndex].Cells["khambenh"].Value.ToString() == ".")
                    chb_khambenh.Checked = true;

                if (dtgv_dsbn.Rows[e.RowIndex].Cells["sieuam"].Value.ToString() != "")
                {                    
                    string s = dtgv_dsbn.Rows[e.RowIndex].Cells["sieuam"].Value.ToString().Trim('.');
                    string[] arr = s.Split('-');
                    chb_sieuam.Checked = true;

                    foreach(string str in arr)
                    {
                        if (str == "Thai 2D")
                            chlb_sieuam.SetItemChecked(0, true);
                        else if (str == "Ngã âm đạo")
                            chlb_sieuam.SetItemChecked(1, true);
                        else if (str == "Hình thái học")
                            chlb_sieuam.SetItemChecked(2, true);
                        else if (str == "Màu")
                            chlb_sieuam.SetItemChecked(3, true);

                    }
                }

                if (dtgv_dsbn.Rows[e.RowIndex].Cells["xetnghiem"].Value.ToString() != "")
                {
                    string s = dtgv_dsbn.Rows[e.RowIndex].Cells["xetnghiem"].Value.ToString().Trim('.');
                    string[] arr = s.Split('-');
                    chb_xetnghiem.Checked = true;

                    foreach (string str in arr)
                    {
                        if (str == "Quick stick")
                            chlb_xetnghiem.SetItemChecked(0, true);
                        else if (str == "Tổng phân tích nước tiểu")
                            chlb_xetnghiem.SetItemChecked(1, true);
                        else if (str == "Định lượng BHCG")
                            chlb_xetnghiem.SetItemChecked(2, true);
                        else if (str == "Xét nghiệm tổng quát")
                            chlb_xetnghiem.SetItemChecked(3, true);
                        else if (str == "Điện tâm đồ")
                            chlb_xetnghiem.SetItemChecked(4, true);
                        else if (str == "Rubella")
                            chlb_xetnghiem.SetItemChecked(5, true);
                        else if (str == "Viêm gan siêu vi B")
                            chlb_xetnghiem.SetItemChecked(6, true);
                        else if (str == "Bilan tiền sản giật")
                            chlb_xetnghiem.SetItemChecked(7, true);
                    }
                }

            }
            catch
            {
                return;
            }
        }

        private void btn_editphieukham_Click(object sender, EventArgs e)
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

            groupbox_dichvu.Enabled = groupbox_dsbn.Enabled = groupbox_timkiem.Enabled = false;
        }

        private void btn_accept_Click(object sender, EventArgs e)
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
                    updateDscho();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            loaddsbn("select * from benhnhan");
            groupbox_dichvu.Enabled = groupbox_dsbn.Enabled = groupbox_timkiem.Enabled = true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
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

            groupbox_dichvu.Enabled = groupbox_dsbn.Enabled = groupbox_timkiem.Enabled = true;
        }

        private void dtgv_timkiem_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string idbn = dtgv_timkiem.Rows[e.RowIndex].Cells["idbn"].Value.ToString();
                showinfo(idbn);                
                btn_editphieukham.Visible = true;
                readonly_textboxes(true);
                chb_sieuam.Checked = chb_xetnghiem.Checked = true;
                chb_sieuam.Checked = chb_xetnghiem.Checked = false;
                chb_khambenh.Checked = false;
            } catch
            {
                return;
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "delete from danhsachcho where stt=" + dtgv_dsbn.SelectedRows[0].Cells["stt"].Value.ToString();

                db.OpenConnection();
                db.ExecuteNonQuery(query);
                db.CloseConnection();

                updateDscho();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.CloseConnection();
                return;
            }
        }

        private void dtgv_timkiem_Enter(object sender, EventArgs e)
        {
            groupbox_dichvu.Enabled = true;
        }

        private void dtgv_dsbn_Enter(object sender, EventArgs e)
        {
            groupbox_dichvu.Enabled = false;
        }

        private void txt_timkiem_Enter(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "search...")
                txt_timkiem.Clear();
        }

        private void txt_timkiem_Leave(object sender, EventArgs e)
        {
            if (txt_timkiem.Text == "")
            {
                loaddsbn("select * from benhnhan");
                txt_timkiem.Text = "search...";
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            string key = txt_timkiem.Text;
            if (key == "search...")
                return;
            string query = "SELECT* FROM benhnhan WHERE(idBN LIKE '%" + key + "%') OR(ten  LIKE '%" + key + "%') or(address LIKE '%" + key + "%') or(phone_num LIKE '%" + key + "%') or(tuoi LIKE '%" + key + "%') or(PARA LIKE '%" + key + "%') or(nghe_nghiep LIKE '%" + key + "%');";
            loaddsbn(query);
        }

        private void chb_sieuam_CheckedChanged(object sender, EventArgs e)
        {
            chb_khambenh.Checked = chb_xetnghiem.Checked = false;

            if (chb_sieuam.Checked)
                chlb_sieuam.Enabled = true;
            else
            {
                chlb_sieuam.Enabled = false;
                for (int i = 0; i < 4; i++)
                    chlb_sieuam.SetItemChecked(i, false);
            }                
        }

        private void gd_nhanbenh_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void chb_xetnghiem_CheckedChanged(object sender, EventArgs e)
        {
            chb_khambenh.Checked = chb_sieuam.Checked = false;

            if (chb_xetnghiem.Checked)
                chlb_xetnghiem.Enabled = true;
            else
            {
                chlb_xetnghiem.Enabled = false;
                for (int i = 0; i < 8; i++)
                    chlb_xetnghiem.SetItemChecked(i, false);
            } 
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_diachibn.Clear();
            txt_hotenbn.Clear();
            txt_idbn.Clear();
            txt_nghenghiep.Clear();
            txt_para.Clear();
            txt_sdtbn.Clear();
            txt_tiencanbn.Clear();
            txt_tiencangd.Clear();
            txt_tuoibn.Clear();

            chb_sieuam.Checked = chb_xetnghiem.Checked = true;
            chb_sieuam.Checked = chb_xetnghiem.Checked = false;
            chb_khambenh.Checked = false;
            readonly_textboxes(false);
            btn_editphieukham.Visible = false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(chb_khambenh.Checked == false && chb_sieuam.Checked == false && chb_xetnghiem.Checked == false)
            {
                MessageBox.Show("Xin vui lòng chọn dịch vụ");
                return;
            }

            string khambenh = "";
            string sieuam = "";
            string xetnghiem = "";

            if (chb_khambenh.Checked)
                khambenh = ".";
            if(chb_sieuam.Checked)
            {
                sieuam += '.';
                if(chlb_sieuam.CheckedItems.Count > 1)
                {
                    for (int i = 0; i < chlb_sieuam.CheckedItems.Count - 1; i++)
                        sieuam += chlb_sieuam.CheckedItems[i].ToString() + "-";
                    sieuam += chlb_sieuam.CheckedItems[chlb_sieuam.CheckedItems.Count - 1].ToString();
                } else if (chlb_sieuam.CheckedItems.Count == 1)
                {
                    sieuam += chlb_sieuam.CheckedItems[0].ToString();
                }                 
            }
            if (chb_xetnghiem.Checked)
            {
                xetnghiem += '.';
                if (chlb_xetnghiem.CheckedItems.Count > 1)
                {
                    for (int i = 0; i < chlb_xetnghiem.CheckedItems.Count - 1; i++)
                        xetnghiem += chlb_xetnghiem.CheckedItems[i].ToString() + "-";
                    xetnghiem += chlb_xetnghiem.CheckedItems[chlb_xetnghiem.CheckedItems.Count - 1].ToString();
                }
                else if (chlb_xetnghiem.CheckedItems.Count == 1)
                {
                    xetnghiem += chlb_xetnghiem.CheckedItems[0].ToString();
                }
            }

            try
            {
                db.OpenConnection();
                System.Data.DataTable dt = db.ExecuteReader("select * from benhnhan where idBN='" + txt_idbn.Text +"'");
                db.CloseConnection();

                if (dt.Rows.Count < 1)
                {
                    db.OpenConnection();
                    string query = "insert into benhnhan(ten, address, phone_num, tuoi, PARA, nghe_nghiep, tiencan_gd, tiencan_bt) values('" +
                        txt_hotenbn.Text + "', '" + txt_diachibn.Text + "', '" + txt_sdtbn.Text + "', '" + txt_tuoibn.Text + "', '" + txt_para.Text + "', '" +
                        txt_nghenghiep.Text + "', '" + txt_tiencangd.Text + "', '" + txt_tiencanbn.Text + "')";

                    db.ExecuteNonQuery(query);
                    db.CloseConnection();

                    MessageBox.Show("Lưu thông tin bệnh nhân mới thành công. Vui lòng chọn bệnh nhân ở danh sách bệnh nhân để tiếp tục.");

                    txt_timkiem.Text = txt_sdtbn.Text;
                    loaddsbn("select * from benhnhan where phone_num='" + txt_sdtbn.Text + "'");
                    //db.OpenConnection();
                    //dt = db.ExecuteReader("select idBN from benhnhan where ten ='" + txt_hotenbn.Text + "' and phone_num='" + txt_sdtbn.Text + "'");
                    //db.CloseConnection();

                    //string idbn = dt.Rows[0][0].ToString();

                    //string sql = "insert into danhsachcho(idBN, khambenh, sieuam, xetnghiem) values(" + dtgv_timkiem.SelectedRows[0].Cells[0].Value.ToString() + ", '" + khambenh + "', '" + sieuam + "', '" + xetnghiem + "')";

                    //db.OpenConnection();
                    //db.ExecuteNonQuery(sql);
                    //db.CloseConnection();
                    //updateDscho();

                    return;
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.CloseConnection();
                return;
            }

            try
            {                
                string sql = "insert into danhsachcho(idBN, khambenh, sieuam, xetnghiem) values(" + txt_idbn.Text + ", '" + khambenh + "', '" + sieuam + "', '" + xetnghiem + "')";
                db.OpenConnection();
                db.ExecuteNonQuery(sql);
                db.CloseConnection();
                updateDscho();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                db.CloseConnection();
            }

            txt_diachibn.Clear();
            txt_hotenbn.Clear();
            txt_idbn.Clear();
            txt_nghenghiep.Clear();
            txt_para.Clear();
            txt_sdtbn.Clear();
            txt_tiencanbn.Clear();
            txt_tiencangd.Clear();
            txt_tuoibn.Clear();

            readonly_textboxes(false);

            chb_khambenh.Checked = chb_sieuam.Checked = chb_xetnghiem.Checked = false;
        }

        private void btn_alter_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "alter table danhsachcho auto_increment = 1";
                db.OpenConnection();
                db.ExecuteNonQuery(query);
                db.CloseConnection();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void chb_khambenh_CheckedChanged(object sender, EventArgs e)
        {
            chb_sieuam.Checked = chb_xetnghiem.Checked = false;
        }

        private void txt_hotenbn_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_hotenbn.Text) && !string.IsNullOrEmpty(txt_sdtbn.Text))
            {
                btn_reset.Enabled = true;
                if(btn_accept.Visible != true)
                    groupbox_dichvu.Enabled = true;
                btn_accept.Enabled = true;
            }
            else
            {
                btn_accept.Enabled = false;
                btn_reset.Enabled = false;
                groupbox_dichvu.Enabled = false;
            }
        }

        private void txt_sdtbn_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_hotenbn.Text) && !string.IsNullOrEmpty(txt_sdtbn.Text))
            {
                btn_reset.Enabled = true;
                if (btn_accept.Visible != true)
                    groupbox_dichvu.Enabled = true;
                btn_accept.Enabled = true;
            }
            else
            {
                btn_accept.Enabled = false;
                btn_reset.Enabled = false;
                groupbox_dichvu.Enabled = false;
            }
        }
    }
}
