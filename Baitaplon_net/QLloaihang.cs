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
    public partial class QLloaihang : Form
    {
        #region Hằng xâu 
        string THEM = "Thêm";
        string HUY = "Hủy";
        string LUUSUA = "Lưu sửa";
        string LUUBANGHI = "Lưu thêm";
        string SUA = "Sửa";
        string XOA = "Xóa";
        string THOAT = "Thoát";
        string TIMKIEM = "Tìm kiếm";
        #endregion
        private int cr;
        public QLloaihang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        //private void TimKiem()
        //{
        //    if (btnTimKiem.Text == TIMKIEM)
        //    {
        //        txtmaloai.Clear();
        //        txttenloai.Clear();
        //        txtmaloai.Enabled = false;
        //        txttenloai.Focus();
        //        txttenloai.Enabled = true;

        //        btnSua.Enabled = false;
        //        btnThem.Enabled = false;
        //        btnXoa.Enabled = false;
        //        btnTimKiem.Text = "Tìm";

        //    }
        //    else
        //    {
        //        string sql;
        //        if (txttenloai.Text.Trim() == "")
        //            sql = "select * from Loaihang";
        //        else
        //            sql = "select * from Loaihang where Tenloai like N'%" +
        //            txttenloai.Text + "'";

        //        dataGridView1.DataSource = DataAccess.GetTable(sql);

        //        btnSua.Enabled = true;
        //        btnThem.Enabled = true;
        //        btnXoa.Enabled = true;
        //        btnTimKiem.Text = TIMKIEM;
        //        KhoiPhuc(cr);
        //    }
        //}
        private void button2_Click(object sender, EventArgs e)
        {
            them();
        }
        public void them()
        {
            if (btnThem.Text == THEM)
            {
                txtmaloai.Enabled = true;
                txttenloai.Enabled = true;
                txttenloai.Clear();
                txtmaloai.Clear();
                btnThem.Text = LUUBANGHI;
                txtmaloai.Focus();
            }
            else
            {
                if (txtmaloai.Text != " " && txttenloai.Text != " ")
                {
                    string sql = "insert into Loaihang values(N'" +
                                  txtmaloai.Text + "', N'" +
                                  txttenloai.Text + "' )";
                    DataAccess.AddEditDelete(sql);
                    dataGridView1.DataSource = DataAccess.GetTable("select * from Loaihang");

                    txtmaloai.Enabled = false;
                    txttenloai.Enabled = false;


                    btnThem.Text = THEM;
                    btnXoa.Enabled = true;
                    //btnTimKiem.Enabled = true;
                    btnThoat.Enabled = true;
                    KhoiPhuc(cr);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            sua();
        }
        public void sua()
        {
            if (btnSua.Text == SUA)
            {
                txtmaloai.Enabled = true;
                txttenloai.Enabled = true;
                btnSua.Text = LUUSUA;
            }
            else
            {
                string sql = "update Loaihang set Tenloai =N'" +
                    txttenloai.Text + "' where Maloai=N'" +
                    txtmaloai.Text + "'";
                DataAccess.AddEditDelete(sql);
                dataGridView1.DataSource = DataAccess.GetTable("select * from Loaihang");

                txtmaloai.Enabled = false;
                txttenloai.Enabled = false;


                btnSua.Text = SUA;
                btnXoa.Enabled = true;
                //btnTimKiem.Enabled = true;
                btnThoat.Enabled = true;
                KhoiPhuc(cr);
                MessageBox.Show("Đã sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
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
                string sql = "delete from Loaihang where Maloai=N'" + txtmaloai.Text + "'";
                DataAccess.AddEditDelete(sql);
                dataGridView1.DataSource = DataAccess.GetTable("select * from Loaihang");
                MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void QLloaihang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource =DataAccess.GetTable("select * from Loaihang");
            dataGridView1.Columns[0].HeaderText = "Mã loại hàng";
            dataGridView1.Columns[1].HeaderText = "Tên loại hàng";

            txtmaloai.Enabled = false;
            txttenloai.Enabled = false;

            dataGridView1.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void KhoiPhuc(int i)
        {
            txtmaloai.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txttenloai.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                txtmaloai.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txttenloai.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
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

        private void txttenloai_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode == Keys.Enter)
            //{
            //    TimKiem();
            //}
        }

        private void thêmThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            them();
        }

        private void sửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sua();
        }

        private void xóaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thoat();
        }
    }
}
