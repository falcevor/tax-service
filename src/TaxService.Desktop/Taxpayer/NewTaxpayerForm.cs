using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Windows.Forms;
using TaxService.Client;

namespace TaxServiceDesktop.Taxpayer
{
    public partial class NewTaxpayerForm : Form
    {
        private readonly int _inspectorId;
        private readonly TaxServiceClient _client;

        public NewTaxpayerForm(int inspectorId)
        {
            _client = new TaxServiceClient("http://localhost:5000", new HttpClient());
            _inspectorId = inspectorId;
            InitializeComponent();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            var attach = new List<Document>();
            foreach (DataGridViewRow row in dgvAttachments.Rows)
            {
                var path = Convert.ToString(row.Cells[2].Value);
                if (string.IsNullOrEmpty(path)) continue;

                attach.Add(new Document()
                {
                    Name = Convert.ToString(row.Cells[0].Value),
                    Description = Convert.ToString(row.Cells[1].Value),
                    File = File.ReadAllBytes(path)
                });
            }

            var value = new CreateTaxpayerCommand()
            {
                Inn = tbINN.Text,
                Kpp = tbKPP.Text,
                Name = tbName.Text,
                CategoryId = 1, // TODO: загружать из справочников.
                TaxTypeId = 1,
                PlaceTypeId = 1,
                AreaId = 1,
                PlaceAddress = tbPlaceAddress.Text,
                AdditionalInfo = tbAdditionalInfo.Text,
                Percent = Int32.Parse(tbPercent.Text),
                BeginDate = dtpDate.Value
                //Documents = attach.ToArray() // Отдельно прикреплять документы
            };

            try
            {
                await _client.CreateTaxpayerAsync(value);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения\n{ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbtnAddDucument_Click(object sender, EventArgs e)
        {
            var dlg = new NewDocumentForm();
            dlg.ShowDialog();

            if (dlg.DocName != null)
            {
                dgvAttachments.Rows.Add(new object[] { dlg.DocName, dlg.DocDescription, dlg.DocPath });
            }
        }

        private void tsbtnDeleteDocument_Click(object sender, EventArgs e)
        {
            var selectedrowindex = dgvAttachments.SelectedCells[0].RowIndex;
            var selectedRow = dgvAttachments.Rows[selectedrowindex];
            dgvAttachments.Rows.RemoveAt(selectedRow.Index);
        }
    }
}
