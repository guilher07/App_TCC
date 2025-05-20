using ServicoFacilApp.Services;
using ServicoFacilApp.Views;

namespace Servico_Facil_App.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage() => InitializeComponent();

        private async void OnLoginClicked(object sender, EventArgs e)
        {
            string email = emailEntry.Text;
            string senha = senhaEntry.Text;


            var usuario = await ServicoDeLogin.AutenticarUsuario(email, senha);

            if (usuario != null)
            {

                if (usuario.Tipo == "Contratante")
                    Application.Current.MainPage = new NavigationPage(new HomeContratantePage());
                else
                    Application.Current.MainPage = new NavigationPage(new HomePrestadorPage());
            }
            else
            {
                await DisplayAlert("Erro", "Usuário ou senha inválidos.", "OK");
            }
        }
    }
}
