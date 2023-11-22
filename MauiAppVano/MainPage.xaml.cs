namespace MauiAppVano
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }
 

        private void ToOnImageClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PageMilkCheese());
        }

        private void ToOnVigitablesClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new VigitablesPage());
        }
        private void ToOnWaterClick(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WaterPage());
        }

    }
}