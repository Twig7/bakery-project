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
      Console.WriteLine($"Dang, {loaves} loaves, huh? ...you sure? Ok, ok, what about pastries? How many do you want?");
      int pastries = int.Parse(Console.ReadLine());
      Console.WriteLine($"Ok, so that'll be {loaves} loaves and {pastries} pastries!")
      Console.WriteLine($"Your total today is ${loafOrder.OrderTotal() +pastrieOrder.OrderTotal()} Don't say I didn't warn you!");
    }
  }
  }
}