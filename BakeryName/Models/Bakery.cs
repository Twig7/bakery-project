using System.Collections.Generic;
using System;
using Bakery.Logic;

namespace BakeryFun
{
  public class Bread
  {
    public int LoafAmount { get; set;}
    public int LoafCost {get; set;}

    public Bread(int numberOfLoaves)
    {
      NumberOfLoaves = numberOfLoaves)
      LoafCost = this.CalculateTotal();
    }
    public int CalculateTotal()
    {
      if (NumberOfLoaves >= 3)
      {
        int discountLoaves = (NumberOfLoaves - (NumberOfLoaves / 3));
        return discountLoaves *5;
      }
      else
      {
        return NumberOfLoaves *5;
      }
    }
  }
}


