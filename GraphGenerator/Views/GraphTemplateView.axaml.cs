using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Avalonia.Threading;
using GraphGenerator.ViewModels;
using ReactiveUI;
using ScottPlot;
using ScottPlot.Avalonia;

namespace GraphGenerator.Views;

public partial class GraphTemplateView : ReactiveUserControl<GraphTemplateViewModel>
{
    private AvaPlot PlottableGraph { get; }
    private TextBlock Title { get; }

    // private static int _counts = 0;
    public GraphTemplateView()
    {
        // Console.WriteLine($"[GTV] {++_counts:00} instantiate...");
        InitializeComponent();
        this.WhenActivated(disposable =>
        {
            InitializeGraph();
            DrawDefaultDataFromView();

            if (DataContext == null) return;
            // Console.WriteLine(DataContext);
            // Console.WriteLine(DataContext.GetType());
            var dc = (GraphTemplateViewModel)DataContext;
            Title!.Text = dc.PlotTitle;
        });
        AvaloniaXamlLoader.Load(this);
        
        PlottableGraph = this.Find<AvaPlot>("NamedPlot")!;
        Title = this.Find<TextBlock>("TitleTextBlock")!;
    }

    private void InitializeGraph()
    {
        PlottableGraph.Plot.SetAxisLimits(0D, 50D, -1.25D, 1.25D);
        RefreshGraph();
    }

    private async void RefreshGraph()
    {
        await Dispatcher.UIThread.InvokeAsync(PlottableGraph.Refresh, DispatcherPriority.Background);
    }
    
    private void DrawDefaultDataFromView()
    {
        var plt = PlottableGraph.Plot;
        
        // sample data
        double[] xs = DataGen.Consecutive(51);
        double[] sin = DataGen.Sin(51);
        double[] cos = DataGen.Cos(51);

        // plot the data
        plt.AddScatter(xs, sin);
        plt.AddScatter(xs, cos);

        // customize the axis labels
        plt.Title("ScottPlot Quickstart(View)");
        plt.XLabel("Horizontal Axis");
        plt.YLabel("Vertical Axis");
        
        RefreshGraph();
    }
}