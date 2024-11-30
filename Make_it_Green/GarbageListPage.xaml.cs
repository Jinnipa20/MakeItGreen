using Make_it_Green.Services;
using Make_it_Green.ViewModels;

namespace Make_it_Green;

public partial class GarbageListPage : ContentPage
{
    public GarbageListPage()
    {
    }

    public GarbageListPage(FirestoreService firestoreService)
	{
		InitializeComponent();

		BindingContext = new GarbageDataViewModel(firestoreService, string.Empty, 0);

		// ซ่อนแถบ Navigation Bar GarbagePage
        NavigationPage.SetHasNavigationBar(this, false);

	}


	private async void OnLabelTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }

    private void OnSubmitClicked(object sender, EventArgs e)
    {
    }

}