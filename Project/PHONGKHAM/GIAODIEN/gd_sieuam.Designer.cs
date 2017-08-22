namespace PHONGKHAM.GIAODIEN
{
    partial class gd_sieuam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gd_sieuam));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupbox_dsbn = new System.Windows.Forms.GroupBox();
            this.btn_refreshdsbn = new System.Windows.Forms.Button();
            this.dtgv_dsbn = new System.Windows.Forms.DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tuoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.para = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nghenghiep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupbox_ttpk = new System.Windows.Forms.GroupBox();
            this.txt_nghenghiep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.btn_editphieukham = new System.Windows.Forms.Button();
            this.txt_tiencanbn = new System.Windows.Forms.TextBox();
            this.txt_tiencangd = new System.Windows.Forms.TextBox();
            this.txt_idbn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_tuoibn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_para = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_sdtbn = new System.Windows.Forms.TextBox();
            this.txt_diachibn = new System.Windows.Forms.TextBox();
            this.txt_hotenbn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupbox_dsbn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dsbn)).BeginInit();
            this.groupbox_ttpk.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox_dsbn
            // 
            this.groupbox_dsbn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupbox_dsbn.Controls.Add(this.btn_refreshdsbn);
            this.groupbox_dsbn.Controls.Add(this.dtgv_dsbn);
            this.groupbox_dsbn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupbox_dsbn.Location = new System.Drawing.Point(12, 12);
            this.groupbox_dsbn.Name = "groupbox_dsbn";
            this.groupbox_dsbn.Size = new System.Drawing.Size(393, 217);
            this.groupbox_dsbn.TabIndex = 0;
            this.groupbox_dsbn.TabStop = false;
            this.groupbox_dsbn.Text = "Danh sách bệnh nhân";
            // 
            // btn_refreshdsbn
            // 
            this.btn_refreshdsbn.FlatAppearance.BorderSize = 0;
            this.btn_refreshdsbn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refreshdsbn.Image = ((System.Drawing.Image)(resources.GetObject("btn_refreshdsbn.Image")));
            this.btn_refreshdsbn.Location = new System.Drawing.Point(354, 178);
            this.btn_refreshdsbn.Name = "btn_refreshdsbn";
            this.btn_refreshdsbn.Size = new System.Drawing.Size(33, 33);
            this.btn_refreshdsbn.TabIndex = 2;
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
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_dsbn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgv_dsbn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_dsbn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.id,
            this.hoten,
            this.diachi,
            this.sdt,
            this.tuoi,
            this.para,
            this.nghenghiep});
            this.dtgv_dsbn.Location = new System.Drawing.Point(6, 19);
            this.dtgv_dsbn.Name = "dtgv_dsbn";
            this.dtgv_dsbn.ReadOnly = true;
            this.dtgv_dsbn.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgv_dsbn.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv_dsbn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_dsbn.Size = new System.Drawing.Size(381, 157);
            this.dtgv_dsbn.TabIndex = 1;
            this.dtgv_dsbn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_dsbn_CellClick);
            // 
            // stt
            // 
            this.stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stt.HeaderText = "STT";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.stt.Width = 34;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.Visible = false;
            // 
            // hoten
            // 
            this.hoten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoten.DefaultCellStyle = dataGridViewCellStyle10;
            this.hoten.HeaderText = "Họ tên";
            this.hoten.MinimumWidth = 100;
            this.hoten.Name = "hoten";
            this.hoten.ReadOnly = true;
            this.hoten.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hoten.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // diachi
            // 
            this.diachi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.diachi.HeaderText = "Địa chỉ";
            this.diachi.Name = "diachi";
            this.diachi.ReadOnly = true;
            this.diachi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.diachi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.diachi.Width = 46;
            // 
            // sdt
            // 
            this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sdt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sdt.Width = 76;
            // 
            // tuoi
            // 
            this.tuoi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tuoi.HeaderText = "Tuổi";
            this.tuoi.Name = "tuoi";
            this.tuoi.ReadOnly = true;
            this.tuoi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tuoi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.tuoi.Width = 34;
            // 
            // para
            // 
            this.para.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.para.HeaderText = "PARA";
            this.para.Name = "para";
            this.para.ReadOnly = true;
            this.para.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.para.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.para.Width = 42;
            // 
            // nghenghiep
            // 
            this.nghenghiep.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nghenghiep.HeaderText = "Nghề nghiệp";
            this.nghenghiep.Name = "nghenghiep";
            this.nghenghiep.ReadOnly = true;
            this.nghenghiep.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.nghenghiep.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.nghenghiep.Width = 74;
            // 
            // groupbox_ttpk
            // 
            this.groupbox_ttpk.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupbox_ttpk.Controls.Add(this.txt_nghenghiep);
            this.groupbox_ttpk.Controls.Add(this.label7);
            this.groupbox_ttpk.Controls.Add(this.btn_cancel);
            this.groupbox_ttpk.Controls.Add(this.btn_accept);
            this.groupbox_ttpk.Controls.Add(this.btn_editphieukham);
            this.groupbox_ttpk.Controls.Add(this.txt_tiencanbn);
            this.groupbox_ttpk.Controls.Add(this.txt_tiencangd);
            this.groupbox_ttpk.Controls.Add(this.txt_idbn);
            this.groupbox_ttpk.Controls.Add(this.label10);
            this.groupbox_ttpk.Controls.Add(this.txt_tuoibn);
            this.groupbox_ttpk.Controls.Add(this.label9);
            this.groupbox_ttpk.Controls.Add(this.label12);
            this.groupbox_ttpk.Controls.Add(this.label5);
            this.groupbox_ttpk.Controls.Add(this.txt_para);
            this.groupbox_ttpk.Controls.Add(this.label6);
            this.groupbox_ttpk.Controls.Add(this.label4);
            this.groupbox_ttpk.Controls.Add(this.txt_sdtbn);
            this.groupbox_ttpk.Controls.Add(this.txt_diachibn);
            this.groupbox_ttpk.Controls.Add(this.txt_hotenbn);
            this.groupbox_ttpk.Controls.Add(this.label3);
            this.groupbox_ttpk.Controls.Add(this.label2);
            this.groupbox_ttpk.Controls.Add(this.label1);
            this.groupbox_ttpk.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_ttpk.Location = new System.Drawing.Point(411, 12);
            this.groupbox_ttpk.Name = "groupbox_ttpk";
            this.groupbox_ttpk.Size = new System.Drawing.Size(407, 217);
            this.groupbox_ttpk.TabIndex = 4;
            this.groupbox_ttpk.TabStop = false;
            this.groupbox_ttpk.Text = "Thông tin phiếu khám";
            // 
            // txt_nghenghiep
            // 
            this.txt_nghenghiep.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_nghenghiep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_nghenghiep.ForeColor = System.Drawing.Color.Black;
            this.txt_nghenghiep.Location = new System.Drawing.Point(297, 70);
            this.txt_nghenghiep.Name = "txt_nghenghiep";
            this.txt_nghenghiep.ReadOnly = true;
            this.txt_nghenghiep.Size = new System.Drawing.Size(104, 20);
            this.txt_nghenghiep.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(222, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Nghề nghiệp:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.Location = new System.Drawing.Point(236, 178);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(33, 33);
            this.btn_cancel.TabIndex = 48;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Visible = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.FlatAppearance.BorderSize = 0;
            this.btn_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accept.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_accept.Image = ((System.Drawing.Image)(resources.GetObject("btn_accept.Image")));
            this.btn_accept.Location = new System.Drawing.Point(164, 178);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(33, 33);
            this.btn_accept.TabIndex = 47;
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Visible = false;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // btn_editphieukham
            // 
            this.btn_editphieukham.FlatAppearance.BorderSize = 0;
            this.btn_editphieukham.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editphieukham.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_editphieukham.Image = ((System.Drawing.Image)(resources.GetObject("btn_editphieukham.Image")));
            this.btn_editphieukham.Location = new System.Drawing.Point(302, 178);
            this.btn_editphieukham.Name = "btn_editphieukham";
            this.btn_editphieukham.Size = new System.Drawing.Size(90, 33);
            this.btn_editphieukham.TabIndex = 2;
            this.btn_editphieukham.Text = "Chỉnh sửa";
            this.btn_editphieukham.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editphieukham.UseVisualStyleBackColor = true;
            this.btn_editphieukham.Visible = false;
            this.btn_editphieukham.Click += new System.EventHandler(this.btn_editphieukham_Click);
            // 
            // txt_tiencanbn
            // 
            this.txt_tiencanbn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tiencanbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_tiencanbn.ForeColor = System.Drawing.Color.Black;
            this.txt_tiencanbn.Location = new System.Drawing.Point(80, 152);
            this.txt_tiencanbn.Name = "txt_tiencanbn";
            this.txt_tiencanbn.ReadOnly = true;
            this.txt_tiencanbn.Size = new System.Drawing.Size(276, 20);
            this.txt_tiencanbn.TabIndex = 46;
            // 
            // txt_tiencangd
            // 
            this.txt_tiencangd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tiencangd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_tiencangd.ForeColor = System.Drawing.Color.Black;
            this.txt_tiencangd.Location = new System.Drawing.Point(80, 123);
            this.txt_tiencangd.Name = "txt_tiencangd";
            this.txt_tiencangd.ReadOnly = true;
            this.txt_tiencangd.Size = new System.Drawing.Size(276, 20);
            this.txt_tiencangd.TabIndex = 45;
            // 
            // txt_idbn
            // 
            this.txt_idbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_idbn.Location = new System.Drawing.Point(249, 17);
            this.txt_idbn.Name = "txt_idbn";
            this.txt_idbn.ReadOnly = true;
            this.txt_idbn.Size = new System.Drawing.Size(34, 20);
            this.txt_idbn.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.Location = new System.Drawing.Point(222, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 49;
            this.label10.Text = "ID:";
            // 
            // txt_tuoibn
            // 
            this.txt_tuoibn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_tuoibn.Location = new System.Drawing.Point(259, 44);
            this.txt_tuoibn.Name = "txt_tuoibn";
            this.txt_tuoibn.ReadOnly = true;
            this.txt_tuoibn.Size = new System.Drawing.Size(41, 20);
            this.txt_tuoibn.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label9.Location = new System.Drawing.Point(222, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Tuổi:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label12.Location = new System.Drawing.Point(24, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Bản thân:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label5.Location = new System.Drawing.Point(24, 126);
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
            this.txt_para.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_para.Location = new System.Drawing.Point(363, 17);
            this.txt_para.Mask = "0000";
            this.txt_para.Name = "txt_para";
            this.txt_para.ReadOnly = true;
            this.txt_para.Size = new System.Drawing.Size(40, 20);
            this.txt_para.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Tiền căn:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(299, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Para (4 số):";
            // 
            // txt_sdtbn
            // 
            this.txt_sdtbn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sdtbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_sdtbn.ForeColor = System.Drawing.Color.Black;
            this.txt_sdtbn.Location = new System.Drawing.Point(99, 70);
            this.txt_sdtbn.Name = "txt_sdtbn";
            this.txt_sdtbn.ReadOnly = true;
            this.txt_sdtbn.Size = new System.Drawing.Size(98, 20);
            this.txt_sdtbn.TabIndex = 41;
            // 
            // txt_diachibn
            // 
            this.txt_diachibn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_diachibn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_diachibn.ForeColor = System.Drawing.Color.Black;
            this.txt_diachibn.Location = new System.Drawing.Point(69, 44);
            this.txt_diachibn.Name = "txt_diachibn";
            this.txt_diachibn.ReadOnly = true;
            this.txt_diachibn.Size = new System.Drawing.Size(128, 20);
            this.txt_diachibn.TabIndex = 40;
            // 
            // txt_hotenbn
            // 
            this.txt_hotenbn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_hotenbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txt_hotenbn.ForeColor = System.Drawing.Color.Black;
            this.txt_hotenbn.Location = new System.Drawing.Point(122, 18);
            this.txt_hotenbn.Name = "txt_hotenbn";
            this.txt_hotenbn.ReadOnly = true;
            this.txt_hotenbn.Size = new System.Drawing.Size(75, 20);
            this.txt_hotenbn.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 73);
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
            this.label2.Location = new System.Drawing.Point(20, 47);
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
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Họ tên bệnh nhân:";
            // 
            // gd_sieuam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 241);
            this.Controls.Add(this.groupbox_ttpk);
            this.Controls.Add(this.groupbox_dsbn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "gd_sieuam";
            this.Text = "Siêu âm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.gd_sieuam_FormClosing);
            this.Load += new System.EventHandler(this.gd_sieuam_Load);
            this.groupbox_dsbn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dsbn)).EndInit();
            this.groupbox_ttpk.ResumeLayout(false);
            this.groupbox_ttpk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox_dsbn;
        private System.Windows.Forms.DataGridView dtgv_dsbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn tuoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn para;
        private System.Windows.Forms.DataGridViewTextBoxColumn nghenghiep;
        private System.Windows.Forms.GroupBox groupbox_ttpk;
        private System.Windows.Forms.TextBox txt_nghenghiep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Button btn_editphieukham;
        private System.Windows.Forms.TextBox txt_tiencanbn;
        private System.Windows.Forms.TextBox txt_tiencangd;
        private System.Windows.Forms.TextBox txt_idbn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_tuoibn;
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
        private System.Windows.Forms.Button btn_refreshdsbn;
    }
}