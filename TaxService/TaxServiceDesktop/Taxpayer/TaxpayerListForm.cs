using ServiceReference1;
using System;
using System.Linq;
using System.Windows.Forms;

namespace TaxServiceDesktop.Taxpayer
{
    public partial class TaxpayerListForm : Form
    {
        private int _inspectorId;

        public TaxpayerListForm(int inspectorId)
        {
            _inspectorId = inspectorId;

            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            var client = new TaxServiceClient();
            var response = await client.GetTaxpayerListAsync(_inspectorId);

            if (response != null && response.Length != 0)
            {
                dgvTaxpayerList.DataSource = response;
            }
        }

        private void tsbtnCreate_Click(object sender, EventArgs e)
        {
            var form = new NewTaxpayerForm(_inspectorId);
            form.MdiParent = MdiParent;
            form.Show();
        }

        private async void tsbtnEdit_Click(object sender, EventArgs e)
        {
            var client = new TaxServiceClient();

            var selectedrowindex = dgvTaxpayerList.SelectedCells[0].RowIndex;
            var selectedRow = dgvTaxpayerList.Rows[selectedrowindex];
            var value = Convert.ToString(selectedRow.Cells["cmID"].Value);
            var selectedId = Int32.Parse(value);
            var info = await client.GetTaxpayerInfoAsync(selectedId);

            var form = new TaxpayerInfoForm(_inspectorId, info);
            form.MdiParent = MdiParent;
            form.Show();
        }

        private void dgvTaxpayerList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tsbtnEdit_Click(sender, null);
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            var selectedrowindex = dgvTaxpayerList.SelectedCells[0].RowIndex;
            var selectedRow = dgvTaxpayerList.Rows[selectedrowindex];
            dgvTaxpayerList.Rows.RemoveAt(selectedRow.Index);
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private async void tsbtnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tstbSearchValue.Text))
                return;

            var filter = tstbSearchValue.Text;
            var client = new TaxServiceClient();
            var response = await client.GetTaxpayerListAsync(_inspectorId);

            var filtered = response.Where(x => x.name.Contains(filter) ||
                x.inn.Contains(filter) ||
                x.kpp.Contains(filter) ||
                x.placeAddress.Contains(filter) ||
                x.taxType.Contains(filter) ||
                x.category.Contains(filter) ||
                x.additionalInfo.Contains(filter)
            ).ToList();

            if (filtered != null)
            {
                dgvTaxpayerList.DataSource = filtered;
            }
        }
    }
}
