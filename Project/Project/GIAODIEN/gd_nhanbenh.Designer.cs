namespace Project.GIAODIEN
{
    partial class gd_nhanbenh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_DiChuyenXuongDuoi = new System.Windows.Forms.Button();
            this.btn_DiChuyenLenTren = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.gb_ThonTinBenhNhan = new System.Windows.Forms.GroupBox();
            this.btn_XepVaoHangDoi = new System.Windows.Forms.Button();
            this.btn_TaoMoi = new System.Windows.Forms.Button();
            this.btn_Tao = new System.Windows.Forms.Button();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_ngaysinh = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gv_danhsachbenhnhan = new System.Windows.Forms.DataGridView();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gb_ThonTinBenhNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_danhsachbenhnhan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.gb_ThonTinBenhNhan);
            this.groupBox1.Controls.Add(this.gv_danhsachbenhnhan);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 412);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bệnh nhân";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_DiChuyenXuongDuoi);
            this.groupBox3.Controls.Add(this.btn_DiChuyenLenTren);
            this.groupBox3.Controls.Add(this.btn_xoa);
            this.groupBox3.Location = new System.Drawing.Point(269, 234);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(230, 130);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thao tác";
            // 
            // btn_DiChuyenXuongDuoi
            // 
            this.btn_DiChuyenXuongDuoi.Location = new System.Drawing.Point(131, 69);
            this.btn_DiChuyenXuongDuoi.Name = "btn_DiChuyenXuongDuoi";
            this.btn_DiChuyenXuongDuoi.Size = new System.Drawing.Size(75, 41);
            this.btn_DiChuyenXuongDuoi.TabIndex = 9;
            this.btn_DiChuyenXuongDuoi.Text = "Di chuyển xuống dưới";
            this.btn_DiChuyenXuongDuoi.UseVisualStyleBackColor = true;
            // 
            // btn_DiChuyenLenTren
            // 
            this.btn_DiChuyenLenTren.Location = new System.Drawing.Point(19, 63);
            this.btn_DiChuyenLenTren.Name = "btn_DiChuyenLenTren";
            this.btn_DiChuyenLenTren.Size = new System.Drawing.Size(75, 47);
            this.btn_DiChuyenLenTren.TabIndex = 8;
            this.btn_DiChuyenLenTren.Text = "Di chuyển lên trên";
            this.btn_DiChuyenLenTren.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(19, 34);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(187, 23);
            this.btn_xoa.TabIndex = 7;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // gb_ThonTinBenhNhan
            // 
            this.gb_ThonTinBenhNhan.Controls.Add(this.btn_XepVaoHangDoi);
            this.gb_ThonTinBenhNhan.Controls.Add(this.btn_TaoMoi);
            this.gb_ThonTinBenhNhan.Controls.Add(this.btn_Tao);
            this.gb_ThonTinBenhNhan.Controls.Add(this.txt_sdt);
            this.gb_ThonTinBenhNhan.Controls.Add(this.txt_diachi);
            this.gb_ThonTinBenhNhan.Controls.Add(this.txt_ngaysinh);
            this.gb_ThonTinBenhNhan.Controls.Add(this.txt_hoten);
            this.gb_ThonTinBenhNhan.Controls.Add(this.label4);
            this.gb_ThonTinBenhNhan.Controls.Add(this.label3);
            this.gb_ThonTinBenhNhan.Controls.Add(this.label2);
            this.gb_ThonTinBenhNhan.Controls.Add(this.label1);
            this.gb_ThonTinBenhNhan.Location = new System.Drawing.Point(269, 19);
            this.gb_ThonTinBenhNhan.Name = "gb_ThonTinBenhNhan";
            this.gb_ThonTinBenhNhan.Size = new System.Drawing.Size(230, 209);
            this.gb_ThonTinBenhNhan.TabIndex = 1;
            this.gb_ThonTinBenhNhan.TabStop = false;
            this.gb_ThonTinBenhNhan.Text = "Thông tin bệnh nhân";
            // 
            // btn_XepVaoHangDoi
            // 
            this.btn_XepVaoHangDoi.Location = new System.Drawing.Point(19, 136);
            this.btn_XepVaoHangDoi.Name = "btn_XepVaoHangDoi";
            this.btn_XepVaoHangDoi.Size = new System.Drawing.Size(187, 23);
            this.btn_XepVaoHangDoi.TabIndex = 4;
            this.btn_XepVaoHangDoi.Text = "Xếp vào hàng đợi";
            this.btn_XepVaoHangDoi.UseVisualStyleBackColor = true;
            this.btn_XepVaoHangDoi.Click += new System.EventHandler(this.btn_XepVaoHangDoi_Click);
            // 
            // btn_TaoMoi
            // 
            this.btn_TaoMoi.Location = new System.Drawing.Point(125, 165);
            this.btn_TaoMoi.Name = "btn_TaoMoi";
            this.btn_TaoMoi.Size = new System.Drawing.Size(81, 23);
            this.btn_TaoMoi.TabIndex = 6;
            this.btn_TaoMoi.Text = "Tạo mới";
            this.btn_TaoMoi.UseVisualStyleBackColor = true;
            this.btn_TaoMoi.Click += new System.EventHandler(this.btn_TaoMoi_Click);
            // 
            // btn_Tao
            // 
            this.btn_Tao.Location = new System.Drawing.Point(19, 165);
            this.btn_Tao.Name = "btn_Tao";
            this.btn_Tao.Size = new System.Drawing.Size(82, 23);
            this.btn_Tao.TabIndex = 5;
            this.btn_Tao.Text = "Tạo";
            this.btn_Tao.UseVisualStyleBackColor = true;
            // 
            // txt_sdt
            // 
            this.txt_sdt.Location = new System.Drawing.Point(95, 101);
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(111, 20);
            this.txt_sdt.TabIndex = 3;
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(95, 75);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(111, 20);
            this.txt_diachi.TabIndex = 2;
            // 
            // txt_ngaysinh
            // 
            this.txt_ngaysinh.Location = new System.Drawing.Point(95, 49);
            this.txt_ngaysinh.Name = "txt_ngaysinh";
            this.txt_ngaysinh.Size = new System.Drawing.Size(111, 20);
            this.txt_ngaysinh.TabIndex = 1;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(95, 23);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(111, 20);
            this.txt_hoten.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Địa chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ngày sinh:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Họ tên:";
            // 
            // gv_danhsachbenhnhan
            // 
            this.gv_danhsachbenhnhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_danhsachbenhnhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hoten,
            this.sdt});
            this.gv_danhsachbenhnhan.Location = new System.Drawing.Point(6, 19);
            this.gv_danhsachbenhnhan.Name = "gv_danhsachbenhnhan";
            this.gv_danhsachbenhnhan.Size = new System.Drawing.Size(241, 345);
            this.gv_danhsachbenhnhan.TabIndex = 0;
            this.gv_danhsachbenhnhan.Visible = false;
            this.gv_danhsachbenhnhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_danhsachbenhnhan_CellClick);
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Họ tên";
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // gd_nhanbenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 388);
            this.Controls.Add(this.groupBox1);
            this.Name = "gd_nhanbenh";
            this.Text = "Nhận bệnh";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.gb_ThonTinBenhNhan.ResumeLayout(false);
            this.gb_ThonTinBenhNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_danhsachbenhnhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gv_danhsachbenhnhan;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_DiChuyenXuongDuoi;
        private System.Windows.Forms.Button btn_DiChuyenLenTren;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.GroupBox gb_ThonTinBenhNhan;
        private System.Windows.Forms.Button btn_XepVaoHangDoi;
        private System.Windows.Forms.Button btn_TaoMoi;
        private System.Windows.Forms.Button btn_Tao;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_ngaysinh;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
    }
}