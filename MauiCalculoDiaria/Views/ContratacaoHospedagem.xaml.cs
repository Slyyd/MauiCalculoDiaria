namespace MauiCalculoDiaria.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {

            await Navigation.PushAsync(new Views.HospedagemContratada());

        }
        catch (Exception ex) { DisplayAlert("Erro", ex.Message, "OK"); }
    }

    private async void Sobre_Page_Button(object sender, EventArgs e)
    {
        try
        {

            await Navigation.PushAsync(new Views.PaginaSobre());

        } catch (Exception ex) { DisplayAlert("Erro", ex.Message, "OK"); }
    }
}