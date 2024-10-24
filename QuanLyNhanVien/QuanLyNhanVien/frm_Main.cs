using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void hồSơNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NhanVien"] == null)
            {
                frm_NhanVien frm_NhanVien = new frm_NhanVien();
                frm_NhanVien.MdiParent = this;
                frm_NhanVien.Show();
            }
            else Application.OpenForms["frm_NhanVien"].Activate();
            
        }



        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?",
                                          "Xác nhận thoát",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();  
            }
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_SanPham"] == null)
            {
                frm_SanPham frm_SanPham = new frm_SanPham();
                frm_SanPham.MdiParent = this;
                frm_SanPham.Show();
            }
            else Application.OpenForms["frm_SanPham"].Activate();
        }

        private void frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
