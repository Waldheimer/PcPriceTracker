using PcPriceTracker.Domain.Abstractions;

namespace PcPriceTracker.Domain.Entities
{
    public class Board: ComponenentEntity<Board>
    {
        public string Socket { get; set; } = string.Empty;
        public BoardSize Size { get; set; }
        public Board() : base() { }
        public Board(string manufacturer, string type, decimal price, string seller, string socket, BoardSize size)
            : base()
        {
            Manufacturer = manufacturer;
            Type = type;
            Price = price;
            Seller = seller;
            Socket = socket;
            Size = size;
        }
    }
}
