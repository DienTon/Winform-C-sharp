using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH
{
    public partial class frmVatTu : Form
    {
        SqlServerConnection sqlServerConnection = new SqlServerConnection();

        public frmVatTu()
        {
            InitializeComponent();
            loadVatTu();
            loadNhaSanXuat();
        }

        private void loadVatTu()
        {
            string query = @"SELECT VT.MaHang, VT.TenHang, VT.NgaySanXuat, VT.NamHetHan, NSX.TenNSX
                             FROM VATTU VT
                             JOIN NHASANXUAT NSX ON VT.MaNSX = NSX.MaNSX";
            DataTable dataTable = sqlServerConnection.ExecuteQuery(query);
            dataGridView1.DataSource = dataTable;
        }

        private void loadNhaSanXuat()
        {
            string query = "SELECT MaNSX, TenNSX FROM NHASANXUAT";
            DataTable dataTable = sqlServerConnection.ExecuteQuery(query);
            cbbNhaSanXuat.DataSource = dataTable;
            cbbNhaSanXuat.DisplayMember = "TenNSX";
            cbbNhaSanXuat.ValueMember = "MaNSX";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaHang.Text) ||
                string.IsNullOrWhiteSpace(txtTenHang.Text) ||
                string.IsNullOrWhiteSpace(txtNamHetHan.Text) ||
                cbbNhaSanXuat.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string maHang = txtMaHang.Text.Trim();
            string tenHang = txtTenHang.Text.Trim();
            string ngaySanXuat = dtpNgaySanXuat.Value.ToString("yyyy-MM-dd");
            int namHetHan;
            if (!int.TryParse(txtNamHetHan.Text.Trim(), out namHetHan))
            {
                MessageBox.Show("Năm hết hạn phải là số.");
                return;
            }
            int maNSX = Convert.ToInt32(cbbNhaSanXuat.SelectedValue);

            string query = $@"INSERT INTO VATTU (MaHang, TenHang, NgaySanXuat, NamHetHan, MaNSX)
                              VALUES ({maHang}, N'{tenHang}', '{ngaySanXuat}', {namHetHan}, {maNSX})";
            int result = sqlServerConnection.ExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("Thêm vật tư thành công.");
                loadVatTu();
            }
            else
            {
                MessageBox.Show("Thêm vật tư thất bại.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vật tư cần sửa.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMaHang.Text) ||
                string.IsNullOrWhiteSpace(txtTenHang.Text) ||
                string.IsNullOrWhiteSpace(txtNamHetHan.Text) ||
                cbbNhaSanXuat.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string maHang = txtMaHang.Text.Trim();
            string tenHang = txtTenHang.Text.Trim();
            string ngaySanXuat = dtpNgaySanXuat.Value.ToString("yyyy-MM-dd");
            int namHetHan;
            if (!int.TryParse(txtNamHetHan.Text.Trim(), out namHetHan))
            {
                MessageBox.Show("Năm hết hạn phải là số.");
                return;
            }
            int maNSX = Convert.ToInt32(cbbNhaSanXuat.SelectedValue);

            string query = $@"UPDATE VATTU SET 
                                TenHang = N'{tenHang}', 
                                NgaySanXuat = '{ngaySanXuat}', 
                                NamHetHan = {namHetHan}, 
                                MaNSX = {maNSX}
                              WHERE MaHang = {maHang}";
            int result = sqlServerConnection.ExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("Sửa vật tư thành công.");
                loadVatTu();
            }
            else
            {
                MessageBox.Show("Sửa vật tư thất bại.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn vật tư cần xóa.");
                return;
            }
            string maHang = dataGridView1.CurrentRow.Cells["MaHang"].Value.ToString();
            if (MessageBox.Show("Bạn có chắc muốn xóa vật tư này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = $"DELETE FROM VATTU WHERE MaHang = {maHang}";
                int result = sqlServerConnection.ExecuteNonQuery(query);
                if (result > 0)
                {
                    MessageBox.Show("Xóa vật tư thành công.");
                    loadVatTu();
                }
                else
                {
                    MessageBox.Show("Xóa vật tư thất bại.");
                }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTim.Text.Trim();
            string query = $@"
                SELECT VT.MaHang, VT.TenHang, VT.NgaySanXuat, VT.NamHetHan, NSX.TenNSX
                FROM VATTU VT
                JOIN NHASANXUAT NSX ON VT.MaNSX = NSX.MaNSX
                WHERE VT.TenHang LIKE N'%{tuKhoa}%'";
            DataTable dataTable = sqlServerConnection.ExecuteQuery(query);
            dataGridView1.DataSource = dataTable;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadVatTu();
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaHang.Text = row.Cells["MaHang"].Value?.ToString();
                txtTenHang.Text = row.Cells["TenHang"].Value?.ToString();

                if (row.Cells["NgaySanXuat"].Value != null)
                {
                    DateTime ngaySanXuat;
                    if (DateTime.TryParse(row.Cells["NgaySanXuat"].Value.ToString(), out ngaySanXuat))
                    {
                        dtpNgaySanXuat.Value = ngaySanXuat;
                    }
                }

                txtNamHetHan.Text = row.Cells["NamHetHan"].Value?.ToString();

                if (row.Cells["TenNSX"].Value != null)
                {
                    cbbNhaSanXuat.Text = row.Cells["TenNSX"].Value.ToString();
                }
            }
        }

        private void dtpNgaySanXuat_ValueChanged(object sender, EventArgs e)
        {
            int namSanXuat = dtpNgaySanXuat.Value.Year;
            txtNamHetHan.Text = (namSanXuat + 10).ToString();
            txtNamHetHan.Visible = true; // Show textbox when date is picked
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int soLuong = dataGridView1.Rows.Count;
            // Nếu DataGridView cho phép thêm dòng mới (AllowUserToAddRows = true), trừ đi 1 dòng trống cuối
            if (dataGridView1.AllowUserToAddRows)
                soLuong = soLuong - 1;
            txtDem.Text = soLuong.ToString();
        }
    }
}
