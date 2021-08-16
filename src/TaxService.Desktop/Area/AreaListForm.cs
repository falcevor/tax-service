using System;
using System.Windows.Forms;

namespace TaxService.Desktop.Area
{
    public partial class AreaListForm : Form
    {
        public AreaListForm()
        {
            InitializeComponent();
        }

        private void tsbtnAddArea_Click(object sender, EventArgs e)
        {
            var dlg = new NewAreaForm();
            dlg.ShowDialog();

            if (dlg.AreaName != null)
            {
                dgvTaxAreas.Rows.Add(new object[] { dlg.AreaId, dlg.AreaName });
            }
        }

        private void tsbtnDeleteArea_Click(object sender, EventArgs e)
        {
            var selectedrowindex = dgvTaxAreas.SelectedCells[0].RowIndex;
            var selectedRow = dgvTaxAreas.Rows[selectedrowindex];
            dgvTaxAreas.Rows.RemoveAt(selectedRow.Index);
        }
    }
}
