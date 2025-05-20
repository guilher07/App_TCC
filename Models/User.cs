namespace Servico_Facil_App.Models
{
    public class User
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string Role { get; set; } // "Contratante" ou "Prestador"
        public required string ProfileImage { get; set; } // Base64 ou URI
        public double Rating { get; set; }

        public User()
        {
        }

        public User(string name, string email, string password, string role, string profileImage)
        {
            Name = name;
            Email = email;
            Password = password;
            Role = role;
            ProfileImage = profileImage;
        }
    }
}
