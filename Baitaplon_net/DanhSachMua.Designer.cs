
namespace Baitaplon_net
{
    partial class DanhSachMua
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
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbTenKH = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiatien = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtTenhh = new System.Windows.Forms.TextBox();
            this.txtMahang = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTongHoaDon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTienKhach = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTraLai = new System.Windows.Forms.TextBox();
            this.datamuahang = new System.Windows.Forms.DataGridView();
            this.cbDaily = new System.Windows.Forms.RadioButton();
            this.cbkhtt = new System.Windows.Forms.RadioButton();
            this.txtloaihang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnnew = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamuahang)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaHD);
            this.groupBox1.Location = new System.Drawing.Point(10, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 62);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mã Hóa Đơn";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMaHD.Location = new System.Drawing.Point(7, 22);
            this.txtMaHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(358, 30);
            this.txtMaHD.TabIndex = 46;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbTenKH);
            this.groupBox2.Location = new System.Drawing.Point(10, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 64);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tên khách hàng";
            // 
            // cbTenKH
            // 
            this.cbTenKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTenKH.FormattingEnabled = true;
            this.cbTenKH.Items.AddRange(new object[] {
            "...."});
            this.cbTenKH.Location = new System.Drawing.Point(0, 22);
            this.cbTenKH.Margin = new System.Windows.Forms.Padding(4);
            this.cbTenKH.Name = "cbTenKH";
            this.cbTenKH.Size = new System.Drawing.Size(365, 33);
            this.cbTenKH.TabIndex = 68;
            this.cbTenKH.SelectedIndexChanged += new System.EventHandler(this.cbTenKH_SelectedIndexChanged);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(784, 541);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(218, 35);
            this.btnCreate.TabIndex = 69;
            this.btnCreate.Text = "Tạo hóa đơn";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(423, 115);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(807, 236);
            this.dataGridView2.TabIndex = 70;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(473, 541);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 35);
            this.button1.TabIndex = 72;
            this.button1.Text = "Xem tổng số hóa đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Bold);
            this.btnExit.Location = new System.Drawing.Point(1075, 541);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 35);
            this.btnExit.TabIndex = 73;
            this.btnExit.Text = "Print";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(254, 343);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 77;
            this.label5.Text = "Giá tiền";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(248, 423);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 76;
            this.label4.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(7, 423);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 75;
            this.label1.Text = "Tên hàng hóa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(7, 343);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 74;
            this.label6.Text = "Mã hàng hóa";
            // 
            // txtGiatien
            // 
            this.txtGiatien.Enabled = false;
            this.txtGiatien.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtGiatien.Location = new System.Drawing.Point(251, 364);
            this.txtGiatien.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiatien.Name = "txtGiatien";
            this.txtGiatien.Size = new System.Drawing.Size(156, 25);
            this.txtGiatien.TabIndex = 81;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSoLuong.Location = new System.Drawing.Point(251, 463);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(156, 25);
            this.txtSoLuong.TabIndex = 80;
            this.txtSoLuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSoLuong_KeyDown);
            // 
            // txtTenhh
            // 
            this.txtTenhh.Enabled = false;
            this.txtTenhh.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenhh.Location = new System.Drawing.Point(10, 444);
            this.txtTenhh.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenhh.Name = "txtTenhh";
            this.txtTenhh.Size = new System.Drawing.Size(165, 25);
            this.txtTenhh.TabIndex = 79;
            // 
            // txtMahang
            // 
            this.txtMahang.Enabled = false;
            this.txtMahang.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMahang.Location = new System.Drawing.Point(10, 364);
            this.txtMahang.Margin = new System.Windows.Forms.Padding(4);
            this.txtMahang.Name = "txtMahang";
            this.txtMahang.Size = new System.Drawing.Size(165, 25);
            this.txtMahang.TabIndex = 78;
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThem.Location = new System.Drawing.Point(473, 606);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(259, 53);
            this.btnThem.TabIndex = 82;
            this.btnThem.Text = "Thanh toán";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(48, 541);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 85;
            this.label7.Text = "Thành tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtThanhTien.Location = new System.Drawing.Point(183, 538);
            this.txtThanhTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(192, 27);
            this.txtThanhTien.TabIndex = 84;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(33, 592);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 87;
            this.label8.Text = "Tổng hóa đơn";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtTongHoaDon
            // 
            this.txtTongHoaDon.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTongHoaDon.Location = new System.Drawing.Point(183, 589);
            this.txtTongHoaDon.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongHoaDon.Name = "txtTongHoaDon";
            this.txtTongHoaDon.Size = new System.Drawing.Size(192, 27);
            this.txtTongHoaDon.TabIndex = 86;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.Location = new System.Drawing.Point(49, 640);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 19);
            this.label10.TabIndex = 91;
            this.label10.Text = "Khách đưa";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txtTienKhach
            // 
            this.txtTienKhach.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTienKhach.Location = new System.Drawing.Point(183, 632);
            this.txtTienKhach.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienKhach.Name = "txtTienKhach";
            this.txtTienKhach.Size = new System.Drawing.Size(192, 27);
            this.txtTienKhach.TabIndex = 90;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.Location = new System.Drawing.Point(35, 689);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 19);
            this.label9.TabIndex = 89;
            this.label9.Text = "Trả lại khách";
            // 
            // txtTraLai
            // 
            this.txtTraLai.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTraLai.Location = new System.Drawing.Point(183, 681);
            this.txtTraLai.Margin = new System.Windows.Forms.Padding(4);
            this.txtTraLai.Name = "txtTraLai";
            this.txtTraLai.ReadOnly = true;
            this.txtTraLai.Size = new System.Drawing.Size(192, 27);
            this.txtTraLai.TabIndex = 88;
            // 
            // datamuahang
            // 
            this.datamuahang.BackgroundColor = System.Drawing.Color.White;
            this.datamuahang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datamuahang.Location = new System.Drawing.Point(473, 364);
            this.datamuahang.Name = "datamuahang";
            this.datamuahang.RowHeadersWidth = 51;
            this.datamuahang.RowTemplate.Height = 24;
            this.datamuahang.Size = new System.Drawing.Size(718, 150);
            this.datamuahang.TabIndex = 92;
            // 
            // cbDaily
            // 
            this.cbDaily.AutoSize = true;
            this.cbDaily.Location = new System.Drawing.Point(17, 114);
            this.cbDaily.Name = "cbDaily";
            this.cbDaily.Size = new System.Drawing.Size(142, 21);
            this.cbDaily.TabIndex = 93;
            this.cbDaily.TabStop = true;
            this.cbDaily.Text = "Khách hàng đại lý";
            this.cbDaily.UseVisualStyleBackColor = true;
            this.cbDaily.CheckedChanged += new System.EventHandler(this.cbDaily_CheckedChanged_1);
            // 
            // cbkhtt
            // 
            this.cbkhtt.AutoSize = true;
            this.cbkhtt.Location = new System.Drawing.Point(203, 114);
            this.cbkhtt.Name = "cbkhtt";
            this.cbkhtt.Size = new System.Drawing.Size(168, 21);
            this.cbkhtt.TabIndex = 94;
            this.cbkhtt.TabStop = true;
            this.cbkhtt.Text = "Khách hàng thân thiết";
            this.cbkhtt.UseVisualStyleBackColor = true;
            this.cbkhtt.CheckedChanged += new System.EventHandler(this.cbkhtt_CheckedChanged);
            // 
            // txtloaihang
            // 
            this.txtloaihang.Enabled = false;
            this.txtloaihang.Location = new System.Drawing.Point(134, 300);
            this.txtloaihang.Name = "txtloaihang";
            this.txtloaihang.Size = new System.Drawing.Size(158, 22);
            this.txtloaihang.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(33, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 19);
            this.label2.TabIndex = 96;
            this.label2.Text = "Loại hàng";
            // 
            // btnnew
            // 
            this.btnnew.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnnew.Location = new System.Drawing.Point(784, 606);
            this.btnnew.Margin = new System.Windows.Forms.Padding(4);
            this.btnnew.Name = "btnnew";
            this.btnnew.Size = new System.Drawing.Size(218, 53);
            this.btnnew.TabIndex = 97;
            this.btnnew.Text = "Làm mới";
            this.btnnew.UseVisualStyleBackColor = true;
            this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
            // 
            // DanhSachMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 782);
            this.Controls.Add(this.btnnew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtloaihang);
            this.Controls.Add(this.cbkhtt);
            this.Controls.Add(this.cbDaily);
            this.Controls.Add(this.datamuahang);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTienKhach);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTraLai);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTongHoaDon);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGiatien);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtTenhh);
            this.Controls.Add(this.txtMahang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DanhSachMua";
            this.Text = "DanhSachMua";
            this.Load += new System.EventHandler(this.DanhSachMua_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamuahang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbTenKH;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtGiatien;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtTenhh;
        private System.Windows.Forms.TextBox txtMahang;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTongHoaDon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTienKhach;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTraLai;
        private System.Windows.Forms.DataGridView datamuahang;
        private System.Windows.Forms.RadioButton cbDaily;
        private System.Windows.Forms.RadioButton cbkhtt;
        private System.Windows.Forms.TextBox txtloaihang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnnew;
    }
}