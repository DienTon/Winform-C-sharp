using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADOQLSV
{
    public partial class frm_GiaoVien : Form
    {
        public frm_GiaoVien()
        {
            InitializeComponent();
        }
        LopDungChung lopchung = new LopDungChung();
        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into GIAOVIEN values ('" + txt_magv.Text + "','" + txt_hoten.Text + "',Convert(datetime,'" + dtp_ngaysinh.Text + "',103),'" + txt_chucvu.Text + "','" + cb_TenKhoa.SelectedValue + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Thêm giao viên thành công");
            }
            else MessageBox.Show("Thêm giao viên thất bại");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update SINHVIEN set HOTEN = '"
                        + txt_hoten.Text + "', CHUCVU = '"
                        + txt_chucvu.Text + "', TENKHOA = '"
                        + cb_TenKhoa.SelectedValue + "', NGAYSINH = 'Convert(datetime,'" + dtp_ngaysinh.Text + "',103) WHERE MAGV = '" + txt_magv.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Thêm giao viên thành công");
            }
            else MessageBox.Show("Thêm giao viên thất bại");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM GIAOVIEN WHERE MASV=" + txt_magv.Text;
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Xóa giao viên thành công");
            }
            else MessageBox.Show("Xóa giao viên thất bại");
        }
        private void frm_GiaoVien_Load(object sender, EventArgs e)
        {
            string sql = "Select * from GIAOVIEN";
            dt_gridViewGV.DataSource = lopchung.LoadDL(sql);
            //Đưa vào Combox
            string sqlkhoa = "Select * from KHOA";
            cb_TenKhoa.DataSource = lopchung.LoadDL(sqlkhoa);
            cb_TenKhoa.ValueMember = "MAKHOA";
            cb_TenKhoa.DisplayMember = "TENKHOA";

        }

        private void dt_gridViewGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
