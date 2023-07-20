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
}
