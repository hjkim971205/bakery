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
            Bread breadLoaf = new Bread(order);
            Assert.AreEqual(typeof(Bread), breadLoaf.GetType());
        }
        [TestMethod]
        public void GetBreadOrder_SetValueOfBreadOrder_Int()
        {
            int howMany = 1;
            Bread breadLoaf = new Bread(howMany);
            breadLoaf.Order = howMany;
            Assert.AreEqual(howMany, breadLoaf.Order);
        }
        [TestMethod]
        public void GetOrder_SetsValueOrder_Int()
        {
            int howMany = 2;
            int calculated = 5 * howMany;
            Bread breadLoaf = new Bread(howMany);
            int breadCost = breadLoaf.OrderCalculate(howMany);
            Assert.AreEqual(calculated, breadCost);
        }
        [TestMethod]
        public void CalculateDiscount_WithThreeLoavesOfBread_DiscountsOrder()
        {
            int howMany = 3;
            Bread breadLoaf = new Bread(howMany);
            breadLoaf.CalculateDiscount(); 
            int expectedDiscount = 5;
            Assert.AreEqual(expectedDiscount, breadLoaf.OrderDiscount);
        }
    }
}