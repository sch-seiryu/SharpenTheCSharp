using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using ReactiveUiDemo.ViewModels;

namespace ReactiveUiDemo.Views;

// {demo}{ReactiveUI} auto-generated codes for new 'Avalonia Window' member
// public partial class MainWindow : Window
// {
//     public MainWindow()
//     {
//         InitializeComponent();
// #if DEBUG
//         this.AttachDevTools();
// #endif
//     }
//
//     private void InitializeComponent()
//     {
//         AvaloniaXamlLoader.Load(this);
//     }
// }

public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
        this.WhenActivated(disposables => { });
        AvaloniaXamlLoader.Load(this);
    }
}
