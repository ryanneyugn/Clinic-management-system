using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TXT;



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
            if (hoten.Equals("") || sdt.Equals(""))
                return;
            string[] row = { hoten, sdt };
            //write file txt
            TXTOBJECT a = new TXTOBJECT("S:/Project_Clinic/ryan-repository/Project/PHONGKHAM/dsBenhNhan.txt");
            a.writeAppend(hoten, sdt);
            //display data
            gv_danhsachbenhnhan.Rows.Add(row);
            ResetAll();
            gv_danhsachbenhnhan.Visible = true;
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void gv_danhsachbenhnhan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txt_hoten.Text = gv_danhsachbenhnhan.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception){

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
        public void deleteLineTxt(int i)
        {
            TXTOBJECT a = new TXTOBJECT("S:/Project_Clinic/ryan-repository/Project/PHONGKHAM/dsBenhNhan.txt");
            string[] listbn = a.read();List<string> ds = new List<string>();
            foreach (string str in listbn)
            {
                ds.Add(str);
            }
            ds.RemoveAt(i);
            //write again
            a.writeOver(ds);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try {
                int currentRow = gv_danhsachbenhnhan.CurrentCell.RowIndex;
                gv_danhsachbenhnhan.Rows.RemoveAt(currentRow);
                deleteLineTxt(currentRow);
            } catch(Exception)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa");
            }
            
            ResetAll();
        }
    }
}
