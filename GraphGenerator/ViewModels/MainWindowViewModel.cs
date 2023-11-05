using System;
using System.Collections.ObjectModel;

namespace GraphGenerator.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public string Greeting => "Welcome to Avalonia!";

    // VM을 복수개 생성하는 방식.
    // 추가 Reference:
    //  [1] https://docs.avaloniaui.net/docs/next/tutorials/music-store-app/add-items-to-users-collection
    public ObservableCollection<GraphTemplateViewModel> Graphs { get; } = new();
    public ObservableCollection<ShortCutTemplateViewModel> ShortCuts { get; } = new();

    public MainWindowViewModel()
    {
        // Console.WriteLine("[MWVM] instantiate.");
        // Console.WriteLine($"{Graphs.GetType()}, {ShortCuts.GetType()}");
        
        // Set test data - for ShortCuts
        ShortCuts.Add(new ShortCutTemplateViewModel(Pop<ShortCutTemplateViewModel>));
        // Console.WriteLine($"[MWVM] ShortCuts.Count={ShortCuts.Count}");
        ShortCuts.Add(new ShortCutTemplateViewModel(Pop<ShortCutTemplateViewModel>));
        ShortCuts.Add(new ShortCutTemplateViewModel(Pop<ShortCutTemplateViewModel>));
        
        // Set test data - for Graphs
        Graphs.Add(new GraphTemplateViewModel());
        Graphs.Add(new GraphTemplateViewModel());
    }

    private void Pop<T>(T viewModel)
    {
        switch (viewModel)
        {
            case ShortCutTemplateViewModel vm:
            {
                if (ShortCuts.Contains(vm)) ShortCuts.Remove(vm);
                break;
            }
        }
    }
}