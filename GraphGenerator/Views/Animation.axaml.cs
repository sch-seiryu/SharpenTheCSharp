using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using GraphGenerator.ViewModels;

namespace GraphGenerator.Views;

public partial class AnimationView : ReactiveUserControl<AnimationViewModel>
{
    public AnimationView()
    {
        InitializeComponent();
        AvaloniaXamlLoader.Load(this);
    }
}