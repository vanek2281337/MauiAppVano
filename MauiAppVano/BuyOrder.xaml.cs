using System.Xml.Linq;

namespace MauiAppVano;

public partial class BuyOrder : ContentPage
{
    public BuyOrder()
    {
        InitializeComponent();
    }
    public async void Send__Click(object s, EventArgs e)
    {
        if (Name.Text == "" || TelephoneNumber.Text == "" || HomeAdress.Text == "")
        {
            await DisplayAlert("??????", "????? ????????? ??? ??????", "?????????");
        }

        if (Name.Text.Length > 0 && TelephoneNumber.Text.Length > 0 && HomeAdress.Text.Length > 0)
        {

            await Navigation.PushAsync(new MainPage());

        }
    }
}