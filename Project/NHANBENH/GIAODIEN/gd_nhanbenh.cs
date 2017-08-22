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

        private void Btn_XepVaoHangDoi_Click(object sender, EventArgs e)
        {
            string hoten = txt_hoten.Text;
            string sdt = mtxtSDT.Text;
            string dvSA = "null";
            string dvXN = "null";
            string dvKB = "null";
            //file.txt
            TXTOBJECT dsNB = new TXTOBJECT("F:/GIT/dsbn.txt");
            if (txt_hoten.Text.Equals(""))
            {
                return;
            }
            if (chkKB.Checked)
            {
                dvKB = "true";
            }
            else
            {
                dvKB = "null";
            }
            if (chkSA.Checked)
            {
                foreach(string tmp in chklbSA.CheckedItems)
                {
                    if(dvSA.Equals("null"))
                        dvSA = tmp;
                    else
                        dvSA += "," + tmp;
                }
            }
            else
            {
                dvSA = "null";
            }
            if (chkXN.Checked)
            {
                foreach (string tmp in chklbXetNghiem.CheckedItems)
                {
                    if (dvXN.Equals("null"))
                        dvXN = tmp;
                    else
                        dvXN += "," + tmp;
                }
            }
            else
            {
                dvXN = "null";
            }
            string[] row = { hoten, sdt, dvKB , dvSA, dvXN };
            //write file txt
            dsNB.writeAppend(hoten, sdt, dvKB, dvSA, dvXN);
            //display data
            gv_danhsachbenhnhan.Rows.Add(row);
            ResetAll();
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            ResetAll();
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
        private void DeleteLineTxt(int i)
        {
            TXTOBJECT a = new TXTOBJECT("F:/GIT/dsbn.txt");
            string[] listbn = a.read();List<string> ds = new List<string>();
            foreach (string str in listbn)
            {
                ds.Add(str);
            }
            ds.RemoveAt(i);
            //write again
            a.writeOver(ds);
        }

        private void Txt_hoten_TextChanged(object sender, EventArgs e)
        {
            if (txt_hoten.Text.Equals(""))
            {
                chkSA.Visible = false;
                chkSA.Checked = false;
                chkXN.Visible = false;
                chkXN.Checked = false;
                chkKB.Visible = false;
                chkKB.Checked = false;                
            }
            else
            {
                chkSA.Visible = true;
                chkXN.Visible = true;
                chkKB.Visible = true;
            }   
        }

        private void Btn_Tao_Click(object sender, EventArgs e)
        {                        
            ConnData con = new ConnData();
            if (!con.OpenConnection())
                MessageBox.Show(con.ShowErrorMessage());
            string query = "insert into benhnhan (ten, nam_sinh, address, phone_num) values('"+txt_hoten.Text+"', '"+mtxtNamSinh.Text+ "', '" + txt_diachi.Text + "', '" + mtxtSDT.Text + "')";
            con.ExecuteNonQuery(query);
            if (!con.CloseConnection())
                MessageBox.Show(con.ShowErrorMessage());
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int currentRow = gv_danhsachbenhnhan.CurrentCell.RowIndex;
                gv_danhsachbenhnhan.Rows.RemoveAt(currentRow);
                DeleteLineTxt(currentRow);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa");
            }

            ResetAll();
        }

        public bool UpdateGridView(string path)
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

        private void Gd_nhanbenh_Load(object sender, EventArgs e)
        {
            UpdateGridView("F:/GIT/dsbn.txt"); 
        }

        private void ChkSA_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkSA.Checked)
            {
                chklbSA.Visible = false;
                foreach (int i in chklbSA.CheckedIndices)
                {
                    chklbSA.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
            else
            {
                chklbSA.Visible = true;
            }
        }

        private void ChkXN_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkXN.Checked)
            {
                chklbXetNghiem.Visible = false;
                foreach (int i in chklbXetNghiem.CheckedIndices)
                {
                    chklbXetNghiem.SetItemCheckState(i, CheckState.Unchecked);
                }
            }
            else
            {
                chklbXetNghiem.Visible = true;
            }
        }

        private void ChkSA_VisibleChanged(object sender, EventArgs e)
        {
            if (chkSA.Checked)
                chklbSA.Visible = true;
            else
                chklbSA.Visible = false;
        }
        
    }
}
