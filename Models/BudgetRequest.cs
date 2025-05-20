namespace Servico_Facil_App.Models
{
    public class BudgetRequest
    {
        public int ID { get; set; }
        public required User Contractor { get; set; }
        public required User Provider { get; set; }
        public required string Description { get; set; }
        public decimal? Value { get; set; }
        public required string Status { get; set; } // "Pendente", "Enviado", "Aceito"
        public DateTime CreatedAt { get; set; }
        public DateTime? CompletedAt { get; set; }

        public BudgetRequest()
        {
            CreatedAt = DateTime.Now;
            Status = "Pendente";
        }
    }
}
