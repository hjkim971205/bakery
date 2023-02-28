using System.Collections.Generic;
using System;

namespace Bakery.Models
{
    public class Pastry
    {
        public int Order { get; set; }
        public int OrderCost { get; set; }
        public int OrderDiscount { get; set; }
        public Pastry(int howMany)
        {
            Order = howMany;
            OrderCost = OrderCalculate(howMany);
            CalculateDiscount();
        }
        public int OrderCalculate(int howMany)
        {
            int calculated = 2 * howMany;
            return calculated;
        }
        public void CalculateDiscount()
        {
            if (Order >= 3)
            {
                int freePastries = Order / 3;
                OrderDiscount = freePastries * 2;
                OrderCost -= OrderDiscount;
            }
        }
    }
}