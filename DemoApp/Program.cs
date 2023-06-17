using Avalonia;
using System;

namespace DemoApp;

class Program
{
    // Initialization code. Don't use any Avalonia, third-party APIs or any
    // SynchronizationContext-reliant code before AppMain is called: things aren't initialized
    // yet and stuff might break.
    [STAThread]
    public static void Main(string[] args) => BuildAvaloniaApp()
        .StartWithClassicDesktopLifetime(args);

    // Avalonia configuration, don't remove; also used by visual designer.
    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .LogToTrace();
}


class TextEditor
{
    
}

public class Utilities
{
    public Utilities()
    {
        
    }

    public static string date_string(bool useUtc = false)
    {
        // DateTime dt = new DateTime();
        var dt = useUtc ? DateTime.UtcNow : DateTime.Now;
        return dt.ToString("yyyy-MM-dd-HHmmss");
    }
}







