namespace NHANBENH.GIAODIEN
{
    partial class Gd_nhanbenh
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
            this.gv_danhsachcho = new System.Windows.Forms.DataGridView();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkXN = new System.Windows.Forms.CheckBox();
            this.chklbXN = new System.Windows.Forms.CheckedListBox();
            this.chkSA = new System.Windows.Forms.CheckBox();
            this.chklbSA = new System.Windows.Forms.CheckedListBox();
            this.gb_ThonTinBenhNhan = new System.Windows.Forms.GroupBox();
            this.txtTuoi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.txt_diachi = new System.Windows.Forms.TextBox();
            this.txt_hoten = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_danhsachcho)).BeginInit();
            this.gb_ThonTinBenhNhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gv_danhsachcho);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 203);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hàng chờ";
            // 
            // gv_danhsachcho
            // 
            this.gv_danhsachcho.AllowUserToAddRows = false;
            this.gv_danhsachcho.AllowUserToDeleteRows = false;
            this.gv_danhsachcho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_danhsachcho.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hoten,
            this.diachi,
            this.sdt,
            this.tuoi});
            this.gv_danhsachcho.Location = new System.Drawing.Point(19, 19);
            this.gv_danhsachcho.MultiSelect = false;
            this.gv_danhsachcho.Name = "gv_danhsachcho";
            this.gv_danhsachcho.ReadOnly = true;
            this.gv_danhsachcho.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_danhsachcho.Size = new System.Drawing.Size(443, 180);
            this.gv_danhsachcho.TabIndex = 41;
            this.gv_danhsachcho.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_danhsachbenhnhan_CellClick);
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Họ tên";
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            // 
            // tuoi
            // 
            this.tuoi.HeaderText = "Tuổi";
            this.tuoi.Name = "tuoi";
            this.tuoi.ReadOnly = true;
            // 
            // chkXN
            // 
            this.chkXN.AutoSize = true;
            this.chkXN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chkXN.Enabled = false;
            this.chkXN.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkXN.Location = new System.Drawing.Point(343, 241);
            this.chkXN.Name = "chkXN";
            this.chkXN.Size = new System.Drawing.Size(90, 17);
            this.chkXN.TabIndex = 40;
            this.chkXN.Text = "Xét Nghiệm";
            this.chkXN.UseVisualStyleBackColor = false;
            this.chkXN.CheckedChanged += new System.EventHandler(this.chkXN_CheckedChanged);
            // 
            // chklbXN
            // 
            this.chklbXN.CheckOnClick = true;
            this.chklbXN.Enabled = false;
            this.chklbXN.FormattingEnabled = true;
            this.chklbXN.Items.AddRange(new object[] {
            "Quick stick",
            "Tổng phân tích nước tiểu",
            "Định lượng BHCG",
            "Xét nghiệm tổng quát",
            "Điện tâm đồ",
            "Rubella",
            "Viêm gan siêu vi B",
            "Bilan tiền sản giật"});
            this.chklbXN.Location = new System.Drawing.Point(343, 266);
            this.chklbXN.Name = "chklbXN";
            this.chklbXN.Size = new System.Drawing.Size(161, 124);
            this.chklbXN.TabIndex = 3;
            // 
            // chkSA
            // 
            this.chkSA.AutoSize = true;
            this.chkSA.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.chkSA.Enabled = false;
            this.chkSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.792453F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSA.Location = new System.Drawing.Point(248, 241);
            this.chkSA.Name = "chkSA";
            this.chkSA.Size = new System.Drawing.Size(72, 17);
            this.chkSA.TabIndex = 30;
            this.chkSA.Text = "Siêu Âm";
            this.chkSA.UseVisualStyleBackColor = false;
            this.chkSA.CheckedChanged += new System.EventHandler(this.chkSA_CheckedChanged);
            // 
            // chklbSA
            // 
            this.chklbSA.CheckOnClick = true;
            this.chklbSA.Enabled = false;
            this.chklbSA.FormattingEnabled = true;
            this.chklbSA.Items.AddRange(new object[] {
            "Thai 2D",
            "Ngã âm đạo",
            "Hình thái học",
            "Màu"});
            this.chklbSA.Location = new System.Drawing.Point(248, 266);
            this.chklbSA.Name = "chklbSA";
            this.chklbSA.Size = new System.Drawing.Size(89, 64);
            this.chklbSA.TabIndex = 4;
            // 
            // gb_ThonTinBenhNhan
            // 
            this.gb_ThonTinBenhNhan.Controls.Add(this.txtTuoi);
            this.gb_ThonTinBenhNhan.Controls.Add(this.txtSDT);
            this.gb_ThonTinBenhNhan.Controls.Add(this.label2);
            this.gb_ThonTinBenhNhan.Controls.Add(this.btnXoa);
            this.gb_ThonTinBenhNhan.Controls.Add(this.btn_Them);
            this.gb_ThonTinBenhNhan.Controls.Add(this.btn_Reset);
            this.gb_ThonTinBenhNhan.Controls.Add(this.txt_diachi);
            this.gb_ThonTinBenhNhan.Controls.Add(this.txt_hoten);
            this.gb_ThonTinBenhNhan.Controls.Add(this.label4);
            this.gb_ThonTinBenhNhan.Controls.Add(this.label3);
            this.gb_ThonTinBenhNhan.Controls.Add(this.label1);
            this.gb_ThonTinBenhNhan.Location = new System.Drawing.Point(12, 221);
            this.gb_ThonTinBenhNhan.Name = "gb_ThonTinBenhNhan";
            this.gb_ThonTinBenhNhan.Size = new System.Drawing.Size(230, 209);
            this.gb_ThonTinBenhNhan.TabIndex = 42;
            this.gb_ThonTinBenhNhan.TabStop = false;
            this.gb_ThonTinBenhNhan.Text = "Thông tin bệnh nhân";
            // 
            // txtTuoi
            // 
            this.txtTuoi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTuoi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTuoi.Location = new System.Drawing.Point(95, 111);
            this.txtTuoi.Name = "txtTuoi";
            this.txtTuoi.Size = new System.Drawing.Size(111, 20);
            this.txtTuoi.TabIndex = 3;
            this.txtTuoi.TextChanged += new System.EventHandler(this.txtTuoi_TextChanged_1);
            this.txtTuoi.Leave += new System.EventHandler(this.txtTuoi_Leave);
            // 
            // txtSDT
            // 
            this.txtSDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSDT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSDT.Location = new System.Drawing.Point(95, 81);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(111, 20);
            this.txtSDT.TabIndex = 2;
            this.txtSDT.TextChanged += new System.EventHandler(this.txtSDT_TextChanged);
            this.txtSDT.Leave += new System.EventHandler(this.txtSDT_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tuổi:";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnXoa.Location = new System.Drawing.Point(19, 166);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(187, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Them.Location = new System.Drawing.Point(19, 137);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(82, 23);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btn_Reset.Location = new System.Drawing.Point(125, 137);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(81, 23);
            this.btn_Reset.TabIndex = 6;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = false;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // txt_diachi
            // 
            this.txt_diachi.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_diachi.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_diachi.Location = new System.Drawing.Point(95, 52);
            this.txt_diachi.Name = "txt_diachi";
            this.txt_diachi.Size = new System.Drawing.Size(111, 20);
            this.txt_diachi.TabIndex = 1;
            this.txt_diachi.TextChanged += new System.EventHandler(this.txt_diachi_TextChanged);
            // 
            // txt_hoten
            // 
            this.txt_hoten.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txt_hoten.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_hoten.Location = new System.Drawing.Point(95, 23);
            this.txt_hoten.Name = "txt_hoten";
            this.txt_hoten.Size = new System.Drawing.Size(111, 20);
            this.txt_hoten.TabIndex = 0;
            this.txt_hoten.TextChanged += new System.EventHandler(this.txt_hoten_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Họ tên:";
            // 
            // Gd_nhanbenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 415);
            this.Controls.Add(this.chkXN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chklbXN);
            this.Controls.Add(this.gb_ThonTinBenhNhan);
            this.Controls.Add(this.chkSA);
            this.Controls.Add(this.chklbSA);
            this.Name = "Gd_nhanbenh";
            this.Text = "Nhận bệnh";
            this.Load += new System.EventHandler(this.Gd_nhanbenh_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_danhsachcho)).EndInit();
            this.gb_ThonTinBenhNhan.ResumeLayout(false);
            this.gb_ThonTinBenhNhan.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gv_danhsachcho;
        private System.Windows.Forms.GroupBox gb_ThonTinBenhNhan;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.TextBox txt_diachi;
        private System.Windows.Forms.TextBox txt_hoten;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.CheckBox chkXN;
        private System.Windows.Forms.CheckedListBox chklbXN;
        private System.Windows.Forms.CheckBox chkSA;
        private System.Windows.Forms.CheckedListBox chklbSA;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuoi;
        private System.Windows.Forms.TextBox txtTuoi;
        private System.Windows.Forms.TextBox txtSDT;
    }
}