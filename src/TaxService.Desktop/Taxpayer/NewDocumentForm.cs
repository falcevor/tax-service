using System;
using System.Windows.Forms;

namespace TaxServiceDesktop.Taxpayer
{
    public partial class NewDocumentForm : Form
    {
        public string DocName { get; set; }
        public string DocDescription { get; set; }
        public string DocPath { get; set; }

        public NewDocumentForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbPath.Text = dlg.FileName;
                tbName.Text = System.IO.Path.GetFileName(dlg.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocName = tbName.Text;
            DocDescription = tbDescription.Text;
            DocPath = tbPath.Text;
            Close();
        }
    }
}
