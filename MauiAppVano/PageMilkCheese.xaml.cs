namespace MauiAppVano;

public partial class PageMilkCheese : ContentPage
{

    public PageMilkCheese()
    {
        InitializeComponent();

    }


    private void BuyBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BuyOrder());
    }

    private void BuyCheeseBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BuyOrder());
    }
}
