using CommunityToolkit.Mvvm.ComponentModel;
using WpfBoilerplate.Manager;

namespace WpfBoilerplate.Services
{
    //  *********************************************************************************
    //  ***** NavigationService-Class for Navigating between ViewModels *****************
    //  ***** in a single Navigation-Context                            *****************
    //  *********************************************************************************
    public class NavigationService<TViewModel> where TViewModel : ObservableRecipient
    {
        private readonly NavigationManager _navigationManager;
        private readonly Func<TViewModel> _viewModelFactory;

        public NavigationService(NavigationManager navigationManager, Func<TViewModel> viewModelFactory)
        {
            _navigationManager = navigationManager;
            _viewModelFactory = viewModelFactory;
        }

        public void Navigate()
        {
            _navigationManager.CurrentViewModel = _viewModelFactory();
        }
    }
}
