
namespace Baitaplon_net
{
    partial class QLhoadon
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmaHD = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dbHD = new System.Windows.Forms.DataGridView();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.cbMaMatHang = new System.Windows.Forms.ComboBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.cbmaKH = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dbHD)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(388, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quản lý hóa đơn";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmaHD);
            this.groupBox1.Location = new System.Drawing.Point(47, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 52);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã hóa đơn";
            // 
            // txtmaHD
            // 
            this.txtmaHD.Location = new System.Drawing.Point(6, 21);
            this.txtmaHD.Name = "txtmaHD";
            this.txtmaHD.Size = new System.Drawing.Size(261, 22);
            this.txtmaHD.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtNgayXuat);
            this.groupBox2.Location = new System.Drawing.Point(47, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(273, 52);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ngày xuất hóa đơn";
            // 
            // dtNgayXuat
            // 
            this.dtNgayXuat.Location = new System.Drawing.Point(6, 24);
            this.dtNgayXuat.Name = "dtNgayXuat";
            this.dtNgayXuat.Size = new System.Drawing.Size(261, 22);
            this.dtNgayXuat.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbmaKH);
            this.groupBox3.Location = new System.Drawing.Point(47, 235);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(273, 52);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tên khách hàng";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbMaNV);
            this.groupBox4.Location = new System.Drawing.Point(47, 293);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(273, 52);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mã nhân viên";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtSoLuong);
            this.groupBox5.Location = new System.Drawing.Point(350, 177);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(273, 52);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Số lượng";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(6, 21);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(261, 22);
            this.txtSoLuong.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtGia);
            this.groupBox6.Location = new System.Drawing.Point(350, 119);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(273, 52);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Đơn giá";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(6, 21);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(261, 22);
            this.txtGia.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cbMaMatHang);
            this.groupBox7.Location = new System.Drawing.Point(350, 235);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(273, 52);
            this.groupBox7.TabIndex = 8;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tên mặt hàng";
            // 
            // dbHD
            // 
            this.dbHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbHD.Location = new System.Drawing.Point(47, 361);
            this.dbHD.Name = "dbHD";
            this.dbHD.RowHeadersWidth = 51;
            this.dbHD.RowTemplate.Height = 24;
            this.dbHD.Size = new System.Drawing.Size(624, 231);
            this.dbHD.TabIndex = 9;
            this.dbHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbHD_CellClick);
            this.dbHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbHD_CellContentClick);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.btnExit);
            this.groupBox8.Controls.Add(this.btnPrint);
            this.groupBox8.Controls.Add(this.btnXoa);
            this.groupBox8.Location = new System.Drawing.Point(715, 73);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(266, 312);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Chức năng";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnExit.Location = new System.Drawing.Point(71, 205);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(119, 58);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnPrint.Location = new System.Drawing.Point(34, 128);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(196, 58);
            this.btnPrint.TabIndex = 25;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.btnXoa.Location = new System.Drawing.Point(71, 46);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(119, 58);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Delete";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // cbMaMatHang
            // 
            this.cbMaMatHang.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaMatHang.FormattingEnabled = true;
            this.cbMaMatHang.Location = new System.Drawing.Point(6, 22);
            this.cbMaMatHang.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaMatHang.Name = "cbMaMatHang";
            this.cbMaMatHang.Size = new System.Drawing.Size(261, 23);
            this.cbMaMatHang.TabIndex = 20;
            // 
            // cbMaNV
            // 
            this.cbMaNV.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(7, 22);
            this.cbMaNV.Margin = new System.Windows.Forms.Padding(4);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(260, 23);
            this.cbMaNV.TabIndex = 19;
            // 
            // cbmaKH
            // 
            this.cbmaKH.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbmaKH.FormattingEnabled = true;
            this.cbmaKH.Location = new System.Drawing.Point(6, 21);
            this.cbmaKH.Margin = new System.Windows.Forms.Padding(4);
            this.cbmaKH.Name = "cbmaKH";
            this.cbmaKH.Size = new System.Drawing.Size(260, 23);
            this.cbmaKH.TabIndex = 18;
            // 
            // QLhoadon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 654);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.dbHD);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "QLhoadon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QLhoadon";
            this.Load += new System.EventHandler(this.QLhoadon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dbHD)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmaHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dbHD;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.DateTimePicker dtNgayXuat;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.ComboBox cbmaKH;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.ComboBox cbMaMatHang;
    }
}