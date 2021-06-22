using System;
using System.Windows.Forms;
using TaxServiceDesktop.Report;
using TaxServiceDesktop.Taxpayer;

namespace TaxServiceDesktop
{
    public partial class MainForm : Form
    {
        private int _inspectorId;

        public MainForm(int inspectorId)
        {
            _inspectorId = inspectorId;

            InitializeComponent();
        }

        private void tsbtnTaxpayerList_Click(object sender, EventArgs e)
        {
            var form = new TaxpayerListForm(_inspectorId);
            form.MdiParent = this;
            form.Show();
        }

        private void tsbtnReportTemplateList_Click(object sender, EventArgs e)
        {
            var form = new ReportTemplateListForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
