using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using DemoApp.ViewModels;
using ReactiveUI;

namespace DemoApp.Views;

public partial class FirstPageView : ReactiveUserControl<FirstPageViewModel>
{
    public FirstPageView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        this.WhenActivated(disposables =>
        {
            ;
        });
        AvaloniaXamlLoader.Load(this);
    }
}