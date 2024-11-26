namespace Make_it_Green;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		// ซ่อนแถบ Navigation Bar GarbagePage
        NavigationPage.SetHasNavigationBar(this, false);
	}

    private async void OnPlasticsClicked(object sender, EventArgs e)
    {
        // Plastics
        await Navigation.PushAsync(new PlasticPage());
    }
 private async void OnMetalsClicked(object sender, EventArgs e)
    {
        // Metals
        await Navigation.PushAsync(new MetalPage());
    }
 private async void OnGlassClicked(object sender, EventArgs e)
    {
        // Glass
        await Navigation.PushAsync(new GlassPage());
    }
    private async void OnElectronicsClicked(object sender, EventArgs e)
    {
        // Electronics
        await Navigation.PushAsync(new ElectronicPage());
    }
    private async void OnTextilesClicked(object sender, EventArgs e)
    {
        // Textiles
        await Navigation.PushAsync(new TextilePage());
    }
    private async void OnPaperClicked(object sender, EventArgs e)
    {
        // Paper
        await Navigation.PushAsync(new PaperPage());
    }
}