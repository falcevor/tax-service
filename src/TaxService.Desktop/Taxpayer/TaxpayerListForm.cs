using System;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using TaxService.Client;

namespace TaxServiceDesktop.Taxpayer
{
    public partial class TaxpayerListForm : Form
    {
        private readonly int _inspectorId;
        private readonly TaxServiceClient _client;

        public TaxpayerListForm(int inspectorId)
        {
            _inspectorId = inspectorId;
            _client = new TaxServiceClient("http://localhost:5000", new HttpClient());
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            var response = await _client.GetTaxpayersAsync(); //TODO: Загружать индивидуально под инспектора

            if (response?.Any() ?? false)
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
            var selectedrowindex = dgvTaxpayerList.SelectedCells[0].RowIndex;
            var selectedRow = dgvTaxpayerList.Rows[selectedrowindex];
            var value = Convert.ToString(selectedRow.Cells["cmID"].Value);
            var selectedId = Int32.Parse(value);
            var info = await _client.GetTaxpayerAsync(selectedId);

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
            var response = await _client.GetTaxpayersAsync(); //TODO: Загружать индивидуально под инспектора

            var filtered = response.Where(x => x.Name.Contains(filter) ||
                x.Inn.Contains(filter) ||
                x.Kpp.Contains(filter) ||
                x.PlaceAddress.Contains(filter) ||
                x.TaxType.Name.Contains(filter) ||
                x.Category.Name.Contains(filter) ||
                x.AdditionalInfo.Contains(filter)
            ).ToList();

            if (filtered != null)
            {
                dgvTaxpayerList.DataSource = filtered;
            }
        }
    }
}
