using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using TaxService.Client;

namespace TaxServiceDesktop.Report
{
    public partial class NewTemplateForm : Form
    {
        private readonly TaxServiceClient _client;

        public NewTemplateForm()
        {
            _client = new TaxServiceClient("http://localhost:5000", new HttpClient());
            InitializeComponent();
        }

        private void btnTemplateChoose_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog();
            dlg.Filter = "Word Documents|*.docx";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                tbTemplatePath.Text = dlg.FileName;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            var parameterList = new List<ReportTemplateParameter>();

            foreach (DataGridViewRow row in dgvParameters.Rows)
            {
                if (string.IsNullOrEmpty(Convert.ToString(row.Cells[0].Value))) continue;

                parameterList.Add(new ReportTemplateParameter()
                {
                    Id = -1,
                    Name = Convert.ToString(row.Cells[0].Value),
                    Description = Convert.ToString(row.Cells[1].Value),
                    DefaultValue = Convert.ToString(row.Cells[2].Value)
                });
            }

            var info = new CreateReportTemplateCommand()
            {
                Name = tbName.Text,
                Description = tbDescription.Text,
                File = File.ReadAllBytes(tbTemplatePath.Text),
                Parameters = parameterList.ToArray()
            };


            try
            {
                await _client.CreateReportTemplateAsync(info);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения\n{ex.Message}");
            }
        }
    }
}
