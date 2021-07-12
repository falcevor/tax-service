using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using TaxService.Client;

namespace TaxServiceDesktop.Taxpayer
{
    public partial class TaxpayerInfoForm : Form
    {
        private int _inspectorId;
        private readonly TaxServiceClient _client;
        private readonly GetTaxpayerByIdResponse _info;

        public TaxpayerInfoForm(int inspectorId, GetTaxpayerByIdResponse info)
        {
            _client = new TaxServiceClient("http://localhost:5000", new HttpClient());
            _info = info;
            _inspectorId = inspectorId;
            InitializeComponent();

            tbINN.Text = info.Inn;
            tbKPP.Text = info.Kpp;
            tbName.Text = info.Name;
            tbCategory.Text = info.Category.Name;
            tbTaxType.Text = info.TaxType.Name;
            tbPlaceCategory.Text = info.PlaceType.Name;
            tbPlaceAddress.Text = info.PlaceAddress;
            tbAdditionalInfo.Text = info.AdditionalInfo;
            dtpDate.Value = info.BeginDate.DateTime;
            tbPercent.Text = "" + info.Percent;

            Text = $"{info.Inn} : {info.Name} : {Text}";
            if (info.Documents == null) return;
            foreach (var doc in info.Documents)
            {
                dgvAttachments.Rows.Add(new object[] { doc.Id, doc.Name, doc.Description });
            }
        }

        private void btnDetalization_Click(object sender, EventArgs e)
        {
            var form = new PayDetalizationForm();
            form.MdiParent = MdiParent;
            form.Show();
        }

        private void dgvAttachments_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selectedrowindex = dgvAttachments.SelectedCells[0].RowIndex;
            var selectedRow = dgvAttachments.Rows[selectedrowindex];
            var value = Convert.ToString(selectedRow.Cells[1].Value);

            var dlg = new SaveFileDialog();
            dlg.FileName = value;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var content = _info.Documents
                    .Where(x => x.Name == value)
                    .Select(x => x.File)
                    .First();

                File.WriteAllBytes(dlg.FileName, content);
            }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            var attach = new List<Document>();
            foreach (DataGridViewRow row in dgvAttachments.Rows)
            {
                var name = Convert.ToString(row.Cells[0].Value);
                var doc = _info.Documents?
                    .Where(x => x.Name == name)
                    .FirstOrDefault();

                if (doc != null)
                {
                    attach.Add(doc);
                    continue;
                }

                var path = Convert.ToString(row.Cells[2].Value);
                if (string.IsNullOrEmpty(path)) continue;

                attach.Add(new Document()
                {
                    Id = -1,
                    Name = Convert.ToString(row.Cells[0].Value),
                    Description = Convert.ToString(row.Cells[1].Value),
                    File = File.ReadAllBytes(path)
                });
            }

            var value = new UpdateTaxpayerCommand()
            {
                Id = _info.Id,
                Inn = tbINN.Text,
                Kpp = tbKPP.Text,
                Name = tbName.Text,
                CategoryId = 1, // TODO: Реализовать загрузку значений из справочников
                TaxTypeId = 1,
                PlaceTypeId = 1,
                PlaceAddress = tbPlaceAddress.Text,
                AdditionalInfo = tbAdditionalInfo.Text,
                Percent = Int32.Parse(tbPercent.Text),
                BeginDate = dtpDate.Value,
            };

            try
            {
                await _client.UpdateTaxpayerAsync(value);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения\n {ex.Message} ");
            }
        }
    }
}
