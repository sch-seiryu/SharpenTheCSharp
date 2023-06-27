using System;
using ReactiveUI;

using ReactiveUiDemo.Views;
using ReactiveUiDemo.ViewModels;

namespace ReactiveUiDemo;

// public class AppViewLocator : ReactiveUI.IViewLocator
public class AppViewLocator : IViewLocator
{
    // public IViewFor ResolveView<T>(T viewModel, string contract = null) where T : class => viewModel switch
    public IViewFor ResolveView<T>(T viewModel, string contract = null) => viewModel switch
    {
        FirstViewModel context => new FirstView { DataContext = context },
        _ => throw new ArgumentOutOfRangeException(nameof(viewModel))
    };
}