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
    public partial class TTKhachHang : Form
    {
        public TTKhachHang(string MaKH , string TenKH , string DiaChi, string Email,string DienThoai)
        {
            InitializeComponent();
            textBox1.Text = MaKH;
            textBox2.Text = TenKH;
            textBox3.Text = DiaChi;
            textBox4.Text = Email;
            textBox5.Text = DienThoai;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TTKhachHang_Load(object sender, EventArgs e)
        {

        }
    }
}
