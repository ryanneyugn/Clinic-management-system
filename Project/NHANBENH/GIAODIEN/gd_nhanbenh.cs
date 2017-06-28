using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TXT;
using ConnDb;

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
            string dv = "null";
            //file.txt
            TXTOBJECT dsXN = new TXTOBJECT("S:/Project_Clinic/ryan-repository/Project/PHONGKHAM/dsXetNghiem.txt");
            TXTOBJECT dsSA = new TXTOBJECT("S:/Project_Clinic/ryan-repository/Project/PHONGKHAM/dsSieuAm.txt");
            TXTOBJECT dsKT = new TXTOBJECT("S:/Project_Clinic/ryan-repository/Project/PHONGKHAM/dsKhamThuong.txt");
            try
            {
                if (!txt_hoten.Text.Equals(""))
                {
                    if (cbDichVu.SelectedItem.Equals("Xét nghiệm"))
                    {
                        dv = chklbXetNghiem.SelectedItem.ToString();
                        string[] row = { hoten, sdt, dv };
                        //write file txt
                        dsXN.writeAppend(hoten, sdt, dv);
                        //display data
                        gv_danhsachbenhnhan.Rows.Add(row);
                        ResetAll();
                        gv_danhsachbenhnhan.Visible = true;
                    }
                    else if (cbDichVu.SelectedItem.Equals("Khám + siêu âm"))
                    {
                        dv = chklbSA.SelectedItem.ToString();
                        string[] row = { hoten, sdt, dv };
                        //write file txt
                        dsSA.writeAppend(hoten, sdt, dv);
                        //display data
                        gv_danhsachbenhnhan.Rows.Add(row);
                        ResetAll();
                        gv_danhsachbenhnhan.Visible = true;
                    }
                    else
                    {
                        dv = "null";
                        string[] row = { hoten, sdt, dv };
                        //write file txt
                        dsKT.writeAppend(hoten, sdt, dv);
                        //display data
                        gv_danhsachbenhnhan.Rows.Add(row);
                        ResetAll();
                        gv_danhsachbenhnhan.Visible = true;
                    }      
                }
                else MessageBox.Show("Vui lòng điền đủ thông tin"); ;
                }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
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
            if (gv_danhsachbenhnhan.SelectedRows.Count != -1)
            {
                DataGridViewRow row = gv_danhsachbenhnhan.SelectedRows[0];
                txt_hoten.Text = row.Cells[0].Value.ToString();
            }
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
            if(cbDichVu.Visible == true)
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
            else
            {
                chklbXetNghiem.Visible = false;
                chklbSA.Visible = false;
            }

        }
        private void deleteLineTxt(int i)
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

        private void txt_hoten_TextChanged(object sender, EventArgs e)
        {
            if (txt_hoten.Text.Equals(""))
            {
                cbDichVu.Visible = false;
                chklbXetNghiem.Visible = false;
                chklbSA.Visible = false;
            }
            else
            {
                cbDichVu.Visible = true;
            }   
        }

        private void btn_Tao_Click(object sender, EventArgs e)
        {
            string connetionString = "server=localhost;database=qlpk;uid=root;pwd=123456;";
            ConnData con = new ConnData(connetionString);
            con.OpenConnec();
            string query = "insert into benhnhan (ten, nam_sinh, address, phone_num) values('"+txt_hoten.Text+"', '"+mtxtNamSinh.Text+ "', '" + txt_diachi.Text + "', '" + mtxtSDT.Text + "')";
            con.executeNonQuery(query);
            con.CloseConnec();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int currentRow = gv_danhsachbenhnhan.CurrentCell.RowIndex;
                gv_danhsachbenhnhan.Rows.RemoveAt(currentRow);
                deleteLineTxt(currentRow);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa");
            }

            ResetAll();
        }

        public bool updateGridView(string path)
        {
            TXTOBJECT a = new TXTOBJECT(path);
            string[] listbn = a.read();
            foreach (string str in listbn)
            {
                string[] row = str.Split('-');
                gv_danhsachbenhnhan.Rows.Add(row);
            }
            gv_danhsachbenhnhan.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            gv_danhsachbenhnhan.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return true;
        }
        private void gd_nhanbenh_Load(object sender, EventArgs e)
        {
            updateGridView("S:/Project_Clinic/ryan-repository/Project/PHONGKHAM/dsXetNghiem.txt");
            updateGridView("S:/Project_Clinic/ryan-repository/Project/PHONGKHAM/dsSieuAm.txt");
            updateGridView("S:/Project_Clinic/ryan-repository/Project/PHONGKHAM/dsKhamThuong.txt");
        }
    }
}
