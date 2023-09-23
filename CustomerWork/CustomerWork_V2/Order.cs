using CustomerWork;
using CustomerWork_V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Collections.Generic;
using System.Linq;

namespace CustomerWork
{
    public class Order : ICostCalculate
    {
        public int OrderId { get; set; }
        public Customer Customer { get; set; }
        public List<Item> Items { get; set; }

        public Order(int orderId, Customer customer, List<Item> items)
        {
            OrderId = orderId;
            Customer = customer;
            Items = items;
        }

        public double CalculateTotalCost()
        {
            double totalCost = Items.Sum(item => item.CalculateTotalCost());
            return totalCost;
        }
    }
}
