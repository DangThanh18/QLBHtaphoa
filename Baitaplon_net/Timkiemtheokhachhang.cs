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
    public partial class Timkiemtheokhachhang : Form
    {
        public Timkiemtheokhachhang()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Timkiemtheokhachhang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataAccess.GetTable("select * from KhachHang");
            dataGridView1.Columns[0].HeaderText = "Mã KH";
            dataGridView1.Columns[1].HeaderText = "Tên KH";
            dataGridView1.Columns[2].HeaderText = "Địa chỉ";
            dataGridView1.Columns[3].HeaderText = "Email";
            dataGridView1.Columns[4].HeaderText = "Số ĐT";

            dataGridView1.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[4].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }
        private void TimKiem()
        {
            if (radioButton1.Checked == true)
            {     
                    string sql;
                    if (txttk.Text.Trim() == "")
                        sql = "select * from Khachhang";
                    else
                        sql = "select * from Khachhang where TenKKH like N'%" +
                        txttk.Text + "%'";

                    dataGridView1.DataSource = DataAccess.GetTable(sql);
            }
            if (radioButton2.Checked == true)
            {
                string sql;
                if (txttk.Text.Trim() == "")
                    sql = "select * from Khachhang";
                else
                    sql = "select * from Khachhang where DiaChi like N'%" +
                    txttk.Text + "%'";

                dataGridView1.DataSource = DataAccess.GetTable(sql);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimKiem();
        }
    }
}
