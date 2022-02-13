using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Logic;
using BakeryFun;
using System;
using System.Collections.Generic;

namespace Bakery.Tests 
{
  [TestClass]
  public class BakeryTests
  {
    [TestMethod]
    public void BreadConstructor_CreateInstancesOfBread_Bread()
    {
      Bread newBread = new Bread(2);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }
    [TestMethod]
    public void GetNumberOfPastries_ReturnNumberOfPastries_Int()
    {
      Pastry newPastry = new Pastry(3);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }
  }
}


