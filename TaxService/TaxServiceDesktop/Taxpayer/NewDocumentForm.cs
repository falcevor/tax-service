using System;
using System.IO;
using System.Windows.Forms;

namespace TaxServiceDesktop.Taxpayer
{
    public partial class NewDocumentForm : Form
    {
        public string name;
        public string description;
        public string path;

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
                tbName.Text = Path.GetFileName(dlg.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = tbName.Text;
            description = tbDescription.Text;
            path = tbPath.Text;
            Close();
        }
    }
}
