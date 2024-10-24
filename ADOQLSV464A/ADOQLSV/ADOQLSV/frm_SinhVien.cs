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
    public partial class frm_SinhVien : Form
    {
        public frm_SinhVien()
        {
            InitializeComponent();
        }
        LopDungChung lopchung = new LopDungChung();
        private void btn_demsv_Click(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT(*) FROM SINHVIEN";
            int kq = (int)lopchung.LayGT(sql);
            txt_demsv.Text = kq.ToString();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into SINHVIEN values ('" + txt_mssv.Text + "','" + txt_hoten.Text + "','" + txt_diachi.Text + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Thêm sinh viên thành công");
            }
            else MessageBox.Show("Thêm sinh viên thất bại");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sql = "Update SINHVIEN set HOTEN = '" 
                        + txt_hoten.Text + "', DIACHI = '"
                        + txt_diachi.Text + 
                        "' WHERE MSSV = '" + txt_mssv.Text+"'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Cập nhật sinh viên thành công");
            }
            else MessageBox.Show("Cập nhật sinh viên thất bại");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM SINHVIEN WHERE MSSV=" + txt_mssv.Text;
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Xóa sinh viên thành công");
            }
            else MessageBox.Show("Xóa sinh viên thất bại");
        }

        private void frm_SinhVien_Load(object sender, EventArgs e)
        {
            string sql = "Select * from SINHVIEN";
            dt_GridViewSV.DataSource = lopchung.LoadDL(sql);
        }
    }
}
