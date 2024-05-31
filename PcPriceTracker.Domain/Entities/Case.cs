using PcPriceTracker.Domain.Abstractions;
using System.Net.Sockets;

namespace PcPriceTracker.Domain.Entities
{
    public class Case : ComponenentEntity<Case>
    {
        public TowerType Size { get; set; }
        public Case() : base() { }
        public Case(string manufacturer, string type, decimal price, string seller, TowerType towerType)
            : base()
        {
            Manufacturer = manufacturer;
            Type = type;
            Price = price;
            Seller = seller;
            Size = towerType;
        }
    }
}
