using System.Collections.Generic;
using System;

namespace Bakery.Models
{
    public class Pastry
    {
        public int Order { get; set; }
        public Pastry(int howMany)
        {
            Order = howMany;
        }
        public int OrderCalculate(int howMany)
        {
            int calculated = 2 * howMany;
            return calculated;
        }
    }
}