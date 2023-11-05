using ScottPlot.Avalonia;

namespace GraphGenerator.Models;

public class GraphModel
{


    public string PlotTitle { get; set; }
    public AvaPlot ScottPlotGraph { get; set; }
    public double[] Xs { get; set; }
    public double[] Ys { get; set; }
}