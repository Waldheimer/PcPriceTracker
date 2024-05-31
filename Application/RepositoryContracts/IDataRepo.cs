using PcPriceTracker.Domain.Entities;

namespace PcPriceTracker.Application.RepositoryContracts
{
    public interface IDataRepo
    {
        Task<IEnumerable<Board>> GetBoards();
        Task<IEnumerable<Case>> GetCases();
        Task<IEnumerable<Cooling>> GetCooling();
        Task<IEnumerable<CPU>> GetCPUs();
        Task<IEnumerable<GPU>> GetGPUs();
        Task<IEnumerable<PSU>> GetPSUs();
        Task<IEnumerable<RAM>> GetRAMs();
        Task<IEnumerable<Storage>> GetStorages(); 
    }
}
