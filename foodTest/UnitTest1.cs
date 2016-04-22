using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using food;
using System.Collections.Generic;

namespace foodTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var meal = new Meal("Milk");
            Assert.AreEqual("Milk", meal.name);
        }
        [TestMethod]
        public void TestOrder()
        {
            var order1 = new Order();
            List<Meal> meal = new List<Meal>();
            meal.Add(new Meal("Milk"));

            Assert.AreEqual(meal.ToArray(),order1.orders.ToArray());
        }
        [TestMethod]
        public void TestMenu()
        {
            var menu = new Menu();

            Assert.IsTrue(menu.meals.Count > 1);
        }
    }
}
