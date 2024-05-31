using PcPriceTracker.Domain.Entities;

namespace PcPriceTracker.Infrastructure.DB.Configurations
{
    public class CaseConfiguration : EntityConfiguration<Case> { }
    public class CoolingConfiguration : EntityConfiguration<Cooling> { }
    public class CpuConfiguration : EntityConfiguration<CPU> { }
    public class GpuConfiguration : EntityConfiguration<GPU> { }
    public class MainboardConfiguration : EntityConfiguration<Board> { }
    public class PSUConfiguration : EntityConfiguration<PSU> { }
    public class RAMConfiguration : EntityConfiguration<RAM> { }
    public class StorageConfiguration : EntityConfiguration<Storage> { }

}
