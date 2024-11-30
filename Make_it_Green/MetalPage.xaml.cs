using Make_it_Green.Services;
using Make_it_Green.ViewModels;

namespace Make_it_Green;

public partial class MetalPage : ContentPage
{
	public MetalPage(FirestoreService firestoreService)
	{
		InitializeComponent();

        BindingContext = new GarbageDataViewModel(firestoreService, "Metals", 30.0); // 30 บาทต่อกิโลกรัม

		// ซ่อนแถบ Navigation Bar MetalPage
        NavigationPage.SetHasNavigationBar(this, false);
    
	}

	private async void OnSaveClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GarbageListPage());
    }
}