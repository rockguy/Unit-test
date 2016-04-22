using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food
{
    public class Order
    {
        public List<Meal> orders = new List<Meal>();
        public Order() {
            orders.Add(new Meal("Milk"));
            
        }

        public void addMeal(Meal meal) 
        {
            this.orders.Add(meal);
        }
        public void addMeal(Meal meal, int count)
        {
            for (int i = 1; i <= count; i++) 
            {
                orders.Add(meal);
            }
        }
    }
}
