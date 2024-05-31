using PcPriceTracker.Domain.Primitives;

namespace PcPriceTracker.Domain.Abstractions
{
    public class ComponenentEntity<TEntity> : Entity
    {
        public TypedID<TEntity> ID { get; init; }
        public string Manufacturer { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string Seller { get; set; } = string.Empty;

        public ComponenentEntity() => ID = new TypedID<TEntity>();
    }
}
