using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TonThatDien_27211234266
{
    public partial class QUANLYCAFE : Form
    {
        SqlServerConnection sqlServerConnection = new SqlServerConnection();

        public QUANLYCAFE()
        {
            InitializeComponent();
            loadDanhMuc();
            loadSanPham();
        }
        private void loadDanhMuc()
        {
            string query = $@"SELECT * FROM DANHMUC";
            var list = sqlServerConnection.ExecuteQuery(query);
            cbbTenDanhMuc.DataSource = list;
            cbbTenDanhMuc.ValueMember = "MaDM";
            cbbTenDanhMuc.DisplayMember = "TenDM";
        }
        private void loadSanPham()
        {
            string query = @"SELECT SP.MaMon,SP.TenMon,DM.TenDM,SP.Gia,SP.NgayTao
                             FROM SANPHAM SP
                             JOIN DANHMUC DM ON SP.MaDM = DM.MaDM";
            var dataTable = sqlServerConnection.ExecuteQuery(query);
            dgvDanhSach.DataSource = dataTable;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maMon = tbMaMon.Text;
            string tenMon = tbTenMon.Text;
            decimal giaTien; 
            if (!decimal.TryParse(tbGiaTien.Text, out giaTien)) 
            {
                MessageBox.Show("Giá tiền không hợp lệ. Vui lòng nhập một số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ngayTao= dtpNgayTao.Value.ToString("yyyy-MM-dd"); ;
            string maDM= cbbTenDanhMuc.SelectedValue.ToString();
            string query = $@"INSERT INTO SANPHAM (MaMon, TenMon, MaDM, Gia, NgayTao) 
                              VALUES (N'{maMon}', N'{tenMon}', N'{maDM}', '{giaTien}', '{ngayTao}')";
            int result = sqlServerConnection.ExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("Thêm thành công.");
                loadSanPham();
            }
            else
            {
                MessageBox.Show("Thêm thất bại.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa.");
                return;
            }
            var id = dgvDanhSach.CurrentRow.Cells["MaMon"].Value;
            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = $"DELETE FROM SANPHAM WHERE MaMon = {id}";
                int result = sqlServerConnection.ExecuteNonQuery(query);
                if (result > 0)
                {
                    MessageBox.Show("Xóa sản phẩm thành công.");
                    loadSanPham();
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại.");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maMon = tbMaMon.Text;
            string tenMon = tbTenMon.Text;
            decimal giaTien;
            if (!decimal.TryParse(tbGiaTien.Text, out giaTien))
            {
                MessageBox.Show("Giá tiền không hợp lệ. Vui lòng nhập một số.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ngayTao = dtpNgayTao.Value.ToString("yyyy-MM-dd"); ;
            string maDM = cbbTenDanhMuc.SelectedValue.ToString();
            string query = $@"UPDATE SANPHAM SET 
                                TenMon = N'{tenMon}', 
                                Gia = '{giaTien}', 
                                MaDm = '{maDM}', 
                                NgayTao = N'{ngayTao}'
                                WHERE MaMon = {maDM}";
            int result = sqlServerConnection.ExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("Sửa san pham thành công.");
                loadSanPham();
            }
            else
            {
                MessageBox.Show("Sửa san pham thất bại.");
            }

        }

        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvDanhSach.Rows[e.RowIndex];
                tbMaMon.Text = row.Cells["MaMon"].Value?.ToString();
                tbTenMon.Text = row.Cells["TenMon"].Value?.ToString();
                tbGiaTien.Text = row.Cells["Gia"].Value?.ToString();
                dtpNgayTao.Value = row.Cells["NgayTao"].Value != null ? Convert.ToDateTime(row.Cells["NgayTao"].Value) : DateTime.Now;
                cbbTenDanhMuc.Text = row.Cells["TenDM"].Value?.ToString();
            }
        }
    }
    }
