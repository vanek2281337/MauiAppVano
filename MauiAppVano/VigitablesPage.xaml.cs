namespace MauiAppVano;

public partial class VigitablesPage : ContentPage
{
	public VigitablesPage()
	{
		InitializeComponent();
	}
    private void BuyBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new BuyVigitables());

    }

}