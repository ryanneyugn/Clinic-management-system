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
            this.chklbSA = new System.Windows.Forms.CheckedListBox();
            this.chklbXetNghiem = new System.Windows.Forms.CheckedListBox();
            this.cbDichVu = new System.Windows.Forms.ComboBox();
            this.gb_ThonTinBenhNhan = new System.Windows.Forms.GroupBox();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.mtxtNamSinh = new System.Windows.Forms.MaskedTextBox();
            this.btn_XepVaoHangDoi = new System.Windows.Forms.Button();
            this.btn_TaoMoi = new System.Windows.Forms.Button();
            this.btn_Tao = new System.Windows.Forms.Button();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gv_danhsachbenhnhan = new System.Windows.Forms.DataGridView();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXoa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_ThonTinBenhNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_danhsachbenhnhan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chklbSA);
            this.groupBox1.Controls.Add(this.chklbXetNghiem);
            this.groupBox1.Controls.Add(this.cbDichVu);
            this.groupBox1.Controls.Add(this.gb_ThonTinBenhNhan);
            this.groupBox1.Controls.Add(this.gv_danhsachbenhnhan);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(513, 412);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bệnh nhân";
            // 
            // chklbSA
            // 
            this.chklbSA.FormattingEnabled = true;
            this.chklbSA.Items.AddRange(new object[] {
            "Thai 2D",
            "Ngã âm đạo",
            "Hình thái học",
            "Màu"});
            this.chklbSA.Location = new System.Drawing.Point(364, 234);
            this.chklbSA.Name = "chklbSA";
            this.chklbSA.Size = new System.Drawing.Size(135, 64);
            this.chklbSA.TabIndex = 4;
            this.chklbSA.Visible = false;
            // 
            // chklbXetNghiem
            // 
            this.chklbXetNghiem.FormattingEnabled = true;
            this.chklbXetNghiem.Items.AddRange(new object[] {
            "Quick stick",
            "Tổng phân tích nước tiểu",
            "Định lượng BHCG",
            "Xét nghiệm tổng quát",
            "Điện tâm đồ",
            "Rubella",
            "Viêm gan siêu vi B",
            "Bilan tiền sản giật"});
            this.chklbXetNghiem.Location = new System.Drawing.Point(364, 234);
            this.chklbXetNghiem.Name = "chklbXetNghiem";
            this.chklbXetNghiem.Size = new System.Drawing.Size(135, 124);
            this.chklbXetNghiem.TabIndex = 3;
            this.chklbXetNghiem.Visible = false;
            // 
            // cbDichVu
            // 
            this.cbDichVu.FormattingEnabled = true;
            this.cbDichVu.Items.AddRange(new object[] {
            "Khám thường",
            "Khám + siêu âm",
            "Xét nghiệm"});
            this.cbDichVu.Location = new System.Drawing.Point(269, 234);
            this.cbDichVu.Name = "cbDichVu";
            this.cbDichVu.Size = new System.Drawing.Size(79, 21);
            this.cbDichVu.TabIndex = 2;
            this.cbDichVu.Text = "Dịch Vụ";
            this.cbDichVu.SelectedIndexChanged += new System.EventHandler(this.cbDichVu_SelectedIndexChanged);
            // 
            // gb_ThonTinBenhNhan
            // 
            this.gb_ThonTinBenhNhan.Controls.Add(this.btnXoa);
            this.gb_ThonTinBenhNhan.Controls.Add(this.mtxtSDT);
            this.gb_ThonTinBenhNhan.Controls.Add(this.mtxtNamSinh);
            this.gb_ThonTinBenhNhan.Controls.Add(this.btn_XepVaoHangDoi);
            this.gb_ThonTinBenhNhan.Controls.Add(this.btn_TaoMoi);
            this.gb_ThonTinBenhNhan.Controls.Add(this.btn_Tao);
            this.gb_ThonTinBenhNhan.Controls.Add(this.txt_diachi);
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
            // mtxtSDT
            // 
            this.mtxtSDT.Location = new System.Drawing.Point(95, 101);
            this.mtxtSDT.Mask = "(99) 0000 0000";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(111, 20);
            this.mtxtSDT.TabIndex = 3;
            // 
            // mtxtNamSinh
            // 
            this.mtxtNamSinh.Location = new System.Drawing.Point(95, 49);
            this.mtxtNamSinh.Mask = "0000";
            this.mtxtNamSinh.Name = "mtxtNamSinh";
            this.mtxtNamSinh.Size = new System.Drawing.Size(111, 20);
            this.mtxtNamSinh.TabIndex = 1;
            // 
            // btn_XepVaoHangDoi
            // 
            this.btn_XepVaoHangDoi.Location = new System.Drawing.Point(19, 136);
            this.btn_XepVaoHangDoi.Name = "btn_XepVaoHangDoi";
            this.btn_XepVaoHangDoi.Size = new System.Drawing.Size(82, 23);
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
            this.btn_TaoMoi.Text = "Reset";
            this.btn_TaoMoi.UseVisualStyleBackColor = true;
            this.btn_TaoMoi.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // btn_Tao
            // 
            this.btn_Tao.Location = new System.Drawing.Point(125, 136);
            this.btn_Tao.Name = "btn_Tao";
            this.btn_Tao.Size = new System.Drawing.Size(82, 23);
            this.btn_Tao.TabIndex = 5;
            this.btn_Tao.Text = "Tạo";
            this.btn_Tao.UseVisualStyleBackColor = true;
            this.btn_Tao.Click += new System.EventHandler(this.btn_Tao_Click);
            // 
            // txt_diachi
            // 
            this.txt_diachi.Location = new System.Drawing.Point(95, 75);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(111, 20);
            this.txt_diachi.TabIndex = 2;
            // 
            // txt_hoten
            // 
            this.txt_hoten.Location = new System.Drawing.Point(95, 23);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(111, 20);
            this.txt_hoten.TabIndex = 0;
            this.txt_hoten.TextChanged += new System.EventHandler(this.txt_hoten_TextChanged);
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
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Năm sinh:";
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
            this.gv_danhsachbenhnhan.AllowUserToAddRows = false;
            this.gv_danhsachbenhnhan.AllowUserToDeleteRows = false;
            this.gv_danhsachbenhnhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_danhsachbenhnhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hoten,
            this.sdt});
            this.gv_danhsachbenhnhan.Location = new System.Drawing.Point(6, 19);
            this.gv_danhsachbenhnhan.MultiSelect = false;
            this.gv_danhsachbenhnhan.Name = "gv_danhsachbenhnhan";
            this.gv_danhsachbenhnhan.ReadOnly = true;
            this.gv_danhsachbenhnhan.Size = new System.Drawing.Size(241, 345);
            this.gv_danhsachbenhnhan.TabIndex = 0;
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
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(19, 165);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // gd_nhanbenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 388);
            this.Controls.Add(this.groupBox1);
            this.Name = "gd_nhanbenh";
            this.Text = "Nhận bệnh";
            this.Load += new System.EventHandler(this.gd_nhanbenh_Load);
            this.groupBox1.ResumeLayout(false);
            this.gb_ThonTinBenhNhan.ResumeLayout(false);
            this.gb_ThonTinBenhNhan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_danhsachbenhnhan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gv_danhsachbenhnhan;
        private System.Windows.Forms.GroupBox gb_ThonTinBenhNhan;
        private System.Windows.Forms.Button btn_XepVaoHangDoi;
        private System.Windows.Forms.Button btn_TaoMoi;
        private System.Windows.Forms.Button btn_Tao;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.MaskedTextBox mtxtNamSinh;
        private System.Windows.Forms.ComboBox cbDichVu;
        private System.Windows.Forms.CheckedListBox chklbXetNghiem;
        private System.Windows.Forms.CheckedListBox chklbSA;
        private System.Windows.Forms.Button btnXoa;
    }
}