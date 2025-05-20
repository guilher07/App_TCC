namespace ServicoFacilApp.Services
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Tipo { get; set; } // "Contratante" ou "Prestador"
    }

    public static class ServicoDeLogin
    {
        public static async Task<Usuario> AutenticarUsuario(string email, string senha)
        {
            await Task.Delay(300);

            if (email == "contratante@email.com" && senha == "1234")
            {
                return new Usuario { Nome = "Maria", Email = email, Tipo = "Contratante" };
            }
            else if (email == "prestador@email.com" && senha == "1234")
            {
                return new Usuario { Nome = "João", Email = email, Tipo = "Prestador" };
            }

            return null;
        }
    }
}
