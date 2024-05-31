using PcPriceTracker.Domain.Abstractions;

namespace PcPriceTracker.Domain.Entities
{
    public class Storage : ComponenentEntity<Storage>
    {
        public string StorageFormat { get; set; } = string.Empty;
        public string Capacity { get; set; } = string.Empty;
        public Storage() : base() { }
        public Storage(string manufacturer, string type, decimal price, string seller, string format, string capacity)
            : base()
        {
            Manufacturer = manufacturer;
            Type = type;
            Price = price;
            Seller = seller;
            StorageFormat = format;
            Capacity = capacity;
        }
    }
}
