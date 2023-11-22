namespace MauiAppVano;

public partial class BuyVigitables : ContentPage
{
	public BuyVigitables()
	{
		InitializeComponent();
	}
    public async void Send__Click(object s, EventArgs e)
    {
        if (Name.Text == "" || TelephoneNumber.Text == "" || HomeAdress.Text == "")
        {
            await DisplayAlert("error", "error2", "error3");

        }

        if (Name.Text.Length > 0 && TelephoneNumber.Text.Length > 0 && HomeAdress.Text.Length > 0)
        {

            await Navigation.PushAsync(new MainPage());

        }
    }
}