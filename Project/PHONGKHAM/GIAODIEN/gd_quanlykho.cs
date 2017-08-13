using System;
using System.Data;
using System.Windows.Forms;

namespace PHONGKHAM.GIAODIEN
{
    public partial class gd_quanlykho : Form
    {
        private Form parent;
        private ConnDb.ConnData db;
        private DataTable dsthuoc;
        private string temp_tenthuoc, temp_dvt, temp_giamua, temp_giaban, temp_hsd, temp_soluong;

        public gd_quanlykho(Form parent)
        {
            InitializeComponent();            
            this.parent = parent;
            string path = System.IO.Path.Combine(System.IO.Directory.GetCurrentDirectory(), "config/connection_info.cfg");
            string[] coninfo = System.IO.File.ReadAllLines(path);
            db = new ConnDb.ConnData(coninfo[0], coninfo[1], coninfo[2], coninfo[3]);
        }

        //
        // Update datagridview danh sách các loại thuốc
        //
        public void update_gridview_dsthuoc(string query)
        {
            dtgv_dsthuoc.Rows.Clear();
            btn_edit.Enabled = false;            

            try
            {
                db.OpenConnection();
                dsthuoc = db.ExecuteReader(query);

                foreach (DataRow row in dsthuoc.Rows)
                {
                    dtgv_dsthuoc.Rows.Add(row.ItemArray);
                }
                db.CloseConnection();
                
                if(dtgv_dsthuoc.Rows.Count > 0)
                {
                    txt_tenthuoc.Text = dtgv_dsthuoc.Rows[dtgv_dsthuoc.SelectedRows[0].Index].Cells["tenthuoc"].Value.ToString();
                    txt_dvt.Text = dtgv_dsthuoc.Rows[dtgv_dsthuoc.SelectedRows[0].Index].Cells["dvt"].Value.ToString();
                    txt_giamua.Text = dtgv_dsthuoc.Rows[dtgv_dsthuoc.SelectedRows[0].Index].Cells["giamua"].Value.ToString();
                    txt_giaban.Text = dtgv_dsthuoc.Rows[dtgv_dsthuoc.SelectedRows[0].Index].Cells["giaban"].Value.ToString();
                    txt_hsd.Text = dtgv_dsthuoc.Rows[dtgv_dsthuoc.SelectedRows[0].Index].Cells["hsd"].Value.ToString();
                    txt_soluong.Text = dtgv_dsthuoc.Rows[dtgv_dsthuoc.SelectedRows[0].Index].Cells["soluong"].Value.ToString();
                    btn_edit.Enabled = true;
                }

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            if (dtgv_dsthuoc.SelectedRows.Count > 0)
                btn_xoa.Enabled = true;
            else
                btn_xoa.Enabled = false;
        }   

        //
        // Generated methods
        //
        private void gd_quanlykho_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Show();
        }
        
        private void Btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gd_quanlykho_Load(object sender, EventArgs e)
        {
            update_gridview_dsthuoc("select * from thuoc");
        }

        private void btn_tim_Click(object sender, System.EventArgs e)
        {
            string key = txt_timkiem.Text;
            if (key == "search...")
                return;
            string query = "SELECT* FROM qlpk.thuoc WHERE(idThuoc LIKE '%" + key + "%') OR(ten_thuoc  LIKE '%" + key + "%') or(dvt LIKE '%" + key + "%') or(so_luong LIKE '%" + key + "%') or(gia_mua LIKE '%" + key + "%') or(gia_ban LIKE '%" + key + "%') or(han_sd LIKE '%" + key + "%');";
            update_gridview_dsthuoc(query);
        }

