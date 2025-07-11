using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_cong_ty
{
    public partial class QLCT : Form
    {
        public QLCT()
        {
            InitializeComponent();
        }

        private void QLCT_Load(object sender, EventArgs e)
        {

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLKH qLKH = new QLKH();
            qLKH.MdiParent = this;
            qLKH.Show();
        }
    }
}
