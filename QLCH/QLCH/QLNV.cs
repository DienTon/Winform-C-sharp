using QLCH;
using System;
using System.Windows.Forms;

namespace QLCH
{
    public partial class QLNV : Form
    {
        SqlServerConnection sqlServerConnection = new SqlServerConnection();
        public QLNV()
        {
            InitializeComponent();
            loadPhongBan();
            loadNhanVien();
        }
        private void loadPhongBan()
        {
            string query = $@"SELECT * FROM PHONG_BAN";
            var list = sqlServerConnection.ExecuteQuery(query);
            cbbPhongBan.DataSource = list;
            cbbPhongBan.ValueMember = "ID_PHONG_BAN";
            cbbPhongBan.DisplayMember = "TEN_PHONG_BAN";
        }

        private void loadNhanVien()
        {
            string query = @"SELECT NV.ID, NV.MA_NV, NV.HO_TEN, NV.EMAIL, NV.PHONE, NV.GIOI_TINH, NV.NGAY_SINH, PB.TEN_PHONG_BAN, NV.IS_LAM_VIEC
                             FROM NHAN_VIEN NV
                             JOIN PHONG_BAN PB ON NV.ID_PHONG_BAN = PB.ID_PHONG_BAN";
            var dataTable = sqlServerConnection.ExecuteQuery(query);
            dtgNhanVien.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtEmail.Text = string.Empty;
            txtHoTen.Text = string.Empty;
            txtManv.Text = string.Empty;
            txtPhone.Text = string.Empty;
            ckbLamViec.Checked = false;
            rdNam.Checked = true;
            rdNu.Checked = false;
            dtNgaySinh.Value = DateTime.Now;
            cbbPhongBan.SelectedIndex = 0;
            loadNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtManv.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã Nhân viên.");
                return;
            }

            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Chưa nhập Họ tên Nhân viên.");
                return;
            }
            if (cbbPhongBan.SelectedValue == null || cbbPhongBan.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Chưa chọn Phòng ban");
                return;
            }
            string maNV = txtManv.Text;
            string hoTen = txtHoTen.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string GioiTinh = rdNam.Checked ? "Nam" : "Nữ";
            string ngaySinh = dtNgaySinh.Value.ToString("yyyy-MM-dd");
            int phongBan;
            // Sử dụng ValueMember thay vì SelectedIndex
            if (!int.TryParse(cbbPhongBan.SelectedValue.ToString(), out phongBan))
            {
                MessageBox.Show("Phòng ban không hợp lệ.");
                return;
            }
            int isLamViec = ckbLamViec.Checked ? 1 : 0;
            string query = $@"INSERT INTO NHAN_VIEN (MA_NV, HO_TEN, EMAIL, PHONE, GIOI_TINH, NGAY_SINH, ID_PHONG_BAN, IS_LAM_VIEC) 
                              VALUES (N'{maNV}', N'{hoTen}', '{email}', '{phone}', N'{GioiTinh}', '{ngaySinh}', {phongBan}, {isLamViec})";
            int result = sqlServerConnection.ExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("Thêm nhân viên thành công.");
                loadNhanVien();
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại.");
            }
        }

        // SỬA NHÂN VIÊN
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dtgNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa.");
                return;
            }
            if (txtManv.Text == "")
            {
                MessageBox.Show("Chưa nhập Mã Nhân viên.");
                return;
            }
            if (txtHoTen.Text == "")
            {
                MessageBox.Show("Chưa nhập Họ tên Nhân viên.");
                return;
            }
            if (cbbPhongBan.SelectedValue == null || cbbPhongBan.SelectedValue.ToString() == "")
            {
                MessageBox.Show("Chưa chọn Phòng ban");
                return;
            }

            var id = dtgNhanVien.CurrentRow.Cells["ID"].Value;
            string maNV = txtManv.Text;
            string hoTen = txtHoTen.Text;
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string GioiTinh = rdNam.Checked ? "Nam" : "Nữ";
            string ngaySinh = dtNgaySinh.Value.ToString("yyyy-MM-dd");
            int phongBan;
            if (!int.TryParse(cbbPhongBan.SelectedValue.ToString(), out phongBan))
            {
                MessageBox.Show("Phòng ban không hợp lệ.");
                return;
            }
            int isLamViec = ckbLamViec.Checked ? 1 : 0;

            string query = $@"UPDATE NHAN_VIEN SET 
                                MA_NV = N'{maNV}', 
                                HO_TEN = N'{hoTen}', 
                                EMAIL = '{email}', 
                                PHONE = '{phone}', 
                                GIOI_TINH = N'{GioiTinh}', 
                                NGAY_SINH = '{ngaySinh}', 
                                ID_PHONG_BAN = {phongBan}, 
                                IS_LAM_VIEC = {isLamViec}
                              WHERE ID = {id}";
            int result = sqlServerConnection.ExecuteNonQuery(query);
            if (result > 0)
            {
                MessageBox.Show("Sửa nhân viên thành công.");
                loadNhanVien();
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại.");
            }
        }

        // XÓA NHÂN VIÊN
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgNhanVien.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.");
                return;
            }
            var id = dtgNhanVien.CurrentRow.Cells["ID"].Value;
            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = $"DELETE FROM NHAN_VIEN WHERE ID = {id}";
                int result = sqlServerConnection.ExecuteNonQuery(query);
                if (result > 0)
                {
                    MessageBox.Show("Xóa nhân viên thành công.");
                    loadNhanVien();
                }
                else
                {
                    MessageBox.Show("Xóa nhân viên thất bại.");
                }
            }
        }

        // TÌM KIẾM NHÂN VIÊN
        private void btnTim_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtHoTen.Text.Trim();
            string query = $@"
                SELECT NV.ID, NV.MA_NV, NV.HO_TEN, NV.EMAIL, NV.PHONE, NV.GIOI_TINH, NV.NGAY_SINH, PB.TEN_PHONG_BAN, NV.IS_LAM_VIEC
                FROM NHAN_VIEN NV
                JOIN PHONG_BAN PB ON NV.ID_PHONG_BAN = PB.ID_PHONG_BAN
                WHERE NV.MA_NV LIKE N'%{tuKhoa}%' OR NV.HO_TEN LIKE N'%{tuKhoa}%'
            ";
            var dataTable = sqlServerConnection.ExecuteQuery(query);
            dtgNhanVien.DataSource = dataTable;
        }

        private void dtgNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dtgNhanVien.Rows[e.RowIndex];
                txtManv.Text = row.Cells["MA_NV"].Value?.ToString();
                txtHoTen.Text = row.Cells["HO_TEN"].Value?.ToString();
                txtEmail.Text = row.Cells["EMAIL"].Value?.ToString();
                txtPhone.Text = row.Cells["PHONE"].Value?.ToString();
                rdNam.Checked = row.Cells["GIOI_TINH"].Value?.ToString() == "Nam";
                rdNu.Checked = row.Cells["GIOI_TINH"].Value?.ToString() == "Nữ";
                dtNgaySinh.Value = row.Cells["NGAY_SINH"].Value != null ? Convert.ToDateTime(row.Cells["NGAY_SINH"].Value) : DateTime.Now;
                cbbPhongBan.Text = row.Cells["TEN_PHONG_BAN"].Value?.ToString();
                ckbLamViec.Checked = row.Cells["IS_LAM_VIEC"].Value != null && row.Cells["IS_LAM_VIEC"].Value.ToString() == "1";
            }
        }
    }
}

