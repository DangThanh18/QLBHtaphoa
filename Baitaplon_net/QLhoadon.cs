using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;

namespace Baitaplon_net
{
    public partial class QLhoadon : Form
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
        string Quyen;
        public QLhoadon(string Quyen)
        {
            InitializeComponent();
            this.Quyen = Quyen;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        void displayData()
        {
            string sql = " SELECT  Hoadon.SoHD,  KhachHang.TenKKH,  Hanghoa.Tenhang,  CT_Hoadon.SoLuong,  CT_Hoadon.Dongia,  Hoadon.MaNV , Hoadon.Ngayban" +
                " FROM HoaDon  " +
                " INNER JOIN CT_Hoadon ON CT_Hoadon.SoHD = Hoadon.SoHD  " +
                " INNER JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH   " +
                " INNER JOIN HangHoa ON CT_Hoadon.MaHang = Hanghoa.Mahang";
            dbHD.DataSource =
                DataAccess.GetTable(sql);
        }
        void show()
        {
            dbHD.DataSource =
                DataAccess.getStoredProceduced("getHoaDonData");

            dbHD.Columns[0].HeaderText = "Số HD";
            dbHD.Columns[1].HeaderText = "Tên Khách Hàng";
            dbHD.Columns[2].HeaderText = "Tên Hàng";
            dbHD.Columns[3].HeaderText = "Số lượng";
            dbHD.Columns[4].HeaderText = "Đơn giá";
            dbHD.Columns[5].HeaderText = "Mã NV";

            dbHD.Columns[0].AutoSizeMode =
               DataGridViewAutoSizeColumnMode.AllCells;
            dbHD.Columns[1].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dbHD.Columns[2].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dbHD.Columns[3].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dbHD.Columns[4].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
            dbHD.Columns[5].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;
        }
        private void QLhoadon_Load(object sender, EventArgs e)
        {
            displayData();
            //btnThem.Text = THEM;
            //btnSua.Text = SUA;
            btnXoa.Text = XOA;
            btnExit.Text = THOAT;
            //btnTim.Text = TIMKIEM;

            txtmaHD.Enabled = false;
            cbmaKH.Enabled = false;
            cbMaMatHang.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGia.Enabled = false;
            cbMaNV.Enabled = false;
            if (Quyen == "Quản lý")
            {
                btnXoa.Enabled = true;
            }
            else
                btnXoa.Enabled = false;
            //Combobox_Item();
        }
        public void xoa()
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc chắn muốn XÓA", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                string sql = "delete from CT_Hoadon where SoHD=N'" + txtmaHD.Text + "'";
                DataAccess.AddEditDelete(sql);
                string newSQL = "delete from HoaDon where SoHD=N'" + txtmaHD.Text + "'";
                DataAccess.AddEditDelete(newSQL);
                displayData();
                MessageBox.Show("Đã xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void KhoiPhuc(int i)
        {
            string makh = DataAccess.CountData("select MaKH from KhachHang where TenKKH like N'%" + dbHD.Rows[i].Cells[1].Value.ToString() + "%'");
            txtmaHD.Text = dbHD.Rows[i].Cells[0].Value.ToString();
            cbmaKH.DisplayMember = makh;
            cbMaMatHang.Text = dbHD.Rows[i].Cells[2].Value.ToString();
            txtSoLuong.Text = dbHD.Rows[i].Cells[3].Value.ToString();
            txtGia.Text = dbHD.Rows[i].Cells[4].Value.ToString();
            cbMaNV.Text = dbHD.Rows[i].Cells[5].Value.ToString();
            dtNgayXuat.Value = (DateTime)dbHD.Rows[i].Cells[6].Value;
        }

        void tableSelected()
        {
            int i = -1;
            i = dbHD.CurrentRow.Index;
            if (i > 0)
            {
                txtmaHD.Text = dbHD.Rows[i].Cells[0].Value.ToString();

            }
        }
        void Combobox_Item()
        {
            string sql = "select maNV from NhanVien";
            cbMaNV.Items.AddRange(DataAccess.cbBoxAddData(sql).ToArray());
            string sqls = "select maKH from KhachHang";
            cbmaKH.Items.AddRange(DataAccess.cbBoxAddData(sqls).ToArray());
            string sqlss = "select MaHang from HangHoa";
            cbMaMatHang.Items.AddRange(DataAccess.cbBoxAddData(sqlss).ToArray());

            cbMaNV.SelectedIndex = 0;
            cbmaKH.SelectedIndex = 0;
            cbMaMatHang.SelectedIndex = 0;
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

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ExportToExcel(dbHD);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            
        }
        //private void TimKiem()
        //{
        //    if (radioButton1.Checked == true)
        //    {
        //        string sql;
        //        if (txttk.Text.Trim() == "")
        //            sql = "SELECT Hoadon.SoHD,  KhachHang.TenKKH,  Hanghoa.Tenhang,  CT_Hoadon.SoLuong,  CT_Hoadon.Dongia,  Hoadon.MaNV , Hoadon.Ngayban" +
        //        " FROM HoaDon  " +
        //        " INNER JOIN CT_Hoadon ON CT_Hoadon.SoHD = Hoadon.SoHD  " +
        //        " INNER JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH   " +
        //        " INNER JOIN HangHoa ON CT_Hoadon.MaHang = Hanghoa.Mahang";
        //        else
        //            sql = "SELECT Hoadon.SoHD,  KhachHang.TenKKH,  Hanghoa.Tenhang,  CT_Hoadon.SoLuong,  CT_Hoadon.Dongia,  Hoadon.MaNV , Hoadon.Ngayban" +
        //        " FROM HoaDon  " +
        //        " INNER JOIN CT_Hoadon ON CT_Hoadon.SoHD = Hoadon.SoHD  " +
        //        " INNER JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH   " +
        //        " INNER JOIN HangHoa ON CT_Hoadon.MaHang = Hanghoa.Mahang where DonGia like N'%" +
        //            txttk.Text + "%'";

        //        dbHD.DataSource = DataAccess.GetTable(sql);
        //    }
        //    if (radioButton2.Checked == true)
        //    {
        //        string sql;
        //        if (txttk.Text.Trim() == "")
        //            sql = "SELECT Hoadon.SoHD,  KhachHang.TenKKH,  Hanghoa.Tenhang,  CT_Hoadon.SoLuong,  CT_Hoadon.Dongia,  Hoadon.MaNV , Hoadon.Ngayban" +
        //        " FROM HoaDon  " +
        //        " INNER JOIN CT_Hoadon ON CT_Hoadon.SoHD = Hoadon.SoHD  " +
        //        " INNER JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH   " +
        //        " INNER JOIN HangHoa ON CT_Hoadon.MaHang = Hanghoa.Mahang";
        //        else
        //            sql = "SELECT Hoadon.SoHD,  KhachHang.TenKKH,  Hanghoa.Tenhang,  CT_Hoadon.SoLuong,  CT_Hoadon.Dongia,  Hoadon.MaNV , Hoadon.Ngayban" +
        //        " FROM HoaDon  " +
        //        " INNER JOIN CT_Hoadon ON CT_Hoadon.SoHD = Hoadon.SoHD  " +
        //        " INNER JOIN KhachHang ON HoaDon.MaKH = KhachHang.MaKH   " +
        //        " INNER JOIN HangHoa ON CT_Hoadon.MaHang = Hanghoa.Mahang where SoHD like N'%" +
        //            txttk.Text + "%'";

        //        dbHD.DataSource = DataAccess.GetTable(sql);
        //    }
        //}
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dbHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            xoa();
        }

        private void dbHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dbHD.CurrentRow != null)
            {
                txtmaHD.Text = dbHD.CurrentRow.Cells[0].Value.ToString();
                txtSoLuong.Text = dbHD.CurrentRow.Cells[3].Value.ToString();
                txtGia.Text = dbHD.CurrentRow.Cells[4].Value.ToString();
                dtNgayXuat.Value = (DateTime)dbHD.CurrentRow.Cells[6].Value;
                cbmaKH.Text = dbHD.CurrentRow.Cells[1].Value.ToString();
                cbMaMatHang.Text = dbHD.CurrentRow.Cells[2].Value.ToString();
                cbMaNV.Text = dbHD.CurrentRow.Cells[5].Value.ToString();
            }
        }
    }
}
