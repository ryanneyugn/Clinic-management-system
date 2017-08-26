using System.Windows.Forms;
using ConnDb;
using System.Data;

namespace PHONGKHAM.GIAODIEN
{
    public partial class gd_khambenh : Form
    {
        private Form parent;
        private string tendangnhap;        
        private ConnData db;
        private DataTable dt_dscho;
        private DataTable dt_temp;
        private DataTable dt_lskb;
        private DataTable dt_donthuoccu;
        private DataTable dt_chitietthuoc;
        private string temp_hoten;
        private string temp_address;
        private string temp_phone;
        private string temp_tuoi;
        private string temp_PARA;
        private string temp_nghenghiep;
        private string temp_tiencangd;
        private string temp_tiencanbt;        

        public gd_khambenh(Form parent, string tendangnhap)
        {
            InitializeComponent();            
            string text = "Bác sĩ ";            
            this.tendangnhap = tendangnhap;
            string tenbs = tendangnhap;
            lbl_tenbs.Text = text + tenbs;                        
            this.parent = parent;
            string path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(),"config/connection_info.cfg");
            string[] info = System.IO.File.ReadAllLines(path);           
            db = new ConnData(info[0], info[1], info[2], info[3]);
            dt_dscho = new DataTable();
            dt_lskb = new DataTable();
        }
       
