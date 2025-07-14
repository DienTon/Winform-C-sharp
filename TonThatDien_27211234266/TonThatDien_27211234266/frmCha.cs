using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TonThatDien_27211234266
{
    public partial class frmCha : Form
    {
        public frmCha()
        {
            InitializeComponent();
        }

        private void hỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QUANLYCAFE qUANLYCAFE = new QUANLYCAFE();
            qUANLYCAFE.MdiParent = this;
            qUANLYCAFE.Show();
        }
    }
}
