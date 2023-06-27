using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using DemoApp.Services;
using DemoApp.ViewModels;

namespace DemoApp;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        // base.OnFrameworkInitializationCompleted();
        
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            // {demo} Creating temporary database to mock DB based text files
            // var db = new Database();
            
            desktop.MainWindow = new Views.MainWindow 
            {
                    DataContext = new MainWindowViewModel(),
            };
        }
        
        base.OnFrameworkInitializationCompleted();
    }
}