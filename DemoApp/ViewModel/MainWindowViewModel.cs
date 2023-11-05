using System.Collections.ObjectModel;

namespace DemoApp.ViewModel;

public class MainWindowViewModel : ViewModelBase
{
    private ObservableCollection<PlottingData> _data { get; } = new ObservableCollection<PlottingData>();

    public MainWindowViewModel()
    {
        
    }
}

public class PlottingData
{
    // private AvaPlot plottable;
    private ScottPlot.Plot plottable;

    public PlottingData()
    {
        plottable = new ScottPlot.Plot(600, 400);
        
    }
}