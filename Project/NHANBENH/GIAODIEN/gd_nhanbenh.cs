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
            string dvSA = "null";
            string dvXN = "null";
            //file.txt
            TXTOBJECT dsNB = new TXTOBJECT("F:/GIT/ryan-repository/Project/dsNhanBenh.txt");
            if (txt_hoten.Text.Equals(""))
            {
                return;
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
            string[] row = { hoten, sdt, dvSA, dvXN };
            //write file txt
            dsNB.writeAppend(hoten, sdt, dvSA, dvXN);
            //display data
            gv_danhsachbenhnhan.Rows.Add(row);
            ResetAll();
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
        private void deleteLineTxt(int i)
        {
            TXTOBJECT a = new TXTOBJECT("F:/GIT/ryan-repository/Project/dsNhanBenh.txt");
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

        private void btn_Tao_Click(object sender, EventArgs e)
        {
            string connetionString = "server=localconnection;database=phongkham;uid=root;pwd=1;";
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
            updateGridView("F:/GIT/ryan-repository/Project/dsNhanBenh.txt");
        }

        private void chkSA_CheckedChanged(object sender, EventArgs e)
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
        private void chkXN_CheckedChanged(object sender, EventArgs e)
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
        private void chkSA_VisibleChanged(object sender, EventArgs e)
        {
            if (chkSA.Checked)
                chklbSA.Visible = true;
            else
                chklbSA.Visible = false;
        }
    }
}
