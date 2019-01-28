using ServiceReference1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace TaxServiceDesktop.Taxpayer
{
    public partial class NewTaxpayerForm : Form
    {
        private int _inspectorId;
        private string _avatarPath;

        public NewTaxpayerForm(int inspectorId)
        {
            _inspectorId = inspectorId;
            InitializeComponent();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            var attach = new List<DocumentInfo>();
            foreach (DataGridViewRow row in dgvAttachments.Rows)
            {
                var path = Convert.ToString(row.Cells[2].Value);
                if (string.IsNullOrEmpty(path)) continue;

                attach.Add(new DocumentInfo()
                {
                    id = -1,
                    name = Convert.ToString(row.Cells[0].Value),
                    description = Convert.ToString(row.Cells[1].Value),
                    file = File.ReadAllBytes(path)
                });
            }

            var value = new TaxpayerInfo()
            {
                id = -1,
                inn = tbINN.Text,
                kpp = tbKPP.Text,
                name = tbName.Text,
                category = cbTaxpayerCategory.Text,
                taxType = cbTaxType.Text,
                placeType = cbPlaceType.Text,
                placeAddress = tbPlaceAddress.Text,
                additionalInfo = tbAdditionalInfo.Text,
                percent = Int32.Parse(tbPercent.Text),
                beginDate = dtpDate.Value,
                documents = attach.ToArray()
            };

            var client = new TaxServiceClient();
            var response = await client.SaveTaxpayerInfoAsync(_inspectorId, value);

            if (!response)
            {
                MessageBox.Show("Ошибка сохранения");
            }
            else
            {
                Close();
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

            if (dlg.name != null)
            {
                dgvAttachments.Rows.Add(new object[] { dlg.name, dlg.description, dlg.path });
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
