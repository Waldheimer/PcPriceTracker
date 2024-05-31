using PcPriceTracker.Application.Interfaces;

namespace PcPriceTracker.Application.ServiceContracts
{
    public interface INavigationService<TViewModel> where TViewModel : INavigationTarget
    {
        public void Navigate() {}
    }
}
