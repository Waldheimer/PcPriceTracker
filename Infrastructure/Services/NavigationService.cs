using CommunityToolkit.Mvvm.ComponentModel;
using PcPriceTracker.Application.Interfaces;
using PcPriceTracker.Application.ServiceContracts;
using PcPriceTracker.Infrastructure.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcPriceTracker.Infrastructure.Services
{
    //  *********************************************************************************
    //  ***** NavigationService-Class for Navigating between ViewModels *****************
    //  ***** in a single Navigation-Context                            *****************
    //  *********************************************************************************
    public class NavigationService<TViewModel> : INavigationService<TViewModel> where TViewModel : ObservableRecipient,INavigationTarget
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
    public class SubNavigationService<TViewModel, UViewModel> : ISubNavigationService<TViewModel, UViewModel>
        where TViewModel : ObservableRecipient, INavigationTarget
        where UViewModel : ObservableRecipient, INavigationTarget
    {
        private readonly SubNavigationManager _subNavigationManager;
        private readonly Func<TViewModel> _primeVMFactory;
        private readonly Func<UViewModel> _subVMFactory;

        public SubNavigationService(SubNavigationManager subNavigationManager, Func<TViewModel> primeVMFactory, Func<UViewModel> subVMFactory)
        {
            _subNavigationManager = subNavigationManager;
            _primeVMFactory = primeVMFactory;
            _subVMFactory = subVMFactory;
        }

        public void Navigate()
        {
            throw new NotImplementedException();
        }
    }
}
