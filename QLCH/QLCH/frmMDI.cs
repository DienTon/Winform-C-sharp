using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCH
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void frmMDI_Load(object sender, EventArgs e)
        {
            
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLNV qLNV = new QLNV();
            qLNV.MdiParent = this;
            qLNV.Show();
        }

        private void quảnLýVậtTưToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVatTu frmVatTu = new frmVatTu();
            frmVatTu.MdiParent = this;
            frmVatTu.Show();
        }
    }
}
