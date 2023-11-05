// using Avalonia;
// using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using ReactiveUiDemo.ViewModels;

namespace ReactiveUiDemo.Views;

// {demo}{ReactiveUI} The codes below generated when this Avalonia UserControl is created. Due to the many difference, the whole codes are blocked and will be written by hands manually.
// public partial class FirstView : UserControl
// {
//     public FirstView()
//     {
//         InitializeComponent();
//     }
//
//     private void InitializeComponent()
//     {
//         AvaloniaXamlLoader.Load(this);
//     }
// }

// public class FirstView : ReactiveUserControl<FirstViewModel>
public partial class FirstView : ReactiveUserControl<FirstViewModel>
{
    public FirstView()
    {
        this.WhenActivated(disposables => { });
        AvaloniaXamlLoader.Load(this);
    }
}

