using ServicoFacilApp.Views;

namespace Servico_Facil_App.Views
{
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        private async void OnRegisterClicked(object sender, EventArgs e)
        {
            string name = nameEntry.Text;
            string email = emailEntry.Text;
            string password = passwordEntry.Text;
            string role = rolePicker.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(email) &&
                !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(role))
            {
                if (role == "Prestador")
                    await Navigation.PushAsync(new HomePrestadorPage());
                else
                    await Navigation.PushAsync(new HomeContratantePage());
            }
            else
            {
                await DisplayAlert("Erro", "Preencha todos os campos.", "OK");
            }
        }
    }
}
