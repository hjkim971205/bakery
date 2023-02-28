using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
    [TestClass]
    public class PastryTests
    {
        [TestMethod]
        public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
        {
            int order = 1;
            Pastry PastryLoaf = new Pastry(order);
            Assert.AreEqual(typeof(Pastry), PastryLoaf.GetType());
        }
        [TestMethod]
        public void GetPastryOrder_SetValueOfPastryOrder_Int()
        {
            int howMany = 1;
            Pastry PastryLoaf = new Pastry(howMany);
            PastryLoaf.Order = howMany;
            Assert.AreEqual(howMany, PastryLoaf.Order);
        }
        [TestMethod]
        public void GetOrder_SetsValueOrder_Int()
        {
            int howMany = 2;
            int calculated = 2 * howMany;
            Pastry PastryLoaf = new Pastry(howMany);
            int PastryCost = PastryLoaf.OrderCalculate(howMany);
            Assert.AreEqual(calculated, PastryCost);
        }
        [TestMethod]
        public void CalculateDiscount_WithFourPastries_DiscountsOnePastry()
        {
            int howMany = 4;
            Pastry pastryLoaf = new Pastry(howMany);
            pastryLoaf.CalculateDiscount();
            int expectedCost = 6; 
            int actualCost = pastryLoaf.OrderCost;
            Assert.AreEqual(expectedCost, actualCost);
        }
    }
}