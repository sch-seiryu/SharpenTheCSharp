using Avalonia.Controls;
using Avalonia.Interactivity;

namespace DemoApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    public void date_String_Now_Button_Click(object sender, RoutedEventArgs e)
    {
        var button = (Button)sender;
        button.Content = Utilities.date_string();
    }
    
    public void date_String_UTCNow_Button_Click(object sender, RoutedEventArgs e)
    {
        var button = (Button)sender;
        button.Content = Utilities.date_string(true);
    }
}