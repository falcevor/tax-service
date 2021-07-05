using System;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using TaxService.Client;

namespace TaxServiceDesktop.Report
{
    public partial class ReportTemplateListForm : Form
    {
        private readonly TaxServiceClient _client;

        public ReportTemplateListForm()
        {
            _client = new TaxServiceClient("http://localhost:5000", new HttpClient());
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            var response = await _client.GetReportTempalatesAsync();

            if (response?.Any() ?? false)
            {
                dgvReportTemplateList.DataSource = response;
            }
        }

        private async void tsbtnCreateReport_Click(object sender, EventArgs e)
        {
            var selectedrowindex = dgvReportTemplateList.SelectedCells[0].RowIndex;
            var selectedRow = dgvReportTemplateList.Rows[selectedrowindex];
            var value = Convert.ToString(selectedRow.Cells["cmID"].Value);
            var selectedId = Int32.Parse(value);
            var info = await _client.GetReportTemplateAsync(selectedId);

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
