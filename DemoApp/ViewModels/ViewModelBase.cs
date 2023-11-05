// {demo} I've typed this all looking over sample sources of Avalonia UI GitHub repo.
// There's not much options, as I hadn't created this project as an Avalonia MVVM project.
// Let's hope this works fine; it seems that it has the nullability problem as well just like the earlier tutorial of MVVM pattern.
// (some kind of invalidity handling C#)
// using System.Collections.Generic;
// using System.ComponentModel;
// using System.Runtime.CompilerServices;
using ReactiveUI;

namespace DemoApp.ViewModels
{
    // public class ViewModelBase : INotifyPropertyChanged
    public class ViewModelBase : ReactiveObject
    {
        // public event PropertyChangedEventHandler PropertyChanged;
        //
        // protected bool RaiseAndSetIfChanged<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        // {
        //     if (!EqualityComparer<T>.Default.Equals(field, value))
        //     {
        //         field = value;
        //         RaisePropertyChanged(propertyName);
        //         return true;
        //     }
        //
        //     return false;
        // }
        //
        // protected void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        //     => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}