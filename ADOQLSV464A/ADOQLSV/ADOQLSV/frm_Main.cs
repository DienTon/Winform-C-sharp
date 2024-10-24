using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADOQLSV
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_SinhVien"] == null)
            {
                frm_SinhVien sv = new frm_SinhVien();
                sv.MdiParent = this;
                sv.Show();
            }
            else Application.OpenForms["frm_SinhVien"].Activate();

        }

        private void quảnLýGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_GiaoVien"] == null)
            {
                frm_GiaoVien sv = new frm_GiaoVien();
                sv.MdiParent = this;
                sv.Show();
            }
            else Application.OpenForms["frm_GiaoVien"].Activate();
        }
    }
}
