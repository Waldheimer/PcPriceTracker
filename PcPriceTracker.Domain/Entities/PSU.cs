using PcPriceTracker.Domain.Abstractions;

namespace PcPriceTracker.Domain.Entities
{
    public class PSU : ComponenentEntity<PSU>
    {
        public string Power { get; set; } = string.Empty;
        public string Modularity { get; set; } = string.Empty;
        public PSU() : base() { }
        public PSU(string manufacturer, string type, decimal price, string seller, string power, string modularity)
            : base()
        {
            Manufacturer = manufacturer;
            Type = type;
            Price = price;
            Seller = seller;
            Power = power;
            Modularity = modularity;
        }
    }
}
