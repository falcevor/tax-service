using System.Windows.Forms;

namespace TaxService.Desktop.Area
{
    public partial class NewAreaForm : Form
    {
        public int AreaId { get; set; }
        public string AreaName { get; set; }

        public NewAreaForm()
        {
            InitializeComponent();
        }

        private void btnSelectInspector_Click(object sender, System.EventArgs e)
        {

        }
    }
}
