using System.ComponentModel;
using System.Net.Http;
using System.Windows.Forms;
using TaxService.Client;

namespace TaxService.Desktop.Inspect
{
    public partial class InspectorSelectForm : Form
    {
        private TaxServiceClient _client;

        public InspectorSelectForm()
        {
            _client = new TaxServiceClient("http://localhost:5000", new HttpClient());

            InitializeComponent();
            var bindingList = new BindingList<Inspector>();
        }
    }
}
