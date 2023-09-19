using System;

namespace Lib2
{
    public class OrderBase
    {
        public int OrderId { get; set; }
        public decimal Discount { get; set; }
    }

    public class ItemBase
    {
        public int ItemId { get; set; }
        public decimal Discount { get; set; }
    }
}