using System.Collections.ObjectModel;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using DemoApp.ViewModel;

namespace DemoApp.View;

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        InitializeComponent();
        AvaloniaXamlLoader.Load(this);
        
    }
}