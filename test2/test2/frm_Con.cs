using test2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test2
{
    public partial class frm_Con : Form
    {
        public frm_Con()
        {
            InitializeComponent();
        }
        LopDungChung lopChung = new LopDungChung();
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_Ten = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cb_LoaiKhach = new ComboBox();
            txt_NamHetHan = new TextBox();
            label4 = new Label();
            dtp_NgayCapThe = new DateTimePicker();
            dt_Khach = new DataGridView();
            textBox2 = new TextBox();
            label5 = new Label();
            btn_Sua = new Button();
            btn_Them = new Button();
            btn_Dem = new Button();
            btn_Xoa = new Button();
            txt_Dem = new TextBox();
            label6 = new Label();
            txt_id = new NumericUpDown();
            ((ISupportInitialize)dt_Khach).BeginInit();
            ((ISupportInitialize)txt_id).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1, 62);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên: ";
            // 
            // txt_Ten
            // 
            txt_Ten.Location = new Point(121, 59);
            txt_Ten.Name = "txt_Ten";
            txt_Ten.Size = new Size(125, 27);
            txt_Ten.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1, 106);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 2;
            label2.Text = "ngay cap the:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(288, 16);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 4;
            label3.Text = "loại khách: ";
            // 
            // cb_LoaiKhach
            // 
            cb_LoaiKhach.FormattingEnabled = true;
            cb_LoaiKhach.Location = new Point(419, 13);
            cb_LoaiKhach.Name = "cb_LoaiKhach";
            cb_LoaiKhach.Size = new Size(151, 28);
            cb_LoaiKhach.TabIndex = 5;
            // 
            // txt_NamHetHan
            // 
            txt_NamHetHan.Location = new Point(419, 56);
            txt_NamHetHan.Name = "txt_NamHetHan";
            txt_NamHetHan.Size = new Size(151, 27);
            txt_NamHetHan.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 59);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 6;
            label4.Text = "Nam het han: ";
            // 
            // dtp_NgayCapThe
            // 
            dtp_NgayCapThe.CustomFormat = "dd/MM/yyyy";
            dtp_NgayCapThe.Format = DateTimePickerFormat.Short;
            dtp_NgayCapThe.Location = new Point(121, 106);
            dtp_NgayCapThe.Name = "dtp_NgayCapThe";
            dtp_NgayCapThe.Size = new Size(125, 27);
            dtp_NgayCapThe.TabIndex = 8;
            dtp_NgayCapThe.Value = new DateTime(2024, 10, 21, 0, 0, 0, 0);
            dtp_NgayCapThe.ValueChanged += dtp_NgayCapThe_ValueChanged;
            // 
            // dt_Khach
            // 
            dt_Khach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_Khach.Location = new Point(1, 270);
            dt_Khach.Name = "dt_Khach";
            dt_Khach.RowHeadersWidth = 51;
            dt_Khach.Size = new Size(579, 235);
            dt_Khach.TabIndex = 9;
            dt_Khach.CellClick += dt_Khach_CellClick;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(90, 187);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(212, 27);
            textBox2.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 190);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 11;
            label5.Text = "Tìm kiếm";
            // 
            // btn_Sua
            // 
            btn_Sua.Location = new Point(12, 231);
            btn_Sua.Name = "btn_Sua";
            btn_Sua.Size = new Size(94, 29);
            btn_Sua.TabIndex = 12;
            btn_Sua.Text = "Sửa";
            btn_Sua.UseVisualStyleBackColor = true;
            btn_Sua.Click += btn_Sua_Click;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(246, 231);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(94, 29);
            btn_Them.TabIndex = 13;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Dem
            // 
            btn_Dem.Location = new Point(288, 108);
            btn_Dem.Name = "btn_Dem";
            btn_Dem.Size = new Size(94, 29);
            btn_Dem.TabIndex = 14;
            btn_Dem.Text = "Đếm";
            btn_Dem.UseVisualStyleBackColor = true;
            btn_Dem.Click += btn_Dem_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(130, 231);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(94, 29);
            btn_Xoa.TabIndex = 15;
            btn_Xoa.Text = "xoa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // txt_Dem
            // 
            txt_Dem.Location = new Point(419, 110);
            txt_Dem.Name = "txt_Dem";
            txt_Dem.Size = new Size(151, 27);
            txt_Dem.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1, 17);
            label6.Name = "label6";
            label6.Size = new Size(31, 20);
            label6.TabIndex = 17;
            label6.Text = "ID: ";
            // 
            // txt_id
            // 
            txt_id.Location = new Point(121, 10);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(92, 27);
            txt_id.TabIndex = 19;
            // 
            // frm_Con
            // 
            ClientSize = new Size(584, 508);
            Controls.Add(txt_id);
            Controls.Add(label6);
            Controls.Add(txt_Dem);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Dem);
            Controls.Add(btn_Them);
            Controls.Add(btn_Sua);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(dt_Khach);
            Controls.Add(dtp_NgayCapThe);
            Controls.Add(txt_NamHetHan);
            Controls.Add(label4);
            Controls.Add(cb_LoaiKhach);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_Ten);
            Controls.Add(label1);
            Name = "frm_Con";
            Load += frm_Con_Load;
            ((ISupportInitialize)dt_Khach).EndInit();
            ((ISupportInitialize)txt_id).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        int namHetHan(int nam)
        {
            return nam + 1;
        }

        void loadGT()
        {
            string sql = "Select * from KHACH";
            dt_Khach.DataSource = lopChung.LoadDL(sql);
            string sqlLoai = "Select * from LOAIKHACH";
            cb_LoaiKhach.DataSource = lopChung.LoadDL(sqlLoai);
            cb_LoaiKhach.ValueMember = "idLoaiKhach";
            cb_LoaiKhach.DisplayMember = "tenLoaiKhach";
        }
        void idAuto()
        {
            string sql = "SELECT COUNT(*) FROM KHACH";
            int kq = (int)lopChung.LayGT(sql);
            txt_id.Text = kq + 1 + "";
        }

        private void frm_Con_Load(object sender, EventArgs e)
        {
            idAuto();
            loadGT();
            txt_NamHetHan.Text = namHetHan(dtp_NgayCapThe.Value.Year).ToString();
        }

        private void btn_Dem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT COUNT(*) FROM KHACH";
            int kq = (int)lopChung.LayGT(sql);
            txt_Dem.Text = kq.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into KHACH values ('" + txt_id.Text + "','" + txt_Ten.Text + "','" + cb_LoaiKhach.SelectedValue + "','" + dtp_NgayCapThe.Value + "','" + txt_NamHetHan.Text + "')";
            //string sql = "Insert into KHACH values ('" + txt_id.Text + "','" + txt_Ten.Text + "','" + cb_LoaiKhach.Text+ "','" + "',Convert(datetime,'" + dtp_NgayCapThe.Text + "',103),'" + txt_NamHetHan.Text + "')";
            int kq = lopChung.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Thêm KH thành công");
            }
            else MessageBox.Show("Thêm KH thất bại");
            loadGT();
        }

        private void dtp_NgayCapThe_ValueChanged(object sender, EventArgs e)
        {
            txt_NamHetHan.Text = namHetHan(dtp_NgayCapThe.Value.Year).ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM KHACH WHERE idKhach=" + txt_id.Text;
            int kq = lopChung.ThemXoaSua(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Xóa KH thành công");
            }
            else MessageBox.Show("Xóa KH thất bại");
            loadGT();
        }

        private void dt_Khach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dt_Khach.CurrentRow.Cells["idKhach"].Value.ToString();
            txt_Ten.Text = dt_Khach.CurrentRow.Cells["ten"].Value.ToString();
            txt_NamHetHan.Text = dt_Khach.CurrentRow.Cells["namHetHan"].Value.ToString();
            dtp_NgayCapThe.Text = dt_Khach.CurrentRow.Cells["ngayCapThe"].Value.ToString();
        }
    }
}
