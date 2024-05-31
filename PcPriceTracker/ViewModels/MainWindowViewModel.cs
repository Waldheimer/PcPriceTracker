using CommunityToolkit.Mvvm.ComponentModel;
using PcPriceTracker.Application.ServiceContracts;
using PcPriceTracker.Domain.Entities;
using System.Collections.ObjectModel;

namespace PcPriceTracker.ViewModels
{
    public partial class MainWindowViewModel : ObservableRecipient
    {
        private readonly IDataService pgDataService;

        [ObservableProperty]
        private ObservableCollection<CPU>? cpus;

        public MainWindowViewModel(IDataService pgDataService)
        {
            this.pgDataService = pgDataService;

            LoadAllData();
        }

        private void LoadAllData()
        {
            
        }


    }
}
