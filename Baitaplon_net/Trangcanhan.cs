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
    public partial class Trangcanhan : Form
    {
        private string Quyen;
        private string MaNV;
        public Trangcanhan(string Quyen,string MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
            this.Quyen = Quyen;
            hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frmMain = new Form1();
            frmMain.Show();
            this.Hide();
        }

        public void hienthi()
        {
            string sql = "select TenNV from NhanVien where MaNV = '" + MaNV + "'";
            string ten = DataAccess.LayMotGT(sql);
            lbhoten.Text = String.Format("" + ten);
            txtten.Text = String.Format("" + ten);

            string sql1 = "select Diachi from NhanVien where MaNV = '" + MaNV + "'";
            string dc = DataAccess.LayMotGT(sql1);
            txtdiachi.Text = String.Format("" + dc);

            string sql2 = "select Matkhau from NhanVien where MaNV = '" + MaNV + "'";
            string mak = DataAccess.LayMotGT(sql2);
            txtmk.Text = String.Format("" + mak);

            txtma.Text = String.Format(""+MaNV);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            qlyhethong a = new qlyhethong(Quyen,MaNV);
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doimatkhau a = new Doimatkhau(MaNV);
            a.Show();
        }
    }
}
