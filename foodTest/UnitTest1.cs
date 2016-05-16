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
        public void TestMealTitle()
        {
            var meal = new Meal("Milk");

            Assert.AreEqual("Milk", meal.GetTitle());
        }

        [TestMethod]
        public void TestOrderAdd1()
        {
            var order = new Order();
            List<Meal> meal = new List<Meal>();

            meal.Add(new Meal("Milk"));
            order.AddMeal("Milk");

            Assert.IsTrue(EqualsList(meal,order.orders));
        }

        [TestMethod]
        public void TestOrderAddMany()
        {
            var order = new Order();
            List<Meal> meal = new List<Meal>();

            order.AddMeal("Milk",5);
            for (int i = 0; i < 5; i++)
            {
                meal.Add(new Meal("Milk"));
            }

            Assert.IsTrue(EqualsList(meal, order.orders));
        }

        [TestMethod]
        public void TestMenuIsNull()
        {
            var menu = new Menu();

            Assert.IsFalse(menu.meals==null);
        }

        [TestMethod]
        public void TestMenuCount()
        {
            var menu = new Menu();

            Assert.IsTrue(menu.meals.Count >= 10);
        }

          [TestMethod]
          [ExpectedExceptionAttribute(typeof(ArgumentOutOfRangeException))]
        public void TestOrderInMenu()
        {
            Order order = new Order();
            order.AddMeal("Bla-bla");
          }

        [TestMethod]
        public void TestMenuList()
        {
            var menu = new Menu();
            
            Assert.IsTrue(menu.list() is List<Meal>);
        }
        public bool EqualsList(List<Meal> l1,List<Meal> l2) 
        {
            
            int i=0;
            while ((i< l2.Count)&&(l1[i].name == l2[i].name))
            {
                i++;
            }
            if (i == l1.Count && i == l2.Count)
            {
                return true;
            }
            else 
            {
                return false;
            }
            
        }
    }
}
