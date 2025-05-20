namespace ServicoFacilApp.Models;

public class Categoria
{
    public int ID { get; set; }
    public required string Nome { get; set; }
    public string? Descricao { get; set; }

    public Categoria()
    {
    }

    public Categoria(string nome, string? descricao = null)
    {
        Nome = nome;
        Descricao = descricao;
    }
}
