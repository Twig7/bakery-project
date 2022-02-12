using System.Collections.Generic;
using System;

using ProgramSpace;

namespace BakeryFun
{
  public class Bread
  {
    public int BreadOrder { get; set;}

    public Bread(int order)
    {
      BreadOrder = order;
    }
    public int OrderTotal()
    {
      if (BreadOrder % 3 == 0)
      {
        int totalAmount = (BreadOrder - (BreadOrder / 3)) * 5;
        return totalAmount;
      }
    }
  }
}

