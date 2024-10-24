namespace QuanLyNhanVien
{
    partial class frm_Main
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
            menuStrip1 = new MenuStrip();
            hệThốngToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            quảnLíNhânViênToolStripMenuItem = new ToolStripMenuItem();
            hồSơNhânViênToolStripMenuItem = new ToolStripMenuItem();
            thôngTinPhòngBanToolStripMenuItem = new ToolStripMenuItem();
            giớiThiệuToolStripMenuItem = new ToolStripMenuItem();
            giúpĐỡToolStripMenuItem = new ToolStripMenuItem();
            sảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { hệThốngToolStripMenuItem, quảnLíNhânViênToolStripMenuItem, thôngTinPhòngBanToolStripMenuItem, giớiThiệuToolStripMenuItem, giúpĐỡToolStripMenuItem, sảnPhẩmToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1031, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            hệThốngToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thoátToolStripMenuItem });
            hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            hệThốngToolStripMenuItem.Size = new Size(85, 24);
            hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(130, 26);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // quảnLíNhânViênToolStripMenuItem
            // 
            quảnLíNhânViênToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { hồSơNhânViênToolStripMenuItem });
            quảnLíNhânViênToolStripMenuItem.Name = "quảnLíNhânViênToolStripMenuItem";
            quảnLíNhânViênToolStripMenuItem.Size = new Size(137, 24);
            quảnLíNhânViênToolStripMenuItem.Text = "Quản lí nhân viên";
            // 
            // hồSơNhânViênToolStripMenuItem
            // 
            hồSơNhânViênToolStripMenuItem.Name = "hồSơNhânViênToolStripMenuItem";
            hồSơNhânViênToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            hồSơNhânViênToolStripMenuItem.Size = new Size(291, 26);
            hồSơNhânViênToolStripMenuItem.Text = "Hồ sơ nhân viên";
            hồSơNhânViênToolStripMenuItem.Click += hồSơNhânViênToolStripMenuItem_Click;
            // 
            // thôngTinPhòngBanToolStripMenuItem
            // 
            thôngTinPhòngBanToolStripMenuItem.Name = "thôngTinPhòngBanToolStripMenuItem";
            thôngTinPhòngBanToolStripMenuItem.Size = new Size(162, 24);
            thôngTinPhòngBanToolStripMenuItem.Text = "Thông tin phòng ban";
            // 
            // giớiThiệuToolStripMenuItem
            // 
            giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            giớiThiệuToolStripMenuItem.Size = new Size(87, 24);
            giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            // 
            // giúpĐỡToolStripMenuItem
            // 
            giúpĐỡToolStripMenuItem.Name = "giúpĐỡToolStripMenuItem";
            giúpĐỡToolStripMenuItem.Size = new Size(76, 24);
            giúpĐỡToolStripMenuItem.Text = "Giúp đỡ";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            sảnPhẩmToolStripMenuItem.Size = new Size(128, 24);
            sảnPhẩmToolStripMenuItem.Text = "Menu sản phẩm";
            sảnPhẩmToolStripMenuItem.Click += sảnPhẩmToolStripMenuItem_Click;
            // 
            // frm_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 499);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "frm_Main";
            Text = "frm_Main";
            FormClosing += frm_Main_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem hệThốngToolStripMenuItem;
        private ToolStripMenuItem quảnLíNhânViênToolStripMenuItem;
        private ToolStripMenuItem hồSơNhânViênToolStripMenuItem;
        private ToolStripMenuItem thôngTinPhòngBanToolStripMenuItem;
        private ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private ToolStripMenuItem giúpĐỡToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private ToolStripMenuItem sảnPhẩmToolStripMenuItem;
    }
}