using PcPriceTracker.Domain.Abstractions;
using PcPriceTracker.Domain.Entities;
using PcPriceTracker.Domain.Primitives;

namespace PcPriceTracker.Application.ServiceContracts
{
    public interface IDataService
    {
        //  C R E A T E
        Task<DataResult<TypedID<CPU>>> NewCPU(CPU cpu);

        //  R E A D
        Task<DataResult<IEnumerable<CPU>?>> GetCPUs();
        Task<DataResult<IEnumerable<Board>?>> GetBoards();
        Task<DataResult<IEnumerable<GPU>?>> GetGPUs();
        Task<DataResult<IEnumerable<Case>?>> GetCases();
        Task<DataResult<IEnumerable<Cooling>?>> GetCoolings();
        Task<DataResult<IEnumerable<PSU>?>> GetPSUs();
        Task<DataResult<IEnumerable<RAM>?>> GetRAMs();
        Task<DataResult<IEnumerable<Storage>?>> GetSSDs();
    }
}
