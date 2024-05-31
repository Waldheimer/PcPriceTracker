using PcPriceTracker.Domain.Abstractions;

namespace PcPriceTracker.Domain.Entities
{
    public class CPU : ComponenentEntity<CPU>
    {
        public string Socket { get; set; } = string.Empty;
        public int Cores { get; set; } = 0;
        public string Frequency { get; set; } = string.Empty;
        public string Turbo { get; set; } = string.Empty;

        public CPU() : base() { }
        public CPU(string manufacturer, string type, decimal price, string seller, string socket, int cores, string frequency, string turbo)
            : base()
        {
            Manufacturer = manufacturer;
            Type = type;
            Price = price;
            Seller = seller;
            Socket = socket;
            Cores = cores;
            Frequency = frequency;
            Turbo = turbo;
        }
    }
}
