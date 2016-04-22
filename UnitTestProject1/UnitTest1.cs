using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using food;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {

       
        [TestMethod]
        public void TestMethod1()
        {
            var order = new Order();
            var meal = new Meal("Milk");
            
            order.addMeal(meal);

            Assert.Equals(meal, order);

            
        }
    }
}
