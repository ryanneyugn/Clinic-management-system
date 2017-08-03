namespace PHONGKHAM.GIAODIEN
{
    partial class gd_khambenh
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_refreshdsbn = new System.Windows.Forms.Button();
            this.dtgv_dsbn = new System.Windows.Forms.DataGridView();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_tenbs = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_kedonthuoc = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_xemdonthuoccu = new System.Windows.Forms.Button();
            this.dtgv_lskb = new System.Windows.Forms.DataGridView();
            this.masotoathuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaykham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chandoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txt_sdtbn = new System.Windows.Forms.TextBox();
            this.txt_diachibn = new System.Windows.Forms.TextBox();
            this.txt_hotenbn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_para = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dsbn)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_lskb)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.btn_refreshdsbn);
            this.groupBox1.Controls.Add(this.dtgv_dsbn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 217);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách bệnh nhân chờ khám";
            // 
            // btn_refreshdsbn
            // 
            this.btn_refreshdsbn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_refreshdsbn.FlatAppearance.BorderSize = 5;
            this.btn_refreshdsbn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_refreshdsbn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_refreshdsbn.Image = global::PHONGKHAM.Properties.Resources.refresh1;
            this.btn_refreshdsbn.Location = new System.Drawing.Point(314, 11);
            this.btn_refreshdsbn.Name = "btn_refreshdsbn";
            this.btn_refreshdsbn.Size = new System.Drawing.Size(34, 34);
            this.btn_refreshdsbn.TabIndex = 1;
            this.btn_refreshdsbn.UseVisualStyleBackColor = true;
            this.btn_refreshdsbn.Click += new System.EventHandler(this.btn_refreshdsbn_Click);
            // 
            // dtgv_dsbn
            // 
            this.dtgv_dsbn.AllowUserToAddRows = false;
            this.dtgv_dsbn.AllowUserToDeleteRows = false;
            this.dtgv_dsbn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgv_dsbn.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgv_dsbn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_dsbn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hoten,
            this.sdt});
            this.dtgv_dsbn.Location = new System.Drawing.Point(6, 47);
            this.dtgv_dsbn.Name = "dtgv_dsbn";
            this.dtgv_dsbn.ReadOnly = true;
            this.dtgv_dsbn.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_dsbn.Size = new System.Drawing.Size(342, 164);
            this.dtgv_dsbn.TabIndex = 0;
            this.dtgv_dsbn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_dsbn_CellClick);
            // 
            // hoten
            // 
            this.hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoten.DefaultCellStyle = dataGridViewCellStyle1;
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 100;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hoten.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sdt
            // 
            this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sdt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lbl_tenbs
            // 
            this.lbl_tenbs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_tenbs.AutoSize = true;
            this.lbl_tenbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tenbs.Location = new System.Drawing.Point(569, 4);
            this.lbl_tenbs.Name = "lbl_tenbs";
            this.lbl_tenbs.Size = new System.Drawing.Size(90, 24);
            this.lbl_tenbs.TabIndex = 2;
            this.lbl_tenbs.Text = "Bác sĩ ...";
            this.lbl_tenbs.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.richTextBox2);
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txt_para);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txt_sdtbn);
            this.groupBox3.Controls.Add(this.txt_diachibn);
            this.groupBox3.Controls.Add(this.txt_hotenbn);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(372, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(419, 217);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin phiếu khám";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Location = new System.Drawing.Point(20, 69);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(87, 44);
            this.btn_thoat.TabIndex = 9;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_kedonthuoc
            // 
            this.btn_kedonthuoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_kedonthuoc.Enabled = false;
            this.btn_kedonthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kedonthuoc.Location = new System.Drawing.Point(19, 19);
            this.btn_kedonthuoc.Name = "btn_kedonthuoc";
            this.btn_kedonthuoc.Size = new System.Drawing.Size(87, 44);
            this.btn_kedonthuoc.TabIndex = 8;
            this.btn_kedonthuoc.Text = "Kê đơn thuốc";
            this.btn_kedonthuoc.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.btn_xemdonthuoccu);
            this.groupBox4.Controls.Add(this.dtgv_lskb);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 390);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(779, 181);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lịch sử khám bệnh";
            // 
            // btn_xemdonthuoccu
            // 
            this.btn_xemdonthuoccu.Enabled = false;
            this.btn_xemdonthuoccu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xemdonthuoccu.Location = new System.Drawing.Point(674, 60);
            this.btn_xemdonthuoccu.Name = "btn_xemdonthuoccu";
            this.btn_xemdonthuoccu.Size = new System.Drawing.Size(86, 66);
            this.btn_xemdonthuoccu.TabIndex = 10;
            this.btn_xemdonthuoccu.Text = "Xem đơn thuốc cũ";
            this.btn_xemdonthuoccu.UseVisualStyleBackColor = true;
            // 
            // dtgv_lskb
            // 
            this.dtgv_lskb.AllowUserToAddRows = false;
            this.dtgv_lskb.AllowUserToDeleteRows = false;
            this.dtgv_lskb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_lskb.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masotoathuoc,
            this.ngaykham,
            this.chandoan});
            this.dtgv_lskb.Location = new System.Drawing.Point(5, 19);
            this.dtgv_lskb.Name = "dtgv_lskb";
            this.dtgv_lskb.ReadOnly = true;
            this.dtgv_lskb.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_lskb.Size = new System.Drawing.Size(636, 156);
            this.dtgv_lskb.TabIndex = 0;
            // 
            // masotoathuoc
            // 
            this.masotoathuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.masotoathuoc.HeaderText = "Mã số toa thuốc";
            this.masotoathuoc.Name = "masotoathuoc";
            this.masotoathuoc.ReadOnly = true;
            this.masotoathuoc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.masotoathuoc.Width = 95;
            // 
            // ngaykham
            // 
            this.ngaykham.HeaderText = "Ngày khám";
            this.ngaykham.Name = "ngaykham";
            this.ngaykham.ReadOnly = true;
            this.ngaykham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ngaykham.Width = 150;
            // 
            // chandoan
            // 
            this.chandoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.chandoan.HeaderText = "Chẩn đoán";
            this.chandoan.Name = "chandoan";
            this.chandoan.ReadOnly = true;
            this.chandoan.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox5.Controls.Add(this.btn_thoat);
            this.groupBox5.Controls.Add(this.btn_kedonthuoc);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(666, 254);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(125, 130);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox6.Controls.Add(this.richTextBox3);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(12, 254);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(647, 130);
            this.groupBox6.TabIndex = 12;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Chẩn đoán";
            // 
            // txt_sdtbn
            // 
            this.txt_sdtbn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sdtbn.Enabled = false;
            this.txt_sdtbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_sdtbn.ForeColor = System.Drawing.Color.Black;
            this.txt_sdtbn.Location = new System.Drawing.Point(92, 71);
            this.txt_sdtbn.Name = "txt_sdtbn";
            this.txt_sdtbn.ReadOnly = true;
            this.txt_sdtbn.Size = new System.Drawing.Size(110, 20);
            this.txt_sdtbn.TabIndex = 41;
            // 
            // txt_diachibn
            // 
            this.txt_diachibn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_diachibn.Enabled = false;
            this.txt_diachibn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_diachibn.ForeColor = System.Drawing.Color.Black;
            this.txt_diachibn.Location = new System.Drawing.Point(62, 45);
            this.txt_diachibn.Name = "txt_diachibn";
            this.txt_diachibn.ReadOnly = true;
            this.txt_diachibn.Size = new System.Drawing.Size(140, 20);
            this.txt_diachibn.TabIndex = 40;
            // 
            // txt_hotenbn
            // 
            this.txt_hotenbn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_hotenbn.Enabled = false;
            this.txt_hotenbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_hotenbn.ForeColor = System.Drawing.Color.Black;
            this.txt_hotenbn.Location = new System.Drawing.Point(115, 19);
            this.txt_hotenbn.Name = "txt_hotenbn";
            this.txt_hotenbn.ReadOnly = true;
            this.txt_hotenbn.Size = new System.Drawing.Size(87, 20);
            this.txt_hotenbn.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Số điện thoại:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Địa chỉ:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Họ tên bệnh nhân:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(228, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Bản thân:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(17, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Gia đình:";
            // 
            // txt_para
            // 
            this.txt_para.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_para.BeepOnError = true;
            this.txt_para.Location = new System.Drawing.Point(299, 45);
            this.txt_para.Mask = "0000";
            this.txt_para.Name = "txt_para";
            this.txt_para.Size = new System.Drawing.Size(40, 20);
            this.txt_para.TabIndex = 44;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(235, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Para: 4 số:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(235, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Tuổi:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(284, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(235, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "ID:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(262, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 20);
            this.textBox2.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Tiền căn:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(73, 138);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(129, 70);
            this.richTextBox1.TabIndex = 51;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(284, 138);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(129, 70);
            this.richTextBox2.TabIndex = 52;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(6, 19);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(635, 105);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = "";
            // 
            // gd_khambenh
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(803, 583);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbl_tenbs);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(823, 626);
            this.MinimumSize = new System.Drawing.Size(823, 626);
            this.Name = "gd_khambenh";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khám bệnh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Gd_khambenh_FormClosing);
            this.Load += new System.EventHandler(this.gd_khambenh_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dsbn)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_lskb)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgv_dsbn;
        private System.Windows.Forms.Label lbl_tenbs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_kedonthuoc;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_xemdonthuoccu;
        private System.Windows.Forms.DataGridView dtgv_lskb;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.Button btn_refreshdsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masotoathuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaykham;
        private System.Windows.Forms.DataGridViewTextBoxColumn chandoan;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txt_para;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_sdtbn;
        private System.Windows.Forms.TextBox txt_diachibn;
        private System.Windows.Forms.TextBox txt_hotenbn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RichTextBox richTextBox3;
    }
}