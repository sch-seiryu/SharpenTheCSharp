// {demo}{ReactiveUI} From the 'RoutingExample'

using System;
using ReactiveUI;

namespace ReactiveUiDemo.ViewModels;

public class FirstViewModel : ReactiveObject, IRoutableViewModel
{
    // Refernce to IScreen that owns the routable view model.
    public IScreen HostScreen { get; }
        
    // Unique identifier for the routable view model.
    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);

    public FirstViewModel(IScreen screen) => HostScreen = screen;
}
