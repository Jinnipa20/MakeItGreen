using Make_it_Green.Services;
using Make_it_Green.ViewModels;

namespace Make_it_Green;

public partial class GlassPage : ContentPage
{
	public GlassPage(FirestoreService firestoreService)
	{
		InitializeComponent();

        BindingContext = new GarbageDataViewModel(firestoreService, "Glass", 2.0); // 2 บาทต่อกิโลกรัม

	// ซ่อนแถบ Navigation Bar GlassPage
        NavigationPage.SetHasNavigationBar(this, false);
	}
	private async void OnSaveClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GarbageListPage());
    }
}