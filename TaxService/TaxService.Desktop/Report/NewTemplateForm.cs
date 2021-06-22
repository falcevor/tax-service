using ServiceReference1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TaxServiceDesktop.Report
{
    public partial class NewTemplateForm : Form
    {
        public NewTemplateForm()
        {
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
            var parameterList = new List<ReportTemplateParameterInfo>();

            foreach (DataGridViewRow row in dgvParameters.Rows)
            {
                if (string.IsNullOrEmpty(Convert.ToString(row.Cells[0].Value))) continue;

                parameterList.Add(new ReportTemplateParameterInfo()
                {
                    id = -1,
                    name = Convert.ToString(row.Cells[0].Value),
                    description = Convert.ToString(row.Cells[1].Value),
                    defaultValue = Convert.ToString(row.Cells[2].Value)
                });
            }

            var info = new ReportTemplateInfo()
            {
                id = -1,
                name = tbName.Text,
                description = tbDescription.Text,
                file = File.ReadAllBytes(tbTemplatePath.Text),
                parameters = parameterList.ToArray()
            };

            var client = new TaxServiceClient();
            var response = await client.SaveReportTemplateInfoAsync(info);

            if (!response)
            {
                MessageBox.Show("Ошибка сохранения");
            }
            else
            {
                Close();
            }
        }
    }
}
