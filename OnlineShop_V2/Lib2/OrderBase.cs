using System;

namespace Lib2
{
    public abstract partial class OrderBase
    {
        public int OrderId { get; set; }
        public decimal Discount { get; set; }
    }

    public abstract partial class ItemBase
    {
        public int ItemId { get; set; }
        public decimal Discount { get; set; }
        public object Model { get; set; }
    }

    public class Phone : ItemBase
    {
        public string Model { get; set; }
    }

    public class Laptop : ItemBase
    {
        public string Model { get; set; }
    }

    public class Headphones : ItemBase
    {
        public string Model { get; set; }
    }

    public class Keyboard : ItemBase
    {
        public string Model { get; set; }
    }

    public class Mouse : ItemBase
    {
        public string Model { get; set; }
    }

    public class Order : OrderBase
    {
        private List<ItemBase> items = new List<ItemBase>();

        public void AddItem(ItemBase item)
        {
            items.Add(item);
        }

        public decimal GetTotalDiscount()
        {
            decimal totalDiscount = 0;

            foreach (var item in items)
            {
                if (item != null)
                {
                    totalDiscount += item.Discount;
                }
            }

            return totalDiscount;
        }
    }
}