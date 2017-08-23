namespace PHONGKHAM.GIAODIEN
{
    partial class gd_thongtintoathuoc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_tongtien = new System.Windows.Forms.Label();
            this.lbl_songay = new System.Windows.Forms.Label();
            this.lbl_idtoathuoc = new System.Windows.Forms.Label();
            this.lbl_ngaylap = new System.Windows.Forms.Label();
            this.txt_loidan = new System.Windows.Forms.TextBox();
            this.idctthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duongdung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quycach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idctthuoc,
            this.idthuoc,
            this.tenthuoc,
            this.soluong,
            this.giaban,
            this.duongdung,
            this.quycach});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.Location = new System.Drawing.Point(12, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(664, 209);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(259, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lời dặn:";
            // 
            // lbl_tongtien
            // 
            this.lbl_tongtien.AutoSize = true;
            this.lbl_tongtien.Location = new System.Drawing.Point(129, 12);
            this.lbl_tongtien.Name = "lbl_tongtien";
            this.lbl_tongtien.Size = new System.Drawing.Size(48, 13);
            this.lbl_tongtien.TabIndex = 2;
            this.lbl_tongtien.Text = "tong tien";
            // 
            // lbl_songay
            // 
            this.lbl_songay.AutoSize = true;
            this.lbl_songay.Location = new System.Drawing.Point(12, 49);
            this.lbl_songay.Name = "lbl_songay";
            this.lbl_songay.Size = new System.Drawing.Size(71, 13);
            this.lbl_songay.TabIndex = 3;
            this.lbl_songay.Text = "so ngay dung";
            // 
            // lbl_idtoathuoc
            // 
            this.lbl_idtoathuoc.AutoSize = true;
            this.lbl_idtoathuoc.Location = new System.Drawing.Point(12, 12);
            this.lbl_idtoathuoc.Name = "lbl_idtoathuoc";
            this.lbl_idtoathuoc.Size = new System.Drawing.Size(18, 13);
            this.lbl_idtoathuoc.TabIndex = 4;
            this.lbl_idtoathuoc.Text = "ID";
            // 
            // lbl_ngaylap
            // 
            this.lbl_ngaylap.AutoSize = true;
            this.lbl_ngaylap.Location = new System.Drawing.Point(129, 49);
            this.lbl_ngaylap.Name = "lbl_ngaylap";
            this.lbl_ngaylap.Size = new System.Drawing.Size(47, 13);
            this.lbl_ngaylap.TabIndex = 5;
            this.lbl_ngaylap.Text = "ngay lap";
            // 
            // txt_loidan
            // 
            this.txt_loidan.Location = new System.Drawing.Point(310, 9);
            this.txt_loidan.Multiline = true;
            this.txt_loidan.Name = "txt_loidan";
            this.txt_loidan.ReadOnly = true;
            this.txt_loidan.Size = new System.Drawing.Size(366, 72);
            this.txt_loidan.TabIndex = 6;
            // 
            // idctthuoc
            // 
            this.idctthuoc.HeaderText = "IDCTHUOC";
            this.idctthuoc.Name = "idctthuoc";
            this.idctthuoc.ReadOnly = true;
            this.idctthuoc.Visible = false;
            // 
            // idthuoc
            // 
            this.idthuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idthuoc.HeaderText = "ID";
            this.idthuoc.Name = "idthuoc";
            this.idthuoc.ReadOnly = true;
            this.idthuoc.Width = 43;
            // 
            // tenthuoc
            // 
            this.tenthuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tenthuoc.HeaderText = "Tên thuốc";
            this.tenthuoc.MinimumWidth = 150;
            this.tenthuoc.Name = "tenthuoc";
            this.tenthuoc.ReadOnly = true;
            this.tenthuoc.Width = 150;
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            this.soluong.Width = 74;
            // 
            // giaban
            // 
            this.giaban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.giaban.HeaderText = "Giá bán";
            this.giaban.Name = "giaban";
            this.giaban.ReadOnly = true;
            this.giaban.Width = 69;
            // 
            // duongdung
            // 
            this.duongdung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.duongdung.HeaderText = "Đường dùng";
            this.duongdung.Name = "duongdung";
            this.duongdung.ReadOnly = true;
            this.duongdung.Width = 91;
            // 
            // quycach
            // 
            this.quycach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.quycach.HeaderText = "Quy cách";
            this.quycach.MinimumWidth = 250;
            this.quycach.Name = "quycach";
            this.quycach.ReadOnly = true;
            this.quycach.Width = 250;
            // 
            // gd_thongtintoathuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 308);
            this.Controls.Add(this.txt_loidan);
            this.Controls.Add(this.lbl_ngaylap);
            this.Controls.Add(this.lbl_idtoathuoc);
            this.Controls.Add(this.lbl_songay);
            this.Controls.Add(this.lbl_tongtien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "gd_thongtintoathuoc";
            this.Text = "Thông tin toa thuốc";
            this.Load += new System.EventHandler(this.gd_thongtintoathuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_tongtien;
        private System.Windows.Forms.Label lbl_songay;
        private System.Windows.Forms.Label lbl_idtoathuoc;
        private System.Windows.Forms.Label lbl_ngaylap;
        private System.Windows.Forms.TextBox txt_loidan;
        private System.Windows.Forms.DataGridViewTextBoxColumn idctthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn duongdung;
        private System.Windows.Forms.DataGridViewTextBoxColumn quycach;
    }
}