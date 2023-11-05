// To populate graph templates dynamically, while staying GUI components bound with code-behind.

using System;
using Avalonia;
using Avalonia.Threading;
using ScottPlot;
using ScottPlot.Avalonia;

namespace GraphGenerator.ViewModels;

public class GraphTemplateViewModel : ViewModelBase
{
    public string PlotTitle => $"Plot @{Guid.NewGuid().ToString()[..5]}";
    // public AvaPlot PlotContent { get; set; } = new AvaPlot();

    public GraphTemplateViewModel()
    {
        // var plt = new ScottPlot.Plot(600, 400);
        // PlotContent.Plot = plt;
        
        // VM에서 정의하는 경우 그래프의 drawing 간섭 테스트
        // DrawDefaultDataVm();
    }

    // private void DrawDefaultDataVm()
    // {
    //     var plt = PlotContent.Plot;
    //     
    //     // sample data
    //     double[] xs = DataGen.Consecutive(51);
    //     double[] sin = DataGen.Sin(51);
    //     double[] cos = DataGen.Cos(51);
    //
    //     // plot the data
    //     plt.AddScatter(xs, sin);
    //     plt.AddScatter(xs, cos);
    //
    //     // customize the axis labels
    //     plt.Title("ScottPlot Quickstart(ViewModel)");
    //     plt.XLabel("Horizontal Axis");
    //     plt.YLabel("Vertical Axis");
    //     plt.SetAxisLimits(0D, 50D, -1.25D, 1.25D);
    //     PlotContent.IsVisible = true;
    //     PlotContent.Width = 200;
    //     PlotContent.Height = 200;
    //
    //     // Refresh graph - NOTE: 애초에 여기서 View 컴포넌트를 다루는 것 자체가 올바르지 않다.
    //     _ = Dispatcher.UIThread.InvokeAsync(PlotContent.Refresh, DispatcherPriority.Background);
    // }
}