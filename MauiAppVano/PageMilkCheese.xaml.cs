namespace MauiAppVano;

public partial class PageMilkCheese : ContentPage
{

    public PageMilkCheese()
    {
        InitializeComponent();

    }


    private void BuyBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BuyMilk());
    }

    private void BuyCheeseBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BuyCheese());
    }
}
