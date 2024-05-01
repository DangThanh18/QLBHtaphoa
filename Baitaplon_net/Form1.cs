using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Baitaplon_net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string MaNV = textBox1.Text.Trim();
            string mk = textBox2.Text.Trim();
            string sql = "select Quyen from NhanVien where MaNV=N'" +
                MaNV + "' and Matkhau =N'" +
                mk + "'";
            string Quyen = DataAccess.LayMotGT(sql);

            if (Quyen == "")
            {
                MessageBox.Show(" Tài khoản không đúng!","Thống báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox1.Focus();
                textBox1.SelectAll();
                textBox2.Text = "";
            }
            else
            {
                qlyhethong frmMain = new qlyhethong(Quyen, MaNV);
                frmMain.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn chắc chắn muốn thoát chương trình", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(rs == DialogResult.Yes)
            {
                this.Close();
            }
            else if(rs == DialogResult.No)
            {
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string MaNV = textBox1.Text.Trim();
                string mk = textBox2.Text.Trim();
                string sql = "select Quyen from NhanVien where MaNV=N'" +
                    MaNV + "' and Matkhau =N'" +
                    mk + "'";
                string Quyen = DataAccess.LayMotGT(sql);
                if (Quyen == "")
                {
                    MessageBox.Show(" Tài khoản không đúng!", "Thống báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    textBox1.SelectAll();
                    textBox2.Text = "";
                }
                else
                {
                    qlyhethong frmMain = new qlyhethong(Quyen, MaNV);
                    frmMain.Show();
                    this.Hide();
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if(textBox1.Text.Trim() != "")
                {
                    textBox2.Focus();
                }
                else
                {
                    MessageBox.Show("Yêu cầu nhập đầy đủ thông tin đăng nhập ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnquenmk_Click(object sender, EventArgs e)
        {
            Hotrodangnhap frmMain = new Hotrodangnhap();
            frmMain.Show();
            this.Hide();
        }
    }
}
