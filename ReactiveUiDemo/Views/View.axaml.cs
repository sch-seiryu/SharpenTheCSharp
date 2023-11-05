using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Mixins;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;
using ReactiveUiDemo.ViewModels;

namespace ReactiveUiDemo.Views;

public class View : ReactiveWindow<ViewModel>
{
    // {demo}{ReactUI} Regarding code blocks below as generated in default...?
    // public View()
    // {
    //     // ViewModel's WhenActivated block will also get called.
    //     this.WhenActivated(disposables =>
    //     {
    //         /* Handle view activation etc. */
    //     });
    //     AvaloniaXamlLoader.Load(this);
    // }
    
    // Assume the Button control has the Name="ExampleButton" attribute defined in XAML
    public Button ExampleButton => this.FindControl<Button>("ExampleButton");

    public View()
    {
        this.WhenActivated(disposables =>
        {
            // // Bind the 'ExampleCommand' to 'ExampleButton' defined above.
            // this.BindCommand(ViewModel, x => x.ExampleCommand, x => x.ExampleButton)
            //     .DisposeWith(disposables);
        });
        AvaloniaXamlLoader.Load(this);
    }
}