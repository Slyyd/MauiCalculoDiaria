namespace MauiCalculoDiaria.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		try
		{
			await Navigation.PushAsync(new Views.ContratacaoHospedagem());
		}
		catch (Exception ex) { DisplayAlert("Erro", ex.Message, "OK"); }
    }
}