namespace MauiCalculoDiaria.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        // Todo
        return;
    }

    private async void Sobre_Page_Button(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Views.PaginaSobre());
    }
}