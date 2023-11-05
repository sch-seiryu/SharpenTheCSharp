// To populate interactive items able to be de/attached and to be customized, and providing view routing as well. 

using System;
using System.Reactive;
using ReactiveUI;

namespace GraphGenerator.ViewModels;

public class ShortCutTemplateViewModel : ViewModelBase
{
    private readonly string _guid = Guid.NewGuid().ToString()[..5];
    public string Title => $"Title #{_guid}";

    public ReactiveCommand<Unit, Unit> CloseCommand { get; }
    private readonly Action<ShortCutTemplateViewModel> _removeViewModel;

    public ShortCutTemplateViewModel(
        Action<ShortCutTemplateViewModel> removeViewModel)
    {
        // Console.WriteLine($"[SCTVM] instantiate={_guid}");
        _removeViewModel = removeViewModel;
        CloseCommand = ReactiveCommand.Create(OnClose);
    }

    private void OnClose()
    {
        Console.WriteLine($"Page <{Title}> is closing");
        _removeViewModel(this);
    }
}