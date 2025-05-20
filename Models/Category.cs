using System.Text.Json.Serialization;

namespace Servico_Facil_App.Models
{
    public class Category
    {
        public int ID { get; set; }
        public required string Title { get; set; }
        public required string Color { get; set; } = "#FF0000";
        public string? Icon { get; set; }

        [JsonIgnore]
        public Brush ColorBrush
        {
            get
            {
                return new SolidColorBrush(Microsoft.Maui.Graphics.Color.FromArgb(Color));
            }
        }

        public override string ToString() => $"{Title}";
    }
}