        private void txt_timkiem_Leave(object sender, System.EventArgs e)
        {
            if (txt_timkiem.Text == "")
            {
                update_gridview_dsthuoc("select * from thuoc");
                txt_timkiem.Text = "search...";
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            int selected = dtgv_dsthuoc.SelectedRows[0].Index;

            var confirmationResult = MessageBox.Show("Bạn có chắc muốn xóa " + dtgv_dsthuoc.Rows[selected].Cells["tenthuoc"].Value.ToString() + "?", "Xác nhận", MessageBoxButtons.YesNo);

            if (confirmationResult == DialogResult.No)
                return;
            string query = "delete from thuoc where idThuoc=" + dtgv_dsthuoc.Rows[selected].Cells["id"].Value.ToString();

            try
            {                
                db.OpenConnection();
                db.ExecuteNonQuery(query);
                db.CloseConnection();
                MessageBox.Show("Done!");
                update_gridview_dsthuoc("select * from thuoc");
            } catch(System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if(dtgv_dsthuoc.SelectedRows.Count > 0)
            {
                dtgv_dsthuoc.SelectedRows[0].Selected = false;
            }                        
            Form f = new gd_themthuoc();
            f.ShowDialog(this);
        }        
                
        private void gd_quanlykho_Activated(object sender, EventArgs e)
        {
            update_gridview_dsthuoc("select * from thuoc");
        }

        private void txt_timkiem_Enter(object sender, System.EventArgs e)
        {
            if (txt_timkiem.Text == "search...")
                txt_timkiem.Clear();
        }

        private void dtgv_dsthuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tenthuoc.Text = dtgv_dsthuoc.Rows[dtgv_dsthuoc.SelectedRows[0].Index].Cells["tenthuoc"].Value.ToString();
            txt_dvt.Text = dtgv_dsthuoc.Rows[dtgv_dsthuoc.SelectedRows[0].Index].Cells["dvt"].Value.ToString();
            txt_giamua.Text = dtgv_dsthuoc.Rows[dtgv_dsthuoc.SelectedRows[0].Index].Cells["giamua"].Value.ToString();
            txt_giaban.Text = dtgv_dsthuoc.Rows[dtgv_dsthuoc.SelectedRows[0].Index].Cells["giaban"].Value.ToString();
            txt_hsd.Text = dtgv_dsthuoc.Rows[dtgv_dsthuoc.SelectedRows[0].Index].Cells["hsd"].Value.ToString();
            txt_soluong.Text = dtgv_dsthuoc.Rows[dtgv_dsthuoc.SelectedRows[0].Index].Cells["soluong"].Value.ToString();
            btn_edit.Enabled = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_accept.Enabled = btn_cancel.Enabled = true;
            btn_edit.Enabled = false;
            groupbox_control.Enabled = groupbox_dsthuoc.Enabled = false;
            txt_tenthuoc.ReadOnly = txt_dvt.ReadOnly = txt_giaban.ReadOnly = txt_giamua.ReadOnly = txt_hsd.ReadOnly = txt_soluong.ReadOnly = false;
            temp_tenthuoc = txt_tenthuoc.Text;
            temp_soluong = txt_soluong.Text;
            temp_hsd = txt_hsd.Text;
            temp_giamua = txt_giamua.Text;
            temp_giaban = txt_giaban.Text;
            temp_dvt = txt_dvt.Text;
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            string idthuoc = dtgv_dsthuoc.Rows[dtgv_dsthuoc.SelectedRows[0].Index].Cells["id"].Value.ToString();
            btn_edit.Enabled = true;
            btn_accept.Enabled = btn_cancel.Enabled = false;
            groupbox_control.Enabled = groupbox_dsthuoc.Enabled = true;
            txt_tenthuoc.ReadOnly = txt_dvt.ReadOnly = txt_giaban.ReadOnly = txt_giamua.ReadOnly = txt_hsd.ReadOnly = txt_soluong.ReadOnly = true;
            
            if(txt_tenthuoc.Text != temp_tenthuoc || txt_dvt.Text != temp_dvt || txt_giaban.Text != temp_giaban ||
                txt_giamua.Text != temp_giamua || txt_hsd.Text != temp_hsd || txt_soluong.Text != temp_soluong)
            {
                string sql = "update thuoc set ten_thuoc=\"" + txt_tenthuoc.Text + "\", dvt=\"" + txt_dvt.Text + "\", so_luong=\"" + txt_soluong.Text + "\", gia_mua=\"" + txt_giamua.Text + "\", gia_ban=\"" + txt_giaban.Text + "\", han_sd=\"" + txt_hsd.Text + "\" where idThuoc=" + idthuoc;
                try
                {
                    db.OpenConnection();
                    db.ExecuteNonQuery(sql);
                    db.CloseConnection();
                    update_gridview_dsthuoc("select * from thuoc");
                }   catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btn_edit.Enabled = true;
            btn_accept.Enabled = btn_cancel.Enabled = false;
            groupbox_control.Enabled = groupbox_dsthuoc.Enabled = true;
            txt_tenthuoc.ReadOnly = txt_dvt.ReadOnly = txt_giaban.ReadOnly = txt_giamua.ReadOnly = txt_hsd.ReadOnly = txt_soluong.ReadOnly = true;

            txt_tenthuoc.Text = temp_tenthuoc;
            txt_dvt.Text = temp_dvt;
            txt_giaban.Text = temp_giaban;
            txt_giamua.Text = temp_giamua;
            txt_hsd.Text = temp_hsd;
            txt_soluong.Text = temp_soluong;
        }
    }
}
