
using MauiCalculoDiaria.Models;

namespace MauiCalculoDiaria
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto> 
        {

            new Quarto()
            {
                Descricao = "Suíte Econômica",
                ValorAdulto = 50.0,
                ValorCrianca = 35.0
            },

            new Quarto()
            {
                Descricao = "Suíte Executiva",
                ValorAdulto = 120.0,
                ValorCrianca = 85.0
            },

            new Quarto()
            {
                Descricao = "Suíte Luxo",
                ValorAdulto = 300.0,
                ValorCrianca = 250.0
            }

        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.ContratacaoHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 600;
            window.Height = 800;

            return window;

        }
    }
}
