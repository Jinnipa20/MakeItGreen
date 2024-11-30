using Make_it_Green.Services;
using Make_it_Green.ViewModels;

namespace Make_it_Green;

public partial class PlasticPage : ContentPage
{
    public PlasticPage(FirestoreService firestoreService)
	{
		InitializeComponent();
        
        BindingContext = new GarbageDataViewModel(firestoreService, "Plastics", 8.0); // 8 บาทต่อกิโลกรัม

		// ซ่อนแถบ Navigation Bar PlasticPage
        NavigationPage.SetHasNavigationBar(this, false);
	}

    private async void OnSaveClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GarbageListPage());
    }
}