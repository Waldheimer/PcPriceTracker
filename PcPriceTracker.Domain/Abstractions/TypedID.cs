namespace PcPriceTracker.Domain.Abstractions
{
    public class TypedID<TEntity>
    {
        public Guid ID { get; set; }
        public TypedID()
        {
            ID = Guid.NewGuid();
        }
        public TypedID(Guid id)
        {
            ID = id;
        }
    }
}
