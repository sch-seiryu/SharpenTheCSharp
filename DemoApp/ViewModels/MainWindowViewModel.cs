using System;
using System.ComponentModel;
using System.Reactive;
using System.Reactive.Disposables;
using DemoApp.Services;
using ReactiveUI;

namespace DemoApp.ViewModels
{
    // class MainWindowViewModel : ViewModelBase
    public class MainWindowViewModel : ReactiveObject, IScreen // {demo}{ReactiveUI} IActivatableViewModel, IRoutableViewModel
    {
        // {demo}{ReactiveUI}{SampleCode}{} reference="https://docs.avaloniaui.net/guides/deep-dives/reactiveui/routing"
        // The Router associated with this Screen.
        // Required by the IScreen interface.
        public RoutingState Router { get; } = new RoutingState();

        // The command that navigates a user to first view model.
        public ReactiveCommand<Unit, IRoutableViewModel> GoNext { get; }
        
        // The command that navigates a user back.
        public ReactiveCommand<Unit, IRoutableViewModel?> GoBack => Router.NavigateBack;

        public MainWindowViewModel()
        {
            // Manage the routing state. User the Router.Navigate.Excute
            // command to navigate to different view models.
            //
            // Note, that the Navigate.Execute method accepts an instance
            // of a view model, this allows you to pass parameters to
            // your view models, or to reuse existing view models.
            //
            GoNext = ReactiveCommand.CreateFromObservable(
                () => Router.Navigate.Execute(new FirstPageViewModel(this))
            );
        }
        // {EndOfSampleCode}
        
        // public ViewModelActivator Activator { get; }
        
        // private string _dateString = "";
        // private string _dateStringUtc = "";
        //
        // // public MainWindowViewModel(Database? db)
        // // {
        // //     Activator = new ViewModelActivator();
        // //     this.WhenActivated((CompositeDisposable disposables) =>
        // //     {
        // //         /* handle activation */
        // //         Disposable
        // //             .Create(() =>
        // //             {
        // //                 /*  handle deactivation */
        // //             })
        // //             .DisposeWith(disposables);
        // //     });
        // //
        // //     // Editor = 
        // //     // SampleTextList = new TextEditorViewModel(db.GetItems());
        // // }
        //
        // // public TextEditorViewModel SampleTextList { get; }
        //
        // // public MainWindowViewModel()
        // // {
        // //     ;
        // // }
        //
        // public string DateString
        // {
        //     get => _dateString;
        //     set
        //     {
        //         _dateString = value;
        //         // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DateString)));
        //         // RaisePropertyChanged(nameof(DateString));
        //     }
        // }
        //     
        // public string DateStringUtc
        // {
        //     get => _dateStringUtc;
        //     set
        //     {
        //         _dateStringUtc = value;
        //         // PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(DateStringUtc)));
        //     }
        // }
        //
        // public event PropertyChangedEventHandler PropertyChanged;
        //
        // public void DateStringButtonClicked() => DateString = Utilities.date_string();
        // public void DateStringUtcButtonClicked() => DateStringUtc = Utilities.date_string(useUtc:true);
    }
}