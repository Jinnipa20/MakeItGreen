using System;
using System.Collections.ObjectModel;
using Make_it_Green.Services;

namespace Make_it_Green.ViewModels;

public class GarbageListViewModel
{
    private readonly FirestoreService _firestoreService;
    public ObservableCollection<GarbageDataModel> AllGarbageData { get; set; } = new();

    public GarbageListViewModel()
    {
        _firestoreService = new FirestoreService();
        LoadGarbageData().ConfigureAwait(false);
    }

    public async Task LoadGarbageData()
    {
        try
        {
            var garbageList = await _firestoreService.GetAllGarbageData();
            if (garbageList != null)
            {
                AllGarbageData.Clear();
                foreach (var item in garbageList)
                {
                    AllGarbageData.Add(item);
                }
            }
        }
        catch (Exception ex)
        {
            // Handle exceptions (e.g., log error or display alert)
            Console.WriteLine($"Error loading data: {ex.Message}");
        }
    }
}
