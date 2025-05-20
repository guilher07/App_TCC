using ServicoFacilApp.Models;
using System.Collections.ObjectModel;


namespace ServicoFacilApp.Views;

public partial class HomePrestadorPage : ContentPage
{
    public ObservableCollection<PedidoOrcamento> Pedidos { get; set; }

    public HomePrestadorPage()
    {
        InitializeComponent();
        Pedidos = new ObservableCollection<PedidoOrcamento>
        {
            
        };

        PedidosCollection.ItemsSource = Pedidos;
    }

    private async void OnEnviarOrcamentoClicked(object sender, EventArgs e)
    {
        if (sender is Button button && button.CommandParameter is PedidoOrcamento pedido)
        {
            await DisplayAlert("Orçamento Enviado", $"Orçamento de R${pedido.ValorOrcamento} enviado com sucesso para {pedido.NomeContratante}.", "OK");
            // Aqui você pode implementar lógica real de notificação
        }
    }
}
