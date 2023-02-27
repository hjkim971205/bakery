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
      Bread whiteBread = new Bread(3,4,5);
      Assert.AreEqual(typeof(Bread), whiteBread.GetType());
    }
  }
}