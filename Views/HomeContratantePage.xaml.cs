using ServicoFacilApp.Models;
using System.Collections.ObjectModel;

namespace ServicoFacilApp.Views;

public partial class HomeContratantePage : ContentPage
{
    public ObservableCollection<Categoria> Categorias { get; set; }
    public ObservableCollection<Prestador> Prestadores { get; set; }

    public HomeContratantePage()
    {
        InitializeComponent();
        Categorias = new ObservableCollection<Categoria>
        {
            new Categoria { Nome = "Encanador" },
            new Categoria { Nome = "Eletricista" },
            new Categoria { Nome = "Pedreiro" },
            new Categoria { Nome = "Pintor" }
        };
        Prestadores = new ObservableCollection<Prestador>();
        CategoriasCollection.ItemsSource = Categorias;
        PrestadoresCollection.ItemsSource = Prestadores;
    }

    private void OnCategoriaSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Categoria categoriaSelecionada)
        {
            // Simula filtragem
            Prestadores.Clear();
            Prestadores.Add(new Prestador { Nome = "João da Silva", Especialidade = categoriaSelecionada.Nome });
            Prestadores.Add(new Prestador { Nome = "Maria Souza", Especialidade = categoriaSelecionada.Nome });
        }
    }

    private void OnSearch(object sender, EventArgs e)
    {
        string searchText = searchBar?.Text ?? string.Empty;
        var filteredItems = Prestadores.Where(p => p.Nome.ToLower().Contains(searchText.ToLower())).ToList();

        PrestadoresCollection.ItemsSource = filteredItems;
    }

    private async void OnSolicitarOrcamentoClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Orçamento", "Solicitação enviada ao prestador!", "OK");
    }
}