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
        
        /// <summary>
        /// Reset data 
        /// </summary>
        void ResetAll()
        {
            txt_hoten.Clear();
            txt_diachi.Clear();
            mtxtSDT.Clear();
            mtxtNamSinh.Clear();
        }
        private void btn_XepVaoHangDoi_Click(object sender, EventArgs e)
        {
            string hoten = txt_hoten.Text;
            string sdt = mtxtSDT.Text;
            string[] row = { hoten, sdt };
            gv_danhsachbenhnhan.Rows.Add(row);
            ResetAll();
            gv_danhsachbenhnhan.Visible = true;
        }

        

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (gv_danhsachbenhnhan.SelectedRows.Count != 0) { 
                gv_danhsachbenhnhan.Rows.RemoveAt(gv_danhsachbenhnhan.SelectedRows[0].Index);
                ResetAll();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {

        }

        private void gv_danhsachbenhnhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_hoten.Text = gv_danhsachbenhnhan.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception ex){

            }
        }

        private void cbDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDichVu.SelectedItem.Equals("Xét nghiệm"))
                chklbXetNghiem.Visible = true;
            else
                chklbXetNghiem.Visible = false;
            if (cbDichVu.SelectedItem.Equals("Khám + siêu âm"))
                chklbSA.Visible = true;
            else
                chklbSA.Visible = false;
        }
    }
}
