using System;
using System.ComponentModel;
using ReactiveUI;

namespace DemoApp.ViewModels;

public class FirstPageViewModel : ReactiveObject, IRoutableViewModel
{
    public IScreen HostScreen { get; }
    
    public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);
    
    public FirstPageViewModel(IScreen screen) => HostScreen = screen;
    
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