using Make_it_Green.Services;

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
        var firestoreService = new FirestoreService(); // หรือใช้ออบเจ็กต์ที่มีอยู่แล้ว
        await Navigation.PushAsync(new PlasticPage(firestoreService));
    }
 private async void OnMetalsClicked(object sender, EventArgs e)
    {
        // Metals
        var firestoreService = new FirestoreService();
        await Navigation.PushAsync(new MetalPage(firestoreService));
    }
 private async void OnGlassClicked(object sender, EventArgs e)
    {
        // Glass
        var firestoreService = new FirestoreService();
        await Navigation.PushAsync(new GlassPage(firestoreService));
    }
    private async void OnElectronicsClicked(object sender, EventArgs e)
    {
        // Electronics
        var firestoreService = new FirestoreService();
        await Navigation.PushAsync(new ElectronicPage(firestoreService));
    }
    private async void OnTextilesClicked(object sender, EventArgs e)
    {
        // Textiles
        var firestoreService = new FirestoreService();
        await Navigation.PushAsync(new TextilePage(firestoreService));
    }
    private async void OnPaperClicked(object sender, EventArgs e)
    {
        // Paper
        var firestoreService = new FirestoreService();
        await Navigation.PushAsync(new PaperPage(firestoreService));
    }
}