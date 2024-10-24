namespace QuanLyNhanVien
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            frm_Main frm_Main = new frm_Main();

            if (txt_TenDangNhap.Text == "" || txt_MatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }else if (txt_TenDangNhap.Text != "huynhvannam" || txt_MatKhau.Text != "123456")
            {
                MessageBox.Show("Thông tin đăng nhập sai");
            }
            else
            {
                frm_Main.Show();
                this.Hide();
            }
        }


        private void frm_login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?",
                                          "Xác nhận thoát",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            // Kiểm tra kết quả của hộp thoại
            if (result == DialogResult.Yes)
            {
                Application.Exit();  
            }

        }

        
    }
}
