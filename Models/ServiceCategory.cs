wnamespace Servico_Facil_App.Models
{
    public class ServiceCategory
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public string? Icon { get; set; } // URI

        public ServiceCategory()
        {
        }

        public ServiceCategory(int id, string name, string icon)
        {
            ID = id;
            Name = name;
            Icon = icon;
        }
    }
}
