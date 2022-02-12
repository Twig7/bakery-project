using System;
using System.Collections.Generic;
using Bakery.Logic;

namespace BakeryFun 
{
  public class Pastry
  {
    public int NumberOfPastries { get; set;}
    public int PastryCost {get; set;}

    public Pastry(int numberOfPastries)
    {
      NumberOfPastries = numberOfPastries;
      PastryCost = this.CalculateTotal();
    }
    public int CalculateTotal()
    {
      if (NumberOfPastries >= 3)
      {
        int discountPastry = NumberOfPastries / 3;
        int leftovers = NumberOfPastries - discountPastry;
        return discountPastry * 1 + leftovers * 2;
      }
      else
      {
        return NumberOfPastries *2;
      }
    }
  }
  
