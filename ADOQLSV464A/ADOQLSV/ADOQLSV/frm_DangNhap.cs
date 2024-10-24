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
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }
        LopDungChung lopchung = new LopDungChung();
        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            
            string sql = "SELECT Count(*) FROM TAIKHOAN where (TENTAIKHOAN= '"+txt_TaiKhoan.Text+"') and (MATKHAU = '"+txt_MatKhau.Text+"')";
            int kq = (int)lopchung.LayGT(sql);
            if (kq >= 1)
            {
                frm_Main main = new frm_Main();
                main.Show();
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn thật sự có muốn thoát hay không?", "Cảnh Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes) Application.Exit();
        }

        private void btn_NhapLai_Click(object sender, EventArgs e)
        {
            txt_TaiKhoan.Clear();
            txt_MatKhau.Clear();
        }
    }
}
