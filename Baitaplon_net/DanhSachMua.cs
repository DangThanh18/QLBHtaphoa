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
using System.IO;
using OfficeOpenXml;

namespace Baitaplon_net
{
    public partial class DanhSachMua : Form
    {
        string Quyen, maNV, tenKH;
        public DanhSachMua(string Quyen, string maNV, string tenKH)
        {
            this.Quyen = Quyen;
            this.maNV = maNV;
            this.tenKH = tenKH;
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void DanhSachMua_Load(object sender, EventArgs e)
        {
            displayData();
            hienthicb();
            txtSoLuong.Enabled = false;
            txtMaHD.Text = "";
            if (Quyen == "Nhân viên")
            {
                button1.Enabled = false;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            tableSelected();
        }

        void displayData()
        {
            dataGridView2.DataSource = DataAccess.getStoredProceduced("getHangHoaData");
            dataGridView2.Columns[0].HeaderText = "Mã hàng";
            dataGridView2.Columns[1].HeaderText = "Tên loại hàng";
            dataGridView2.Columns[2].HeaderText = "Tên hàng hóa";
            dataGridView2.Columns[3].HeaderText = "Đơn vị tính";
            dataGridView2.Columns[4].HeaderText = "Giá tiền";

            dataGridView2.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[3].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView2.Columns[4].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            txtMaHD.Text = tenKH;

            datamuahang.DataSource = DataAccess.GetTable("select * from MuaHang");
        }
        string maHD;
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (cbDaily.Checked = true)
            {
                txtMaHD.Text = "HDDL" + (countNum() + 1);
            }
            if (cbkhtt.Checked = true)
            {
                txtMaHD.Text = "KHTT" + (countNum() + 1);
            }
            int a = Convert.ToInt32(txtSoLuong.Text);
            int b = Convert.ToInt32(txtGiatien.Text);
            txtThanhTien.Text = "" + (a * b); 
            string sql = "insert into MuaHang values(N'muahang', N'" +
                                  txtTenhh.Text.Trim() + "', N'" +
                                   txtGiatien.Text.Trim() + "', N'" +
                                   txtSoLuong.Text.Trim() + "', N'" +
                                   txtThanhTien.Text.Trim() + "')";
            DataAccess.AddEditDelete(sql);
            datamuahang.DataSource = DataAccess.GetTable("select * from MuaHang");

            string laymakh = "Select MaKH from KhachHang where TenKKH = N'" + cbTenKH.Text + "'";
            string layma = DataAccess.LayMotGT(laymakh);
            DateTime now = DateTime.Now;
            string ngayban = now.ToString("yyyy-MM-dd");
            string sql1 = "insert into Hoadon values(N'"+
                                  txtMaHD.Text.Trim() + "', '" +
                                  ngayban + "', N'" +
                                  layma.Trim() + "', N'" +
                                  maNV.Trim() + "', N'" +
                                  txtThanhTien.Text.Trim() + "')";
            DataAccess.AddEditDelete(sql1);

            string laymaloai = "Select Maloai from Loaihang where Tenloai = N'" + txtloaihang.Text + "'";
            string laymal = DataAccess.LayMotGT(laymaloai);
            string sql2 = "insert into CT_Hoadon values(N'" +
                                 txtMaHD.Text.Trim() + "', '" +
                                 txtMahang.Text.Trim() + "', N'" +
                                 laymal.Trim() + "', N'" +
                                 txtSoLuong.Text.Trim() + "', N'" +
                                 txtGiatien.Text.Trim() + "')";
            DataAccess.AddEditDelete(sql2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QLhoadon f = new QLhoadon(Quyen);
            f.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            decimal tong = 0;

            foreach (DataGridViewRow row in datamuahang.Rows)
            {
                if (row.Cells[4].Value != null && row.Cells[4].Value != DBNull.Value)
                {
                    tong += Convert.ToDecimal(row.Cells[4].Value);
                }
            }
            txtTongHoaDon.Text = "" + tong;

            int tienkh = Convert.ToInt32(txtTienKhach.Text);
            string tientralai = "" + (tong - tienkh);
            txtTraLai.Text = tientralai;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        int countNum()
        {
            string sql = "select count(*) from Hoadon";
            int count = 0;
            count = Convert.ToInt32(DataAccess.CountData(sql));
            return count;
        }
        private void txtSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void cbTenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSoLuong.Enabled = true;
        }

        private void cbDaiLy_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cbTT_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void cbDaily_CheckedChanged_1(object sender, EventArgs e)
        {
            txtMaHD.Text = "HDDL" + (countNum() + 1);
        }

        private void cbkhtt_CheckedChanged(object sender, EventArgs e)
        {
            txtMaHD.Text = "KHTT" + (countNum() + 1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExportToExcel(datamuahang);
        }
        private void ExportToExcel(DataGridView dataGridView)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx";
            saveFileDialog.Title = "Save Excel File";
            saveFileDialog.FileName = "exported_data.xlsx"; // Tên mặc định cho file Excel

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                    // Ghi dữ liệu từ DataGridView vào file Excel
                    for (int row = 0; row < dataGridView.Rows.Count; row++)
                    {
                        for (int col = 0; col < dataGridView.Columns.Count; col++)
                        {
                            worksheet.Cells[row + 1, col + 1].Value = dataGridView.Rows[row].Cells[col].Value;
                        }
                    }
                    
                    // Lưu file Excel
                    FileInfo excelFile = new FileInfo(filePath);
                    excelPackage.SaveAs(excelFile);
                }

                MessageBox.Show("Export completed successfully.", "Export to Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnnew_Click(object sender, EventArgs e)
        {
            string sql = "delete from MuaHang";
            DataAccess.AddEditDelete(sql);
        }

        void tableSelected()
        {
            int i = -1;
            i = dataGridView2.CurrentRow.Index;
            if (i >= 0)
            {
                txtMahang.Text = dataGridView2.Rows[i].Cells[0].Value.ToString();
                txtloaihang.Text = dataGridView2.Rows[i].Cells[1].Value.ToString();
                txtTenhh.Text = dataGridView2.Rows[i].Cells[2].Value.ToString();
                txtGiatien.Text = dataGridView2.Rows[i].Cells[4].Value.ToString();
            }
        }

        public void hienthicb()
        {
            string connectionString = @"Data Source=THANHNEK;Initial Catalog=dbbtl_net;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TenKKH FROM KhachHang";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    cbTenKH.DataSource = dataTable;
                    cbTenKH.DisplayMember = "TenKKH";
                }
            }
        } 
    }
}
