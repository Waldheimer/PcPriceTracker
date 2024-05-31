using PcPriceTracker.Domain.Abstractions;

namespace PcPriceTracker.Domain.Entities
{
    public class RAM : ComponenentEntity<RAM>
    {
        public string Capacity { get; set; } = string.Empty;
        public string Frequency { get; set; } = string.Empty;
        public string Latency { get; set; } = string.Empty;
        public RAM() : base() { }
        public RAM(string manufacturer, string type, decimal price, string seller, string capacity, string frequency, string latency)
            : base()
        {
            Manufacturer = manufacturer;
            Type = type;
            Price = price;
            Seller = seller;
            Capacity = capacity;
            Frequency = frequency;
            Latency = latency;
        }
    }
}
