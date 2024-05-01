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
    public partial class Timkiemhanghoa : Form
    {
        public Timkiemhanghoa()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Timkiemhanghoa_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataAccess.GetTable("select * from Hanghoa");
            dataGridView1.Columns[0].HeaderText = "Mã Hàng";
            dataGridView1.Columns[1].HeaderText = "Mã Loại";
            dataGridView1.Columns[2].HeaderText = "Tên Hàng";
            dataGridView1.Columns[3].HeaderText = "Đơn Vị Tính";

            dataGridView1.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[3].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void TimKiem()
        {
            if (radioButton1.Checked == true)
            {
                string sql;
                if (txttk.Text.Trim() == "")
                    sql = "select * from Hanghoa";
                else
                    sql = "select * from Hanghoa where Mahang like N'%" +
                    txttk.Text + "%'";

                dataGridView1.DataSource = DataAccess.GetTable(sql);
            }
            if (radioButton2.Checked == true)
            {
                string sql;
                if (txttk.Text.Trim() == "")
                    sql = "select * from Hanghoa";
                else
                    sql = "select * from Hanghoa where Maloai like N'%" +
                    txttk.Text + "%'";

                dataGridView1.DataSource = DataAccess.GetTable(sql);
            }
            if (radioButton3.Checked == true)
            {
                string sql;
                if (txttk.Text.Trim() == "")
                    sql = "select * from Hanghoa";
                else
                    sql = "select * from Hanghoa where Tenhang like N'%" +
                    txttk.Text + "%'";

                dataGridView1.DataSource = DataAccess.GetTable(sql);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TimKiem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
