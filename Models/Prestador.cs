namespace ServicoFacilApp.Models;

public class Prestador
{
    public int ID { get; set; }
    public required string Nome { get; set; }
    public required string Especialidade { get; set; }
    public double Avaliacao { get; set; }
    public int TotalServicos { get; set; }

    public Prestador()
    {
        Avaliacao = 0;
        TotalServicos = 0;
    }

    public Prestador(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
        Avaliacao = 0;
        TotalServicos = 0;
    }
}
