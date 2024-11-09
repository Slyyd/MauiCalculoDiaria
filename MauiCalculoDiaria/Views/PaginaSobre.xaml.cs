namespace MauiCalculoDiaria.Views;

public partial class PaginaSobre : ContentPage
{
	public PaginaSobre()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.ContratacaoHospedagem());
    }
}