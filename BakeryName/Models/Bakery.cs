using System.Collections.Generic;
using System;
using Bakery.Logic;

namespace BakeryFun
{
  public class Bread
  {
    public int LoafAmount { get; set;}
    public int LoafCost {get; set;}

    public Bread(int loafAmount)
    {
      LoafAmount = loafAmount;
      LoafCost = this.CalculateTotal();
    }
    public int CalculateTotal()
    {
      if (LoafAmount >= 3)
      {
        int discountLoaves = (LoafAmount - (LoafAmount / 3));
        return discountLoaves *5;
      }
      else
      {
        return LoafAmount *5;
      }
    }
  }
}


