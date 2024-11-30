using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using Make_it_Green.Services;
using PropertyChanged;

namespace Make_it_Green.ViewModels;

[AddINotifyPropertyChangedInterface]
public class GarbageDataViewModel
{
    private readonly FirestoreService _firestoreService;

    public string Type { get; set; }
    public double PricePerKg { get; set; } // ราคาต่อกิโลกรัมของแต่ละ Type
    public GarbageDataModel CurrentGarbageData { get; set; } = new GarbageDataModel();
    public ObservableCollection<GarbageDataModel> AllGarbageData { get; set; } = new ObservableCollection<GarbageDataModel>();

    public double CalculatedPrice => CurrentGarbageData.Weight * PricePerKg;

    public IAsyncRelayCommand AddOrUpdateCommand { get; }
    public RelayCommand IncreaseWeightCommand { get; }
    public RelayCommand DecreaseWeightCommand { get; }
    public GarbageDataViewModel(FirestoreService firestoreService, string type, double pricePerKg)
    {
        _firestoreService = firestoreService;
        Type = type; // ระบุประเภท
        PricePerKg = pricePerKg; // กำหนดราคาต่อกิโลกรัม

        IncreaseWeightCommand = new RelayCommand(() =>
        {
            CurrentGarbageData.Weight += 1.0;
        });

        DecreaseWeightCommand = new RelayCommand(() =>
        {
            if (CurrentGarbageData.Weight > 0)
                CurrentGarbageData.Weight -= 1.0;
        });

        AddOrUpdateCommand = new AsyncRelayCommand(async () =>
        {
            CurrentGarbageData.Type = Type; // กำหนดประเภท
            if (string.IsNullOrEmpty(CurrentGarbageData.Id))
            {
                await _firestoreService.InsertGarbageData(CurrentGarbageData);
            }   
            
            else
            {
                await _firestoreService.UpdateGarbageData(CurrentGarbageData);
            }

        });


        Refresh().ConfigureAwait(false);
    }

    public async Task Refresh()
    {
        AllGarbageData.Clear();
        var items = await _firestoreService.GetAllGarbageData();
        foreach (var item in items.Where(i => i.Type == Type))
        {
            AllGarbageData.Add(item);
        }
    }
}