using System.ComponentModel;
// {demo} import Avalonia
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
// {demo} import ScottPlot for Avalonia
using ScottPlot.Avalonia;

namespace DemoApp;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        
        // {demo} draw sample graph using ScottPlot
        draw_Graph(null, null); // TODO_! - CALL FAILED <- Success 🤔
        
        // {demo} for MVVM pattern
        DataContext = new MainWindowViewModel();
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

    // public void draw_Graph() // object sender, RoutedEventArgs e)
    public void draw_Graph(object? sender, RoutedEventArgs? e)
    {
        double[] dataX = new double[] { 1, 2, 3, 4, 5 };
        double[] dataY = new double[] { 1, 4, 9, 16, 25 };
        AvaPlot avaPlot1 = this.Find<AvaPlot>("AvaPlot1");
        avaPlot1.Plot.AddScatter(dataX, dataY);
        avaPlot1.Refresh();
    }

    public void show_Graph_Button_Click(object sender, RoutedEventArgs e)
    {
        draw_Graph(sender, e);
    }
}

public class MainWindowViewModel : INotifyPropertyChanged
{
    private string _dateString = "";
    private string _dateStringUtc = "";

    public string DateString
    {
        get => _dateString;
        set
        {
            _dateString = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DateString)));
        }
    }
        
    public string DateStringUtc
    {
        get => _dateStringUtc;
        set
        {
            _dateStringUtc = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DateStringUtc)));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    public void DateStringButtonClicked() => DateString = Utilities.date_string();
    public void DateStringUtcButtonClicked() => DateStringUtc = Utilities.date_string(useUtc:true);
}