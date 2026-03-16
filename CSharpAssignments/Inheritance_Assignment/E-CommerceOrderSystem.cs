using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerceOrderSystem
{
    public class Order
    {
        public int OrderId { get; set; }
        public double OrderAmount { get; set; }

        public Order(int id, double amount)
        {
            OrderId = id;
            OrderAmount = amount;
        }

        public virtual int CalculateShippingCost()
        {
            return 50;
        }
    }

    public class StandardOrder : Order
    {
        public StandardOrder(int id, double amount) : base(id, amount) { }

        public override int CalculateShippingCost()
        {
            return 50;
        }
    }

    public class ExpressOrder : Order
    {
        public ExpressOrder(int id, double amount) : base(id, amount) { }

        public override int CalculateShippingCost()
        {
            return 100;
        }
    }

    public class InternationalOrder : Order
    {
        public InternationalOrder(int id, double amount) : base(id, amount) { }

        public override int CalculateShippingCost()
        {
            return 500;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Order> orders = new List<Order>()
            {
                new StandardOrder(1,1000),
                new ExpressOrder(2,2000),
                new InternationalOrder(3,3000)
            };

            foreach (Order o in orders)
            {
                Console.WriteLine("Order " + o.OrderId + " Shipping Cost: " + o.CalculateShippingCost());
            }
        }
    }
}