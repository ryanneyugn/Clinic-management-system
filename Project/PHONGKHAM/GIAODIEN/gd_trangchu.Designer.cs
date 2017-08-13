namespace PHONGKHAM.GIAODIEN
{
    partial class gd_trangchu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gd_trangchu));
            this.btn_khambenh = new System.Windows.Forms.Button();
            this.btn_thongke = new System.Windows.Forms.Button();
            this.btn_quanlykho = new System.Windows.Forms.Button();
            this.btn_sieuam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_khambenh
            // 
            this.btn_khambenh.FlatAppearance.BorderSize = 0;
            this.btn_khambenh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_khambenh.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_khambenh.Image = ((System.Drawing.Image)(resources.GetObject("btn_khambenh.Image")));
            this.btn_khambenh.Location = new System.Drawing.Point(12, 19);
            this.btn_khambenh.Name = "btn_khambenh";
            this.btn_khambenh.Size = new System.Drawing.Size(160, 160);
            this.btn_khambenh.TabIndex = 0;
            this.btn_khambenh.Text = "Khám bệnh";
            this.btn_khambenh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_khambenh.UseVisualStyleBackColor = true;
            this.btn_khambenh.Click += new System.EventHandler(this.Btn_khambenh_Click);
            // 
            // btn_thongke
            // 
            this.btn_thongke.FlatAppearance.BorderSize = 0;
            this.btn_thongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thongke.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_thongke.Image = ((System.Drawing.Image)(resources.GetObject("btn_thongke.Image")));
            this.btn_thongke.Location = new System.Drawing.Point(178, 19);
            this.btn_thongke.Name = "btn_thongke";
            this.btn_thongke.Size = new System.Drawing.Size(160, 160);
            this.btn_thongke.TabIndex = 1;
            this.btn_thongke.Text = "Thống kê";
            this.btn_thongke.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_thongke.UseVisualStyleBackColor = true;
            this.btn_thongke.Click += new System.EventHandler(this.Btn_thongke_Click);
            // 
            // btn_quanlykho
            // 
            this.btn_quanlykho.FlatAppearance.BorderSize = 0;
            this.btn_quanlykho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quanlykho.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold);
            this.btn_quanlykho.Image = ((System.Drawing.Image)(resources.GetObject("btn_quanlykho.Image")));
            this.btn_quanlykho.Location = new System.Drawing.Point(510, 19);
            this.btn_quanlykho.Name = "btn_quanlykho";
            this.btn_quanlykho.Size = new System.Drawing.Size(160, 160);
            this.btn_quanlykho.TabIndex = 2;
            this.btn_quanlykho.Text = "Quản lý kho";
            this.btn_quanlykho.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_quanlykho.UseVisualStyleBackColor = true;
            this.btn_quanlykho.Click += new System.EventHandler(this.Btn_quanlykho_Click);
            // 
            // btn_sieuam
            // 
            this.btn_sieuam.FlatAppearance.BorderSize = 0;
            this.btn_sieuam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sieuam.Font = new System.Drawing.Font("Book Antiqua", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sieuam.Image = ((System.Drawing.Image)(resources.GetObject("btn_sieuam.Image")));
            this.btn_sieuam.Location = new System.Drawing.Point(344, 19);
            this.btn_sieuam.Name = "btn_sieuam";
            this.btn_sieuam.Size = new System.Drawing.Size(160, 160);
            this.btn_sieuam.TabIndex = 3;
            this.btn_sieuam.Text = "Siêu âm";
            this.btn_sieuam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_sieuam.UseVisualStyleBackColor = true;
            this.btn_sieuam.Click += new System.EventHandler(this.btn_sieuam_Click);
            // 
            // gd_trangchu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 198);
            this.Controls.Add(this.btn_sieuam);
            this.Controls.Add(this.btn_quanlykho);
            this.Controls.Add(this.btn_thongke);
            this.Controls.Add(this.btn_khambenh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "gd_trangchu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.gd_trangchu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_khambenh;
        private System.Windows.Forms.Button btn_thongke;
        private System.Windows.Forms.Button btn_quanlykho;
        private System.Windows.Forms.Button btn_sieuam;
    }
}