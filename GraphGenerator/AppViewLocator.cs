using System;
using GraphGenerator.ViewModels;
using GraphGenerator.Views;
using ReactiveUI;

namespace GraphGenerator;

public class AppViewLocator : IViewLocator
{
    public IViewFor ResolveView<T>(T viewModel, string contract = null) => viewModel switch
    {
        GraphTemplateViewModel context => new GraphTemplateView { DataContext = context },
        ShortCutTemplateViewModel context => new ShortCutTemplateView { DataContext = context },
        AnimationViewModel context => new AnimationView { DataContext = context },
        _ => throw new ArgumentOutOfRangeException(nameof(viewModel))
    };
}