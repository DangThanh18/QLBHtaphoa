using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Baitaplon_net
{
    public partial class QLhanghoa : Form
    {
        #region Hằng xâu 
        string THEM = "Thêm";
        string HUY = "Hủy";
        string LUU = "Lưu";
        string LUUSUA = "Lưu sửa";
        string LUUBANGHI = "Lưu thêm";
        string SUA = "Sửa";
        string XOA = "Xóa";
        string THOAT = "Thoát";
        string TIMKIEM = "Tìm kiếm";
        #endregion
        private int cr;
        public QLhanghoa()
        {
            InitializeComponent();            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            xoa();
        }
        public void xoa()
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn XÓA", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                string sql = "delete from CT_Hoadon where Mahang=N'" + txtmahang.Text + "'";
                DataAccess.AddEditDelete(sql);
                string sql1 = "delete from Hanghoa where Mahang=N'" + txtmahang.Text + "'";
                DataAccess.AddEditDelete(sql1);

                dataGridView1.DataSource = DataAccess.GetTable("select * from Hanghoa");
                MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            them();
        }
        public void them()
        {
            if (btnThem.Text == THEM)
            {
                txtmahang.Enabled = true;
                cbmaloai.Enabled = true;
                txtTenhang.Enabled = true;
                txtDonvitinh.Enabled = true;
                txtDongia.Enabled = true;
                txtmahang.Clear();
                cbmaloai.SelectedItem = 0;
                txtTenhang.Clear();
                txtDonvitinh.Clear();
                txtDongia.Clear();

                btnSua.Enabled = false;
                btnTimKiem.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Text = HUY;
                btnLuu.Text = LUUBANGHI;
                btnLuu.Enabled = true;
            }
            else
            {
                    txtmahang.Enabled = false;
                    cbmaloai.Enabled = false;
                    txtTenhang.Enabled = false;
                    txtDonvitinh.Enabled = false;

                    btnThem.Text = THEM;
                    btnXoa.Enabled = true;
                    btnTimKiem.Enabled = true;
                    btnSua.Enabled = true;
                    btnLuu.Text = LUU;
                    btnLuu.Enabled = false;
                    KhoiPhuc(cr);
            }
        }

        private void QLhanghoa_Load(object sender, EventArgs e)
        {
            btnThem.Text = THEM;
            btnSua.Text = SUA;
            btnXoa.Text = XOA;
            btnThoat.Text = THOAT;
            btnTimKiem.Text = TIMKIEM;

            txtmahang.Enabled = false;
            cbmaloai.Enabled = false;
            txtTenhang.Enabled = false;
            txtDonvitinh.Enabled = false;
            txtDongia.Enabled = false;

            btnLuu.Enabled = false;

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

            string connectionString = @"Data Source=THANHNEK;Initial Catalog=dbbtl_net;Integrated Security=True";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Maloai FROM Loaihang";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        cbmaloai.DataSource = dataTable;
                        cbmaloai.DisplayMember = "Maloai";
                    }
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sua();
        }
        public void sua()
        {
            if (btnSua.Text == SUA)
            {
                txtmahang.Enabled = true;
                cbmaloai.Enabled = true;
                txtTenhang.Enabled = true;
                txtDonvitinh.Enabled = true;
                txtDongia.Enabled = true;
                btnLuu.Text = LUUSUA;
                btnSua.Text = HUY;
                btnThem.Enabled = false;
                btnLuu.Enabled = true;
                btnXoa.Enabled = false;
                btnTimKiem.Enabled = false;
                txtmahang.Focus();
            }
            else
            {         
                txtmahang.Enabled = false;
                cbmaloai.Enabled = false;
                txtTenhang.Enabled = false;
                txtDonvitinh.Enabled = false;
                txtDongia.Enabled = false;
                btnSua.Text = SUA;
                btnLuu.Text = LUU;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnTimKiem.Enabled = true;
                btnThoat.Enabled = true;
                KhoiPhuc(cr);               
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            thoat();
        }
        public void thoat()
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn thoát", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
            else if (rs == DialogResult.No)
            {
                KhoiPhuc(cr);
            }
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
        }    
        private void button6_Click(object sender, EventArgs e)
        {
            Timkiemhanghoa a = new Timkiemhanghoa();
            a.Show();
        }
        private void KhoiPhuc(int i)
        {
            txtmahang.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            cbmaloai.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtTenhang.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtDonvitinh.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtDongia.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtmahang.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                cbmaloai.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtTenhang.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtDonvitinh.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtDongia.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void txtTenhang_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void thêmThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "insert into Hanghoa values(N'" +
                              txtmahang.Text + "', N'" +
                              cbmaloai.Text + "', N'" +
                              txtTenhang.Text + "', N'" +
                              txtDonvitinh.Text + "', N'" +
                              txtDongia.Text + "')";
            DataAccess.AddEditDelete(sql);
            dataGridView1.DataSource = DataAccess.GetTable("select * from Hanghoa");
        }

        private void sửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string sql = "update Hanghoa set Maloai =N'" +
                        cbmaloai.Text + "', Tenhang =N'" +
                        txtTenhang.Text + "', DVT =N'" +
                        txtDonvitinh.Text + "', DonGia =N'" +
                        txtDongia.Text + "' where Mahang=N'" +
                        txtmahang.Text + "'";
            DataAccess.AddEditDelete(sql);
            dataGridView1.DataSource = DataAccess.GetTable("select * from Hanghoa");
            MessageBox.Show("Đã sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void xóaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thoat();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Hanghoa ORDER BY Tenhang DESC";
            dataGridView1.DataSource = DataAccess.GetTable(sql);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(btnLuu.Text == LUUBANGHI)
            {
                    string sql = "insert into Hanghoa values(N'" +
                             txtmahang.Text + "', N'" +
                             cbmaloai.Text + "', N'" +
                             txtTenhang.Text + "', N'" +
                             txtDonvitinh.Text + "', N'" +
                             txtDongia.Text + "')";
                    DataAccess.AddEditDelete(sql);
                    dataGridView1.DataSource = DataAccess.GetTable("select * from Hanghoa");
            }
            if (btnLuu.Text == LUUSUA)
            {
                string sql = "update Hanghoa set Maloai =N'" +
                        cbmaloai.Text + "', Tenhang =N'" +
                        txtTenhang.Text + "', DVT =N'" +
                        txtDonvitinh.Text + "', DonGia =N'" +
                        txtDongia.Text + "' where Mahang=N'" +
                        txtmahang.Text + "'";
                DataAccess.AddEditDelete(sql);
                dataGridView1.DataSource = DataAccess.GetTable("select * from Hanghoa");
                MessageBox.Show("Đã sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string Mahang = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string Maloai = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string Tenhang = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string DVT = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string DonGia = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                //this.Hide();
                TTHanghoa a = new TTHanghoa(Mahang, Maloai, Tenhang, DVT, DonGia);
                a.ShowDialog();
            }
        }
    }
}
