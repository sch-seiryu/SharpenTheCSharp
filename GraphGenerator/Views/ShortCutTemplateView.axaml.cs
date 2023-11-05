using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using GraphGenerator.ViewModels;
using ReactiveUI;

namespace GraphGenerator.Views;

public partial class ShortCutTemplateView : ReactiveUserControl<ShortCutTemplateViewModel>
{
    public ShortCutTemplateView()
    {
        Console.WriteLine("[SCTV] instantiate...");
        InitializeComponent();
        this.WhenActivated(disposable =>
        {
            
        });
        AvaloniaXamlLoader.Load(this);
    }
}