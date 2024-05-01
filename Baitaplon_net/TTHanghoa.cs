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
    public partial class TTHanghoa : Form
    {
        public TTHanghoa(string Mahang, string Maloai, string Tenhang, string DVT, string DonGia)
        {
            InitializeComponent();
            textBox1.Text = Mahang;
            textBox2.Text = Maloai;
            textBox3.Text = Tenhang;
            textBox4.Text = DVT;
            textBox5.Text = DonGia;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
