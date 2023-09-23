using CustomerWork;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomerWork
{

    internal class Order
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<Item> Items { get; set; }
        public double TotalPrice
        {
            get
            {
                return Items.Sum(item => item.Price);
            }
        }

    }

    public class Item
    {
        public int ItemId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public ItemSize Size { get; set; }
    }

    public class ItemSize
    {
        public ItemSize(object value1, object value2, object value3)
        {
            Value1 = value1;
            Value2 = value2;
            Value3 = value3;
        }

        public double Height { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public object Value1 { get; }
        public object Value2 { get; }
        public object Value3 { get; }
    }

}