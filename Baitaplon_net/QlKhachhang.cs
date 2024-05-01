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
    public partial class QlKhachhang : Form
    {
        #region Hằng xâu 
        string THEM = "Thêm";
        string HUY = "Hủy";
        string LUUSUA = "Lưu sửa";
        string LUU = "Lưu";
        string LUUBANGHI = "Lưu thêm";
        string SUA = "Sửa";
        string XOA = "Xóa";
        string THOAT = "Thoát";
        string TIMKIEM = "Tìm kiếm";
        #endregion
        private int cr;
        public string _text { get; set; }
        string Quyen, maNV;
        public QlKhachhang(string Quyen, string maNV, string _text)
        {
            InitializeComponent();
            this.Quyen = Quyen;
            this.maNV = maNV;
            this._text = _text;
        }
        bool CheckMa(string text)
        {
            string sql = "select count(*) from KhachHang where MaKH like N'%" + text + "%'";
            int count = -1;
            count = Convert.ToInt32(DataAccess.CountData(sql));
            if (count < 0)
                return true;
            return false;
        }
        void MessengerNotify()
        {
            DialogResult rs = MessageBox.Show("Thêm thông tin khách hàng thành công, Bạn có muốn quay lại chương trình hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                DanhSachMua f = new DanhSachMua(Quyen, maNV, txtMaKH.Text);
                f.Show();
                this.Hide();
            }
            else if (rs == DialogResult.No)
            {
                KhoiPhuc(cr);
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
                txtMaKH.Enabled = true;
                txtTenKH.Enabled = true;
                txtEmail.Enabled = true;
                txtDiaChi.Enabled = true;
                txtDT.Enabled = true;
                txtMaKH.Clear();
                txtTenKH.Clear();
                txtEmail.Clear();
                txtDiaChi.Clear();
                txtDT.Clear();

                btnThem.Text = HUY;
                btnSua.Enabled = false;
                btnTimKiem.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Text = LUUBANGHI;
                btnLuu.Enabled = true;
            }
            else
            { 
                    txtMaKH.Enabled = false;
                    txtTenKH.Enabled = false;
                    txtEmail.Enabled = false;
                    txtDiaChi.Enabled = false;
                    txtDT.Enabled = false;

                    btnThem.Text = THEM;
                    btnLuu.Text = LUU;
                    btnXoa.Enabled = true;
                    btnTimKiem.Enabled = true;
                    btnSua.Enabled = true;
                    KhoiPhuc(cr);
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
                txtMaKH.Enabled = true;
                txtTenKH.Enabled = true;
                txtEmail.Enabled = true;
                txtDiaChi.Enabled = true;
                txtDT.Enabled = true;
                btnLuu.Text = LUUSUA;
                btnLuu.Enabled = true;
                btnThem.Enabled = false;
                btnTimKiem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Text = HUY;
                txtMaKH.Focus();
            }
            else
            {
                txtMaKH.Enabled = false;
                txtTenKH.Enabled = false;
                txtEmail.Enabled = false;
                txtDiaChi.Enabled = false;
                txtDT.Enabled = false;

                btnSua.Text = SUA;
                btnLuu.Text = LUU;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnTimKiem.Enabled = true;
                btnThoat.Enabled = true;
                KhoiPhuc(cr);
            }
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
                string sql = "delete from KhachHang where MaKH=N'" + txtMaKH.Text + "'";
                DataAccess.AddEditDelete(sql);
                dataGridView1.DataSource = DataAccess.GetTable("select * from KhachHang");
                MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void button1_Click(object sender, EventArgs e)
        {
            Timkiemtheokhachhang a = new Timkiemtheokhachhang();
                a.Show();
        }

        private void QlKhachhang_Load(object sender, EventArgs e)
        {
            btnThem.Text = THEM;
            btnSua.Text = SUA;
            btnXoa.Text = XOA;
            btnThoat.Text = THOAT;
            btnTimKiem.Text = TIMKIEM;

            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            txtEmail.Enabled = false;
            txtDiaChi.Enabled = false;
            txtDT.Enabled = false;

            btnLuu.Enabled = false;

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

            demsoluong();
        }
        private void demsoluong()
        {
            int soluong;
            soluong = dataGridView1.RowCount;
            txtsoluong.Text = "" + (soluong - 1);
        }
        private void KhoiPhuc(int i)
            {
                txtMaKH.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
                txtTenKH.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
                txtDiaChi.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                txtDT.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            }
        
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.CurrentRow != null)
            {
                txtMaKH.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtTenKH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtDiaChi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtEmail.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtDT.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void txtTenKH_KeyDown(object sender, KeyEventArgs e)
        {
            //if(e.KeyCode == Keys.Enter)
            //{
            //    TimKiem();
            //    demsoluong();
            //}
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            them();
            demsoluong();
        }

        private void sửaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sua();
            demsoluong();
        }

        private void xóaThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            xoa();
            demsoluong();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thoat();
            demsoluong();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM KhachHang ORDER BY TenKKH DESC";
            dataGridView1.DataSource = DataAccess.GetTable(sql);
            demsoluong();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string MaKH = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string TenKH = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                string DiaChi = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                string Email = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                string DienThoai = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

                //this.Hide();
                TTKhachHang a = new TTKhachHang(MaKH, TenKH, DiaChi, Email, DienThoai);
                a.ShowDialog();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnLuu.Text == LUUSUA)
            {
                string sql = "update KhachHang set TenKKH =N'" +
                    txtTenKH.Text + "', DiaChi =N'" +
                    txtDiaChi.Text + "', Email =N'" +
                    txtEmail.Text + "', SDT =N'" +
                    txtDT.Text + "'  where MaKH=N'" +
                    txtMaKH.Text + "'";
                DataAccess.AddEditDelete(sql);
                dataGridView1.DataSource = DataAccess.GetTable("select * from KhachHang");
            }
            if (btnLuu.Text == LUUBANGHI)
            {
                if (txtMaKH.Text != " " && txtTenKH.Text != " " && txtDiaChi.Text != " " && txtEmail.Text != " " && txtDT.Text != " ")
                {
                    string sql = "insert into KhachHang values(N'" +
                                  txtMaKH.Text + "', N'" +
                                  txtTenKH.Text + "', N'" +
                                  txtDiaChi.Text + "', N'" +
                                  txtEmail.Text + "', N'" +
                                  txtDT.Text + "' )";
                    DataAccess.AddEditDelete(sql);
                    dataGridView1.DataSource = DataAccess.GetTable("select * from KhachHang");
                }
                else
                {
                    MessageBox.Show("Yêu cầu nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            demsoluong();
        }
    }
}
