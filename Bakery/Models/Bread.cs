using System.Collections.Generic;
using System;

namespace Bakery.Models
{
    public class Bread
    {
        public int Order { get; set; }
        public int OrderCost { get; set; }
        public int OrderDiscount { get; set; }
        public Bread(int howMany)
        {
            Order = howMany;
        }
        public int OrderCalculate(int howMany)
        {
            int calculated = 5 * howMany;
            return calculated;
        }
        public void CalculateDiscount()
        {
            if (Order >= 3)
            {
                int discount = (Order / 3) * 5;
                OrderDiscount = discount;
            }
        }
    }
}