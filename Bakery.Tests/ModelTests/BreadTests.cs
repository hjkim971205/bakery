using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic; 
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
  [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      int order = 1;
      Bread whiteBread = new Bread(order);
      Assert.AreEqual(typeof(Bread), whiteBread.GetType());
    }
  }
}