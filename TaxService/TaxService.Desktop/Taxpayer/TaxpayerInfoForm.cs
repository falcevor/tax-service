using ServiceReference1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace TaxServiceDesktop.Taxpayer
{
    public partial class TaxpayerInfoForm : Form
    {
        private TaxpayerInfo _info;
        private int _inspectorId;

        public TaxpayerInfoForm(int inspectorId, TaxpayerInfo info)
        {
            _info = info;
            _inspectorId = inspectorId;
            InitializeComponent();

            tbINN.Text = info.inn;
            tbKPP.Text = info.kpp;
            tbName.Text = info.name;
            tbCategory.Text = info.category;
            tbTaxType.Text = info.taxType;
            tbPlaceCategory.Text = info.placeType;
            tbPlaceAddress.Text = info.placeAddress;
            tbAdditionalInfo.Text = info.additionalInfo;
            dtpDate.Value = info.beginDate;
            tbPercent.Text = "" + info.percent;

            Text = $"{info.inn} : {info.name} : {Text}";
            if (info.documents == null) return;
            foreach (var doc in info.documents)
            {
                dgvAttachments.Rows.Add(new object[] { doc.id, doc.name, doc.description });
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
                var content = _info.documents
                    .Where(x => x.name == value)
                    .Select(x => x.file)
                    .First();

                File.WriteAllBytes(dlg.FileName, content);
            }
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            var attach = new List<DocumentInfo>();
            foreach (DataGridViewRow row in dgvAttachments.Rows)
            {
                var name = Convert.ToString(row.Cells[0].Value);
                var doc = _info.documents?
                    .Where(x => x.name == name)
                    .FirstOrDefault();

                if (doc != null)
                {
                    attach.Add(doc);
                    continue;
                }

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
                id = _info.id,
                inn = tbINN.Text,
                kpp = tbKPP.Text,
                name = tbName.Text,
                category = tbCategory.Text,
                taxType = tbTaxType.Text,
                placeType = tbPlaceCategory.Text,
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
    }
}
