using CustomerWork_V2;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerWork
{
    public class Item : ICostCalculate, IDeliveryCalculatable
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public ItemSize Size { get; set; }

        public Item(int itemId, string name, string price, ItemSize size)
        {
            ItemId = itemId;
            Name = name;
            Price = price;
            Size = size;
        }

        public double CalculateTotalCost()
        {
            if (double.TryParse(Price, out double price))
            {
                return price;
            }
            else
            {
                return 0.0;
            }

        }

        public double CalculateDeliveryCost()
        {
            double volume = Size.Width * Size.Height * Size.Depth;
            double deliveryCost = volume * 0.01; 

            return deliveryCost;
        }
    }
}