        //
        // Update datagridview "danh sách bệnh nhân".
        //
        public bool updateGridView_dscho()
        {
            dtgv_dsbn.Rows.Clear();
            txt_chandoan.Clear();
            try
            {
                db.OpenConnection();
                string sql = "select * from danhsachcho where khambenh=\"y\"";
                dt_dscho = db.ExecuteReader(sql);
                foreach (DataRow row in dt_dscho.Rows)
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
                } catch 
                {                    
                    return false;
                }                

                updategridview_lskb(txt_idbn.Text);
                                
                return true;
            } catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            
        }
        //
        // Update datagridview "lịch sử khám bệnh"
        //        
        public bool updategridview_lskb(string idbn)
        {
            btn_xemdonthuoccu.Enabled = false;
            txt_chandoan.Clear();

            try
            {
                dtgv_lskb.Rows.Clear();
                db.OpenConnection();
                string sql = "select * from phieukham where idBN=" + idbn;
                dt_temp = db.ExecuteReader(sql);
                db.CloseConnection();

                foreach (DataRow row in dt_temp.Rows)
                {
                    string[] r = { row["idPhieuKham"].ToString(), row["ngay_lap"].ToString(), row["chan_doan"].ToString(), row["ten_BS"].ToString() };
                    dtgv_lskb.Rows.Add(r);
                }

                btn_xemdonthuoccu.Enabled = false;
                string idpk = dtgv_lskb.Rows[dtgv_lskb.SelectedRows[0].Index].Cells[0].Value.ToString();

                try
                {
                    db.OpenConnection();

                    string query = "select * from toathuoc where idPhieuKham=" + idpk;

                    dt_donthuoccu = db.ExecuteReader(query);

                    if (dt_donthuoccu.Rows.Count < 1)
                    {
                        db.CloseConnection();
                        return false;
                    }

                    string idToaThuoc = dt_donthuoccu.Rows[0]["idToaThuoc"].ToString();

                    query = "select * from chitietthuoc where idToaThuoc=" + idToaThuoc;

                    dt_chitietthuoc = db.ExecuteReader(query);

                    btn_xemdonthuoccu.Enabled = true;

                    db.CloseConnection();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    db.CloseConnection();
                    return false;
                }

                return true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
        //
        // Digital clock
        //
        private void timer1_Tick(object sender, System.EventArgs e)
        {
            lbl_currentdate.Text = System.DateTime.Now.ToString();            
        }

        //
        // Gennerated events
        //
        private void gd_khambenh_Load(object sender, System.EventArgs e)
        {
            updateGridView_dscho();
            dtgv_dsbn.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dtgv_lskb.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;            
        }

        public void Gd_khambenh_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }

        private void btn_thoat_Click(object sender, System.EventArgs e)
        {
            Close();
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
            txt_chandoan.Clear();
            txt_diachibn.Clear();
            updateGridView_dscho();                        
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

            groupbox_dsbn.Enabled = groupbox_lskb.Enabled = groupbox_chandoan.Enabled = groupbox_control.Enabled = false;            
        }        

        private void btn_accept_Click(object sender, System.EventArgs e)
        {
            readonly_textboxes(true);
            btn_editphieukham.Visible = true;
            btn_accept.Visible = false;
            btn_cancel.Visible = false;

            if(txt_hotenbn.Text != temp_hoten || txt_diachibn.Text != temp_address || txt_sdtbn.Text != temp_phone ||
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
            groupbox_dsbn.Enabled = groupbox_lskb.Enabled = groupbox_chandoan.Enabled = groupbox_control.Enabled = true;
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

            groupbox_dsbn.Enabled = groupbox_lskb.Enabled = groupbox_chandoan.Enabled = groupbox_control.Enabled = true;
        }
       
        private void btn_xemdonthuoccu_Click(object sender, System.EventArgs e)
        {
            Form f = new gd_thongtintoathuoc(dt_donthuoccu, dt_chitietthuoc);
            f.Show();
        }

        private void txt_chandoan_TextChanged(object sender, System.EventArgs e)
        {
            if (txt_chandoan.TextLength >= 1)
                btn_kedonthuoc.Enabled = true;
            else
                btn_kedonthuoc.Enabled = false;

        }

        private void btn_kedonthuoc_Click(object sender, System.EventArgs e)
        {
            db.OpenConnection();

            string sqldatetime = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "insert into phieukham (ngay_lap, ten_BS, chan_doan, idBN) values('" + sqldatetime + "', '" + tendangnhap + "', '" + txt_chandoan.Text + "', '" + txt_idbn.Text + "')";

            try
            {
                db.ExecuteNonQuery(query);

                //Look for current idphieukham
                DataTable dt = db.ExecuteReader("select idPhieuKham from phieukham where ngay_lap='" + sqldatetime + "';");
                string idpk = dt.Rows[0][0].ToString();                

                query = "delete from danhsachcho where idBN=" + txt_idbn.Text;

                try
                {
                    try
                    {
                        string[] info = { txt_hotenbn.Text, txt_tuoibn.Text, txt_diachibn.Text, txt_sdtbn.Text, txt_chandoan.Text };
                        Form f = new Gd_kedonthuoc(info, sqldatetime, idpk);
                        f.ShowDialog(this);
                    } catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        db.CloseConnection();
                        return;
                    }

                    db.ExecuteNonQuery(query);
                    db.CloseConnection();
                    updateGridView_dscho();                    
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            } catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            db.CloseConnection();
        }

        private void dtgv_lskb_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_xemdonthuoccu.Enabled = false;
            try
            {
                string idpk = dtgv_lskb.Rows[e.RowIndex].Cells[0].Value.ToString();

                try
                {
                    db.OpenConnection();

                    string query = "select * from toathuoc where idPhieuKham=" + idpk;

                    dt_donthuoccu = db.ExecuteReader(query);

                    if (dt_donthuoccu.Rows.Count < 1)
                    {
                        db.CloseConnection();
                        return;
                    }

                    string idToaThuoc = dt_donthuoccu.Rows[0]["idToaThuoc"].ToString();

                    query = "select * from chitietthuoc where idToaThuoc=" + idToaThuoc;

                    dt_chitietthuoc = db.ExecuteReader(query);

                    btn_xemdonthuoccu.Enabled = true;

                    db.CloseConnection();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    db.CloseConnection();
                    return;
                }
            } catch
            {
                return;
            }                       
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

                updategridview_lskb(idbn);
            } catch
            {
                return;
            }
        }
    }
}