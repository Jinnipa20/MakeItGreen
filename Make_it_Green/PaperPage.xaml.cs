
using Make_it_Green.Services;
using Make_it_Green.ViewModels;

namespace Make_it_Green;

public partial class PaperPage : ContentPage
{
	public PaperPage(FirestoreService firestoreService)
	{
		InitializeComponent();

        BindingContext = new GarbageDataViewModel(firestoreService, "Paper &Cardboard", 4.0); // 4 บาทต่อกิโลกรัม

		// ซ่อนแถบ Navigation Bar PaperPage
        NavigationPage.SetHasNavigationBar(this, false);
	}
	private async void OnSaveClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new GarbageListPage());
    }
}
	
       