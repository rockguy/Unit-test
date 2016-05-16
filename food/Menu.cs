using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food
{
    public class Menu
    {
        public List<Meal> meals=new List<Meal>();
        public Menu()
        {
            meals.Add(new Meal("Milk"));
            meals.Add(new Meal("Potato"));
            meals.Add(new Meal("Whiskey"));
            meals.Add(new Meal("Sushi"));
            meals.Add(new Meal("Tea"));
            meals.Add(new Meal("Coffe"));
            meals.Add(new Meal("Soup"));
            meals.Add(new Meal("Meat"));
            meals.Add(new Meal("Vine"));
            meals.Add(new Meal("Beer"));
 
        }
        public List<Meal> list() 
        {
            return meals;
        }

        public static void Main() {
            Console.Write("Bla-bla");
            Console.Read();
        }
    }
}
