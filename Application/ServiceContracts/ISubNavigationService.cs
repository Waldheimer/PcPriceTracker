using PcPriceTracker.Application.Interfaces;

namespace PcPriceTracker.Application.ServiceContracts
{
    public interface ISubNavigationService<TViewModel, UViewModel> 
        where TViewModel : INavigationTarget
        where UViewModel : INavigationTarget
    {
        public void Navigate();
    }
}
