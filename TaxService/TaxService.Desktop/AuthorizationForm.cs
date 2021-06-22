using ServiceReference1;
using System;
using System.Windows.Forms;

namespace TaxServiceDesktop
{
    public partial class AuthorizationForm : Form
    {
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private async void btnEnter_Click(object sender, EventArgs e)
        {
            var login = tbLogin.Text;
            var pass = tbPassword.Text;

            var client = new TaxServiceClient();
            var response = await client.LoginAsync(login, pass);

            if (response != -1)
            {
                var mainForm = new MainForm(response);
                mainForm.FormClosed += (s, a) => Close();
                mainForm.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Введен неверный логин или пароль.");
            }

        }
    }
}
