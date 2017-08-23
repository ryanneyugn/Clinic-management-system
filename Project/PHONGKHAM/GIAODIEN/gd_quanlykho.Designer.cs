namespace PHONGKHAM.GIAODIEN
{
    partial class gd_quanlykho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gd_quanlykho));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupbox_control = new System.Windows.Forms.GroupBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.txt_hsd = new System.Windows.Forms.TextBox();
            this.txt_giaban = new System.Windows.Forms.TextBox();
            this.txt_giamua = new System.Windows.Forms.TextBox();
            this.txt_tenthuoc = new System.Windows.Forms.TextBox();
            this.txt_dvt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupbox_dsthuoc = new System.Windows.Forms.GroupBox();
            this.btn_tim = new System.Windows.Forms.Button();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtgv_dsthuoc = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giamua = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaban = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupbox_control.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupbox_dsthuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dsthuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupbox_control);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupbox_dsthuoc);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kho thuốc";
            // 
            // groupbox_control
            // 
            this.groupbox_control.Controls.Add(this.btn_thoat);
            this.groupbox_control.Controls.Add(this.btn_them);
            this.groupbox_control.Controls.Add(this.btn_xoa);
            this.groupbox_control.Controls.Add(this.btn_edit);
            this.groupbox_control.Location = new System.Drawing.Point(320, 247);
            this.groupbox_control.Name = "groupbox_control";
            this.groupbox_control.Size = new System.Drawing.Size(298, 93);
            this.groupbox_control.TabIndex = 17;
            this.groupbox_control.TabStop = false;
            // 
            // btn_thoat
            // 
            this.btn_thoat.FlatAppearance.BorderSize = 0;
            this.btn_thoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thoat.Image = ((System.Drawing.Image)(resources.GetObject("btn_thoat.Image")));
            this.btn_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thoat.Location = new System.Drawing.Point(173, 49);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(77, 38);
            this.btn_thoat.TabIndex = 20;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.Btn_thoat_Click);
            // 
            // btn_them
            // 
            this.btn_them.FlatAppearance.BorderSize = 0;
            this.btn_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them.Image = ((System.Drawing.Image)(resources.GetObject("btn_them.Image")));
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_them.Location = new System.Drawing.Point(34, 17);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(84, 31);
            this.btn_them.TabIndex = 19;
            this.btn_them.Text = "Thêm mới";
            this.btn_them.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.Image = ((System.Drawing.Image)(resources.GetObject("btn_xoa.Image")));
            this.btn_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_xoa.Location = new System.Drawing.Point(34, 53);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(60, 30);
            this.btn_xoa.TabIndex = 18;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Enabled = false;
            this.btn_edit.FlatAppearance.BorderSize = 0;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_edit.Image")));
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(173, 17);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(89, 31);
            this.btn_edit.TabIndex = 17;
            this.btn_edit.Text = "Chỉnh sửa";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_cancel);
            this.groupBox3.Controls.Add(this.btn_accept);
            this.groupBox3.Controls.Add(this.txt_soluong);
            this.groupBox3.Controls.Add(this.txt_hsd);
            this.groupBox3.Controls.Add(this.txt_giaban);
            this.groupBox3.Controls.Add(this.txt_giamua);
            this.groupBox3.Controls.Add(this.txt_tenthuoc);
            this.groupBox3.Controls.Add(this.txt_dvt);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(320, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 233);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin thuốc";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Enabled = false;
            this.btn_cancel.FlatAppearance.BorderSize = 0;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancel.Image")));
            this.btn_cancel.Location = new System.Drawing.Point(173, 183);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(39, 39);
            this.btn_cancel.TabIndex = 14;
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.Enabled = false;
            this.btn_accept.FlatAppearance.BorderSize = 0;
            this.btn_accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_accept.Image = ((System.Drawing.Image)(resources.GetObject("btn_accept.Image")));
            this.btn_accept.Location = new System.Drawing.Point(108, 183);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(39, 39);
            this.btn_accept.TabIndex = 13;
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(98, 157);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.ReadOnly = true;
            this.txt_soluong.Size = new System.Drawing.Size(185, 20);
            this.txt_soluong.TabIndex = 11;
            // 
            // txt_hsd
            // 
            this.txt_hsd.Location = new System.Drawing.Point(98, 131);
            this.txt_hsd.Name = "txt_hsd";
            this.txt_hsd.ReadOnly = true;
            this.txt_hsd.Size = new System.Drawing.Size(185, 20);
            this.txt_hsd.TabIndex = 10;
            // 
            // txt_giaban
            // 
            this.txt_giaban.Location = new System.Drawing.Point(98, 105);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.ReadOnly = true;
            this.txt_giaban.Size = new System.Drawing.Size(185, 20);
            this.txt_giaban.TabIndex = 9;
            // 
            // txt_giamua
            // 
            this.txt_giamua.Location = new System.Drawing.Point(98, 79);
            this.txt_giamua.Name = "txt_giamua";
            this.txt_giamua.ReadOnly = true;
            this.txt_giamua.Size = new System.Drawing.Size(185, 20);
            this.txt_giamua.TabIndex = 8;
            // 
            // txt_tenthuoc
            // 
            this.txt_tenthuoc.Location = new System.Drawing.Point(98, 27);
            this.txt_tenthuoc.Name = "txt_tenthuoc";
            this.txt_tenthuoc.ReadOnly = true;
            this.txt_tenthuoc.Size = new System.Drawing.Size(185, 20);
            this.txt_tenthuoc.TabIndex = 7;
            // 
            // txt_dvt
            // 
            this.txt_dvt.Location = new System.Drawing.Point(98, 53);
            this.txt_dvt.Name = "txt_dvt";
            this.txt_dvt.ReadOnly = true;
            this.txt_dvt.Size = new System.Drawing.Size(185, 20);
            this.txt_dvt.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng tồn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hạn sử dụng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giá bán:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giá mua:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn vị tính:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên thuốc:";
            // 
            // groupbox_dsthuoc
            // 
            this.groupbox_dsthuoc.Controls.Add(this.btn_tim);
            this.groupbox_dsthuoc.Controls.Add(this.txt_timkiem);
            this.groupbox_dsthuoc.Controls.Add(this.label7);
            this.groupbox_dsthuoc.Controls.Add(this.dtgv_dsthuoc);
            this.groupbox_dsthuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_dsthuoc.Location = new System.Drawing.Point(6, 19);
            this.groupbox_dsthuoc.Name = "groupbox_dsthuoc";
            this.groupbox_dsthuoc.Size = new System.Drawing.Size(308, 321);
            this.groupbox_dsthuoc.TabIndex = 0;
            this.groupbox_dsthuoc.TabStop = false;
            this.groupbox_dsthuoc.Text = "Danh sách ";
            // 
            // btn_tim
            // 
            this.btn_tim.FlatAppearance.BorderSize = 0;
            this.btn_tim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tim.Image = ((System.Drawing.Image)(resources.GetObject("btn_tim.Image")));
            this.btn_tim.Location = new System.Drawing.Point(273, 19);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(29, 20);
            this.btn_tim.TabIndex = 6;
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(144, 19);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(129, 20);
            this.txt_timkiem.TabIndex = 5;
            this.txt_timkiem.Text = "search...";
            this.txt_timkiem.Enter += new System.EventHandler(this.txt_timkiem_Enter);
            this.txt_timkiem.Leave += new System.EventHandler(this.txt_timkiem_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tìm kiếm:";
            // 
            // dtgv_dsthuoc
            // 
            this.dtgv_dsthuoc.AllowUserToAddRows = false;
            this.dtgv_dsthuoc.AllowUserToDeleteRows = false;
            this.dtgv_dsthuoc.AllowUserToResizeColumns = false;
            this.dtgv_dsthuoc.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_dsthuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv_dsthuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgv_dsthuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tenthuoc,
            this.dvt,
            this.soluong,
            this.giamua,
            this.giaban,
            this.hsd});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv_dsthuoc.DefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv_dsthuoc.Location = new System.Drawing.Point(6, 45);
            this.dtgv_dsthuoc.Name = "dtgv_dsthuoc";
            this.dtgv_dsthuoc.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv_dsthuoc.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv_dsthuoc.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgv_dsthuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgv_dsthuoc.Size = new System.Drawing.Size(296, 270);
            this.dtgv_dsthuoc.TabIndex = 0;
            this.dtgv_dsthuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_dsthuoc_CellClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // tenthuoc
            // 
            this.tenthuoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tenthuoc.HeaderText = "Tên thuốc";
            this.tenthuoc.Name = "tenthuoc";
            this.tenthuoc.ReadOnly = true;
            this.tenthuoc.Width = 81;
            // 
            // dvt
            // 
            this.dvt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dvt.HeaderText = "Đơn vị tính";
            this.dvt.Name = "dvt";
            this.dvt.ReadOnly = true;
            this.dvt.Width = 85;
            // 
            // soluong
            // 
            this.soluong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.soluong.HeaderText = "Số lượng";
            this.soluong.Name = "soluong";
            this.soluong.ReadOnly = true;
            this.soluong.Width = 74;
            // 
            // giamua
            // 
            this.giamua.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.giamua.HeaderText = "Giá mua";
            this.giamua.Name = "giamua";
            this.giamua.ReadOnly = true;
            this.giamua.Width = 71;
            // 
            // giaban
            // 
            this.giaban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.giaban.HeaderText = "Giá bán";
            this.giaban.Name = "giaban";
            this.giaban.ReadOnly = true;
            this.giaban.Width = 69;
            // 
            // hsd
            // 
            this.hsd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.hsd.HeaderText = "Hạn sử dụng";
            this.hsd.Name = "hsd";
            this.hsd.ReadOnly = true;
            this.hsd.Width = 93;
            // 
            // gd_quanlykho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 366);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "gd_quanlykho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thuốc trong kho";
            this.Activated += new System.EventHandler(this.gd_quanlykho_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.gd_quanlykho_FormClosing);
            this.Load += new System.EventHandler(this.gd_quanlykho_Load);            
            this.groupBox1.ResumeLayout(false);
            this.groupbox_control.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupbox_dsthuoc.ResumeLayout(false);
            this.groupbox_dsthuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_dsthuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupbox_dsthuoc;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.TextBox txt_hsd;
        private System.Windows.Forms.TextBox txt_giaban;
        private System.Windows.Forms.TextBox txt_giamua;
        private System.Windows.Forms.TextBox txt_tenthuoc;
        private System.Windows.Forms.TextBox txt_dvt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_dsthuoc;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn giamua;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaban;
        private System.Windows.Forms.DataGridViewTextBoxColumn hsd;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupbox_control;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_edit;
    }
}