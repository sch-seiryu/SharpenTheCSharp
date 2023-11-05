using System;
using System.Reactive.Disposables;
using ReactiveUI;

namespace ReactiveUiDemo.ViewModels
{
    // {demo}{ReactiveUI} Code typed following the instruction of activating a view - and this is gonna be replaced
    // by totally different codes to represent 'Routing Example'; this guide really sucks. no contexts.
    /* 
    public class ViewModel : ViewModelBase, IActivatableViewModel
    {
        public ViewModelActivator Activator { get; }
        
        public ViewModel()
        {
            Activator = new ViewModelActivator();
            this.WhenActivated((CompositeDisposable disposables) =>
            {
                /* handle activation * /
                Disposable
                    .Create(() => { /* handle deactivation * / })
                    .DisposeWith(disposables);
            });
        }
    }
    //*/
    public class ViewModel : ReactiveObject, IRoutableViewModel
    {
        // Reference to IScreen that owns the routable view model.
        public IScreen HostScreen { get; }
        
        // Unique identifier for the routable view model.
        public string UrlPathSegment { get; } = Guid.NewGuid().ToString().Substring(0, 5);

        public ViewModel(IScreen screen) => HostScreen = screen;
    }
}