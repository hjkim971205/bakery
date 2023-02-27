using System.Collections.Generic;
using System;

namespace Bakery.Models
{
  public class Bread
  {
    public int Order { get; set; }
    public Bread(int howMany)
    {
      Order = howMany;
    }
    public int OrderCalculate(int howMany)
    {
        int calculated = 5*howMany;
        return calculated;
    }
  }
}