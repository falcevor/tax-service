using ServiceReference1;
using System;
using System.Windows.Forms;

namespace TaxServiceDesktop.Report
{
    public partial class ReportTemplateListForm : Form
    {
        public ReportTemplateListForm()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            var client = new TaxServiceClient();
            var response = await client.GetReportTemplateListAsync();

            if (response != null && response.Length != 0)
            {
                dgvReportTemplateList.DataSource = response;
            }
        }

        private async void tsbtnCreateReport_Click(object sender, EventArgs e)
        {

            var client = new TaxServiceClient();

            var selectedrowindex = dgvReportTemplateList.SelectedCells[0].RowIndex;
            var selectedRow = dgvReportTemplateList.Rows[selectedrowindex];
            var value = Convert.ToString(selectedRow.Cells["cmID"].Value);
            var selectedId = Int32.Parse(value);
            var info = await client.GetReportTemplateInfoAsync(selectedId);

            var form = new CreateReportForm(info);
            form.MdiParent = MdiParent;
            form.Show();
        }

        private void tsbtnCreate_Click(object sender, EventArgs e)
        {
            var form = new NewTemplateForm();
            form.MdiParent = MdiParent;
            form.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
