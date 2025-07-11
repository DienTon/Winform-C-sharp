using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_cong_ty
{
    public partial class QLKH : Form
    {
        public QLKH()
        {
            InitializeComponent();
            LoadCustomers();
            rdoTangDan.Checked = true;


        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKH.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ tên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return;
            }
            if (!int.TryParse(txtTuoi.Text, out int tuoi) || tuoi < 0)
            {
                MessageBox.Show("Tuổi phải là số nguyên không âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTuoi.Focus();
                return;
            }

            try
            {
                SqlServerConnection db = new SqlServerConnection();
                string query = $"INSERT INTO KHACHHANG (MAKH, HOTEN, TUOI, HINHANH) VALUES (N'{txtMaKH.Text}', N'{txtHoTen.Text}', {tuoi}, N'{txtAnh.Text}')";
                int result = db.ExecuteNonQuery(query);
                if (result > 0)
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadCustomers();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại! Có thể Mã khách hàng đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thêm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu đầu vào
            if (string.IsNullOrWhiteSpace(txtMaKH.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaKH.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ tên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoTen.Focus();
                return;
            }
            if (!int.TryParse(txtTuoi.Text, out int tuoi) || tuoi < 0)
            {
                MessageBox.Show("Tuổi phải là số nguyên không âm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTuoi.Focus();
                return;
            }

            try
            {
                SqlServerConnection db = new SqlServerConnection();
                string query = $"UPDATE KHACHHANG SET HOTEN = N'{txtHoTen.Text}', TUOI = {tuoi}, HINHANH = N'{txtAnh.Text}' WHERE MAKH = N'{txtMaKH.Text}'";
                int result = db.ExecuteNonQuery(query);
                if (result > 0)
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadCustomers();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlServerConnection db = new SqlServerConnection();
            string query = $"DELETE FROM KHACHHANG WHERE MAKH = N'{txtMaKH.Text}'";
            int result = db.ExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("Xóa thành công!");
                LoadCustomers();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn đóng không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            SqlServerConnection db = new SqlServerConnection();
            string keyword = txtTimKiem.Text.Trim();
            string query = $"SELECT * FROM KHACHHANG WHERE MAKH LIKE N'%{keyword}%' OR HOTEN LIKE N'%{keyword}%'";
            dgvKhachHang.DataSource = db.ExecuteQuery(query);
        }

        private void LoadCustomers()
        {
            SqlServerConnection db = new SqlServerConnection();
            string query = "SELECT * FROM KHACHHANG";
            dgvKhachHang.DataSource = db.ExecuteQuery(query);
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvKhachHang.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MAKH"].Value?.ToString();
                txtHoTen.Text = row.Cells["HOTEN"].Value?.ToString();
                txtTuoi.Text = row.Cells["TUOI"].Value?.ToString();
                txtAnh.Text = row.Cells["HINHANH"].Value?.ToString();
            }
        }

        private void rdoTangDan_CheckedChanged(object sender, EventArgs e)
        {
                dgvKhachHang.Sort(dgvKhachHang.Columns["MAKH"], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void rdoGiamDan_CheckedChanged(object sender, EventArgs e)
        {
                dgvKhachHang.Sort(dgvKhachHang.Columns["MAKH"], System.ComponentModel.ListSortDirection.Descending);
        }
    }
}
