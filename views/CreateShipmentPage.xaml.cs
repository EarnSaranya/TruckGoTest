namespace TruckGoTest.views;

public partial class CreateShipmentPage : ContentPage
{
	public CreateShipmentPage()
	{
		InitializeComponent();
	}

    async void frameM2_Tapped(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new M2Page());
    }

    //async void frameM3_Tapped(object sender, EventArgs e)
    //{
    //    await Navigation.PushAsync(new M3Page());
    //}
}
