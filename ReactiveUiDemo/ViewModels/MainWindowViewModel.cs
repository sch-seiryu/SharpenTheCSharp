﻿using System.Reactive;
using ReactiveUI;

namespace ReactiveUiDemo.ViewModels;

// {demo}{ReactiveUI} Codes for 'Activation' examples - blocked now.
// public class MainWindowViewModel : ViewModelBase
// {
//     public string Greeting => "Welcome to Avalonia!";
// }

public class MainWindowViewModel : ReactiveObject, IScreen
{
    // The Router associated with this Screen.
    // Required by the IScreen interface.
    public RoutingState Router { get; } = new RoutingState();

    // The command that navigates a user to first view model.
    public ReactiveCommand<Unit, IRoutableViewModel> GoNext { get; }
    
    // The command that navigates a user back.
    public ReactiveCommand<Unit, Unit> GoBack => Router.NavigateBack;

    public MainWindowViewModel()
    {
        // Manage the routing state. Use the Rotuer.Navigate.Execute
        // command to navigate to different view models.
        // 
        // Note, that the Navigate.Execute method accepts an instance
        // of a view model, this allows you to pass parameters to
        // your view models, or to reuse existing view models.
        //
        GoNext = ReactiveCommand.CreateFromObservable(
            () => Router.Navigate.Execute(new FirstViewModel(this))
        );
    }
}