namespace QuanLyNhanVien
{
    partial class frm_SanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 19);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 0;
            label1.Text = "Mã món:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 16);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(470, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 79);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(470, 27);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 82);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên món:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(186, 223);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(470, 27);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 151);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 4;
            label3.Text = "Tên danh mục:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(186, 151);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(470, 28);
            comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(55, 299);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 8;
            label4.Text = "Ngày tạo: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 230);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 7;
            label5.Text = "Giá tiền: ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(191, 302);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(465, 27);
            dateTimePicker1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonFace;
            button1.Location = new Point(55, 377);
            button1.Name = "button1";
            button1.Size = new Size(107, 44);
            button1.TabIndex = 10;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ButtonFace;
            button2.Location = new Point(303, 377);
            button2.Name = "button2";
            button2.Size = new Size(105, 44);
            button2.TabIndex = 11;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ButtonFace;
            button3.Location = new Point(541, 377);
            button3.Name = "button3";
            button3.Size = new Size(115, 44);
            button3.TabIndex = 12;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            // 
            // frm_SanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "frm_SanPham";
            Text = "frm_SanPham";
            FormClosing += frm_SanPham_FormClosing;
            Load += frm_SanPham_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private ComboBox comboBox1;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}