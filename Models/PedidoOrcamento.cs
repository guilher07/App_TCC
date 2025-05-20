namespace ServicoFacilApp.Models;

public class PedidoOrcamento
{
    public int ID { get; set; }
    public required string NomeContratante { get; set; }
    public required string DescricaoServico { get; set; }
    public required string ValorOrcamento { get; set; }
    public required string DetalhesServico { get; set; }
    public required string AvaliacaoContratante { get; set; }
    public DateTime DataCriacao { get; set; }
    public string? Status { get; set; }

    public PedidoOrcamento()
    {
        DataCriacao = DateTime.Now;
        Status = "Pendente";
    }

    public PedidoOrcamento(string nomeContratante, string descricaoServico)
    {
        NomeContratante = nomeContratante;
        DescricaoServico = descricaoServico;
        DataCriacao = DateTime.Now;
        Status = "Pendente";
        ValorOrcamento = "0";
        DetalhesServico = "";
        AvaliacaoContratante = "0";
    }
}
