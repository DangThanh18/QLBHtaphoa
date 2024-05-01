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
    public partial class Doimatkhau : Form
    {
        string MaNV;
        public Doimatkhau(string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;
            string sql = "select Matkhau from NhanVien where MaNV = '" + MaNV + "'";
            string mak = DataAccess.LayMotGT(sql);
            if (a != mak)
            {
                MessageBox.Show("Nhập sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);  
            }
            else if (b != c)
            {
                MessageBox.Show("Nhập lại mật khẩu không khớp , yêu cầu nhập lại ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
                textBox3.Text = "";
            }
            else
            {
                string sql1 = "update NhanVien set Matkhau = '" + textBox3.Text + "' where MaNV = '" + MaNV + "' ";
                DataAccess.AddEditDelete(sql1);

                MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }
    }
}
