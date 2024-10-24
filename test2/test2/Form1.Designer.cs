namespace test2
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            thaoTacToolStripMenuItem = new ToolStripMenuItem();
            heThongToolStripMenuItem = new ToolStripMenuItem();
            sinhVienToolStripMenuItem = new ToolStripMenuItem();
            giaoVienToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { thaoTacToolStripMenuItem, heThongToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(785, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // thaoTacToolStripMenuItem
            // 
            thaoTacToolStripMenuItem.Name = "thaoTacToolStripMenuItem";
            thaoTacToolStripMenuItem.Size = new Size(80, 24);
            thaoTacToolStripMenuItem.Text = "Thao tac";
            // 
            // heThongToolStripMenuItem
            // 
            heThongToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sinhVienToolStripMenuItem, giaoVienToolStripMenuItem });
            heThongToolStripMenuItem.Name = "heThongToolStripMenuItem";
            heThongToolStripMenuItem.Size = new Size(85, 24);
            heThongToolStripMenuItem.Text = "He thong";
            // 
            // sinhVienToolStripMenuItem
            // 
            sinhVienToolStripMenuItem.Name = "sinhVienToolStripMenuItem";
            sinhVienToolStripMenuItem.Size = new Size(153, 26);
            sinhVienToolStripMenuItem.Text = "con";
            sinhVienToolStripMenuItem.Click += sinhVienToolStripMenuItem_Click;
            // 
            // giaoVienToolStripMenuItem
            // 
            giaoVienToolStripMenuItem.Name = "giaoVienToolStripMenuItem";
            giaoVienToolStripMenuItem.Size = new Size(153, 26);
            giaoVienToolStripMenuItem.Text = "giao vien";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 736);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "=7";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem thaoTacToolStripMenuItem;
        private ToolStripMenuItem heThongToolStripMenuItem;
        private ToolStripMenuItem sinhVienToolStripMenuItem;
        private ToolStripMenuItem giaoVienToolStripMenuItem;
    }
}
