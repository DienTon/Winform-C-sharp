namespace QuanLyNhanVien
{
    partial class frm_login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_TenDangNhap = new TextBox();
            txt_MatKhau = new TextBox();
            label2 = new Label();
            btn_DangNhap = new Button();
            btn_Thoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(153, 121);
            label1.Name = "label1";
            label1.Size = new Size(174, 32);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            label1.Click += label1_Click;
            // 
            // txt_TenDangNhap
            // 
            txt_TenDangNhap.Location = new Point(370, 121);
            txt_TenDangNhap.Name = "txt_TenDangNhap";
            txt_TenDangNhap.Size = new Size(224, 27);
            txt_TenDangNhap.TabIndex = 2;
            // 
            // txt_MatKhau
            // 
            txt_MatKhau.Location = new Point(370, 208);
            txt_MatKhau.Name = "txt_MatKhau";
            txt_MatKhau.Size = new Size(224, 27);
            txt_MatKhau.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(153, 202);
            label2.Name = "label2";
            label2.Size = new Size(115, 32);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu";
            label2.Click += label2_Click;
            // 
            // btn_DangNhap
            // 
            btn_DangNhap.Location = new Point(201, 303);
            btn_DangNhap.Name = "btn_DangNhap";
            btn_DangNhap.Size = new Size(94, 29);
            btn_DangNhap.TabIndex = 5;
            btn_DangNhap.Text = "Đăng nhập";
            btn_DangNhap.UseVisualStyleBackColor = true;
            btn_DangNhap.Click += btn_DangNhap_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(370, 303);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(94, 29);
            btn_Thoat.TabIndex = 6;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_DangNhap);
            Controls.Add(label2);
            Controls.Add(txt_MatKhau);
            Controls.Add(txt_TenDangNhap);
            Controls.Add(label1);
            Name = "frm_login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_TenDangNhap;
        private TextBox txt_MatKhau;
        private Label label2;
        private Button btn_DangNhap;
        private Button btn_Thoat;
    }
}
