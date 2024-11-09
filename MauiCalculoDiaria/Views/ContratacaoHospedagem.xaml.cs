namespace MauiCalculoDiaria.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    App PropriedadesApp;

	public ContratacaoHospedagem()
	{
		InitializeComponent();

        PropriedadesApp = (App)Application.Current;

        pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;

        dtpck_checkin.MinimumDate = DateTime.Now;
        dtpck_checkin.MaximumDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day);

        dtpck_checkout.MinimumDate = dtpck_checkin.Date.AddDays(1);
        dtpck_checkout.MaximumDate = dtpck_checkin.Date.AddMonths(3);

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

    private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
    {
        DatePicker elemento = (DatePicker)sender;

        DateTime data_sel = elemento.Date;

        dtpck_checkout.MinimumDate = data_sel.AddDays(1);
        dtpck_checkout.MaximumDate = data_sel.AddMonths(3);

    }
}