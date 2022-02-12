using System;
using System.Collections.Generic;
using BakeryFun

namespace ProgramSpace
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Welcome to Ella's Bakery! We've got fresh bread and pastries for sale today!");
      Console.WriteLine("One loaf is bread is $5, or get two for $10 and get one free!");
      Console.WriteLine("Or try one of our delicious pastires!");
      Console.WriteLine("One for $2 or 3 for $5!");
      Console.WriteLine("How many loaves for ya?");
      int loaves = int.Parse(Console.ReadLine());
    }
  }
  }
}