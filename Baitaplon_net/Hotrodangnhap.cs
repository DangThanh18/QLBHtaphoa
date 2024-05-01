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
    public partial class Hotrodangnhap : Form
    {
        public Hotrodangnhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 frmMain = new Form1();
            frmMain.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select MatKhau from NhanVien where MaNV = '"+textBox1.Text+"'";
            string laylaimk = DataAccess.LayMotGT(sql);
            if(laylaimk == "")
            {
                MessageBox.Show("Mã nhân viên này không tồn tại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                textBox2.Text = laylaimk;
            }
        }
    }
}
