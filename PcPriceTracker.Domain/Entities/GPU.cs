using PcPriceTracker.Domain.Abstractions;

namespace PcPriceTracker.Domain.Entities
{
    public class GPU : ComponenentEntity<GPU>
    {
        public string Frequency { get; set; } = string.Empty;
        public int ShaderUnits { get; set; } = 0;
        public string VRAM { get; set; } = string.Empty;
        public GPU() : base() { }
        public GPU(string manufacturer, string type, decimal price, string seller, string frequency, int shader, string ram)
            : base()
        {
            Manufacturer = manufacturer;
            Type = type;
            Price = price;
            Seller = seller;
            Frequency = frequency;
            ShaderUnits = shader;
            VRAM = ram;
        }
    }
}
