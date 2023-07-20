namespace TruckGoTest.views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    async void frameCreateSM_Tapped(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new CreateShipmentPage());
    }

    async void frameOriginPage_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new OriginPage());

    }

    async void frameDestinationPage_Tapped(object sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new DestinationPage());

    }
}
