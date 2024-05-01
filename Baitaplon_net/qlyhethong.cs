using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baitaplon_net
{
    public partial class qlyhethong : Form
    {
        string Quyen;
        string MaNV;
        public qlyhethong(string Quyen,string MaNV)
        {
            InitializeComponent();
            this.Quyen = Quyen;
            this.MaNV = MaNV;
            panel1.Dock = DockStyle.Fill;
            hienthitentaikhoan();
        }
        private void AddForm(Form add)
        {
            this.panel4.Controls.Clear();
            add.TopLevel = false;
            add.AutoScroll = true;
            add.FormBorderStyle = FormBorderStyle.None;
            add.Dock = DockStyle.Fill;
            this.Text = add.Text;
            this.panel4.Controls.Add(add);
            add.Show();
        }
        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            QLhanghoa add = new QLhanghoa();
            AddForm(add);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            DanhSachMua add = new DanhSachMua(Quyen,MaNV,"");
            AddForm(add);
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            QLloaihang add = new QLloaihang();
            AddForm(add);
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            QlKhachhang add = new QlKhachhang(Quyen,MaNV,"");
            AddForm(add);
        }

        private void qlyhethong_Load(object sender, EventArgs e)
        {
            if(Quyen == "Nhân viên")
            {
                toolStripLabel5.Enabled = false;
                btnTongket.Enabled = false;
            }
            int margin = 10;
            panel2.Left = this.ClientSize.Width - panel2.Width;
            panel2.Top = 0;
            panel2.Height = this.ClientSize.Height;

            panel3.Dock = DockStyle.Bottom;

            //panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Size = new Size(1300, 690);

            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;

            // Bắt đầu Timer
            timer.Start();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            Tongket add = new Tongket(Quyen);
            AddForm(add);
        }

        private void button7_Click(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void qlyhethong_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tìmKiếmHàngHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timkiemhanghoa add = new Timkiemhanghoa();
            AddForm(add);
        }

        private void tìmKiếmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timkiemtheokhachhang add = new Timkiemtheokhachhang();
            AddForm(add);
        }

        public void hienthitentaikhoan()
        {
            string sql = "select TenNV from NhanVien where MaNV = '" + MaNV + "'";
            string ten = DataAccess.LayMotGT(sql);
            lbtennv.Text = String.Format(""+ten);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            lbtime.Text = currentTime.ToString("HH:mm:ss");
        }

        private void btnTongket_Click(object sender, EventArgs e)
        {
            Tongket add = new Tongket(Quyen);
            AddForm(add);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            QlKhachhang add = new QlKhachhang(Quyen, MaNV, "");
            AddForm(add);
        }

        private void btnhanghoa_Click(object sender, EventArgs e)
        {
            QLhanghoa add = new QLhanghoa();
            AddForm(add);
        }

        private void btnloaihang_Click(object sender, EventArgs e)
        {
            QLloaihang add = new QLloaihang();
            AddForm(add);
        }

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            DanhSachMua add = new DanhSachMua(Quyen, MaNV, "");
            AddForm(add);
        }

        private void lbtennv_Click(object sender, EventArgs e)
        {
            Trangcanhan a = new Trangcanhan(Quyen,MaNV);
            a.Show();
            this.Hide();
        }
    }
}
