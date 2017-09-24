namespace PHONGKHAM.GIAODIEN
{
    partial class gd_thongke
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gd_thongke));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idphieukham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenbs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chandoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.txt_timkiem);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(762, 508);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thống kê";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_timkiem.Location = new System.Drawing.Point(65, 19);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(113, 20);
            this.txt_timkiem.TabIndex = 8;
            this.txt_timkiem.Text = "search...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tìm kiếm:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idphieukham,
            this.idbn,
            this.tenbn,
            this.ngaylap,
            this.tenbs,
            this.chandoan});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(6, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(750, 457);
            this.dataGridView1.TabIndex = 0;
            // 
            // idphieukham
            // 
            this.idphieukham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idphieukham.HeaderText = "ID";
            this.idphieukham.Name = "idphieukham";
            this.idphieukham.ReadOnly = true;
            this.idphieukham.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idphieukham.Visible = false;
            this.idphieukham.Width = 45;
            // 
            // idbn
            // 
            this.idbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idbn.HeaderText = "IDBN";
            this.idbn.Name = "idbn";
            this.idbn.ReadOnly = true;
            this.idbn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.idbn.Width = 62;
            // 
            // tenbn
            // 
            this.tenbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tenbn.HeaderText = "Bệnh nhân";
            this.tenbn.Name = "tenbn";
            this.tenbn.ReadOnly = true;
            this.tenbn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tenbn.Width = 93;
            // 
            // ngaylap
            // 
            this.ngaylap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ngaylap.HeaderText = "Ngày lập";
            this.ngaylap.Name = "ngaylap";
            this.ngaylap.ReadOnly = true;
            this.ngaylap.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ngaylap.Width = 82;
            // 
            // tenbs
            // 
            this.tenbs.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tenbs.HeaderText = "Tên bác sĩ";
            this.tenbs.Name = "tenbs";
            this.tenbs.ReadOnly = true;
            this.tenbs.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tenbs.Width = 95;
            // 
            // chandoan
            // 
            this.chandoan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.chandoan.HeaderText = "Chẩn đoán";
            this.chandoan.Name = "chandoan";
            this.chandoan.ReadOnly = true;
            this.chandoan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.chandoan.Width = 94;
            // 
            // gd_thongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(786, 532);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gd_thongke";
            this.Text = "Thống kê";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.gd_thongke_FormClosing);
            this.Load += new System.EventHandler(this.gd_thongke_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn idphieukham;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaylap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenbs;
        private System.Windows.Forms.DataGridViewTextBoxColumn chandoan;
    }
}