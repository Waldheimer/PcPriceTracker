using Microsoft.EntityFrameworkCore;
using PcPriceTracker.Application.ServiceContracts;
using PcPriceTracker.DB;
using PcPriceTracker.Domain.Abstractions;
using PcPriceTracker.Domain.Entities;
using PcPriceTracker.Domain.Primitives;

namespace PcPriceTracker.Infrastructure.Services
{
    public class PostgresDataService : IDataService
    {
        private readonly AppDbContext ctx;

        public PostgresDataService(AppDbContext ctx)
        {
            this.ctx = ctx;
        }

        public async Task<DataResult<IEnumerable<Board>?>> GetBoards()
        {
            var data = await ctx.Mainboards.AsNoTracking().ToListAsync();
            if(data == null)
            {
                return new(null, false, new DataError(DataErrorCode.NullValue,"Error retrieving Data"));
            }
            if(data.Count() == 0)
            {
                return new(data, false, new DataError(DataErrorCode.EmptyResult, "No Boards found in Database"));
            }
            return new(data, true, DataError.None);
        }

        public Task<DataResult<IEnumerable<Case>?>> GetCases()
        {
            throw new NotImplementedException();
        }

        public Task<DataResult<IEnumerable<Cooling>?>> GetCoolings()
        {
            throw new NotImplementedException();
        }

        public Task<DataResult<IEnumerable<CPU>?>> GetCPUs()
        {
            throw new NotImplementedException();
        }

        public Task<DataResult<IEnumerable<GPU>?>> GetGPUs()
        {
            throw new NotImplementedException();
        }

        public Task<DataResult<IEnumerable<PSU>?>> GetPSUs()
        {
            throw new NotImplementedException();
        }

        public Task<DataResult<IEnumerable<RAM>?>> GetRAMs()
        {
            throw new NotImplementedException();
        }

        public Task<DataResult<IEnumerable<Storage>?>> GetSSDs()
        {
            throw new NotImplementedException();
        }

        public Task<DataResult<TypedID<CPU>>> NewCPU(CPU cpu)
        {
            throw new NotImplementedException();
        }
    }
}
