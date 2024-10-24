namespace test2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_con"] == null)
            {
                frm_Con sv = new frm_Con();
                sv.MdiParent = this;
                sv.Show();
            }
            else Application.OpenForms["frm_con"].Activate();
        }
    }
}
