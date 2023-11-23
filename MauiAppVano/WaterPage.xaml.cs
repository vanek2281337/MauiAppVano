namespace MauiAppVano;

public partial class WaterPage : ContentPage
{
	public WaterPage()
	{
		InitializeComponent();
	}


    private void BuyBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BuyOrder());

    }
}