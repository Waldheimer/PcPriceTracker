using PcPriceTracker.Domain.Abstractions;
using System.Net.Sockets;

namespace PcPriceTracker.Domain.Entities
{
    public class Cooling : ComponenentEntity<Cooling>
    {
        public string Size { get; set; } = string.Empty;
        public Cooling() : base() { }
        public Cooling(string manufacturer, string type, decimal price, string seller, string size)
            : base()
        {
            Manufacturer = manufacturer;
            Type = type;
            Price = price;
            Seller = seller;
            Size = size;
        }
    }
}
