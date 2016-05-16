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
            
            
        }

        public void AddMeal(String meal) 
        {
            if (InMenu(meal))
            {
                this.orders.Add(new Meal(meal));
            }
            else throw new ArgumentOutOfRangeException(); 
          }
        public void AddMeal(String meal, int count)
        {
            if (InMenu(meal))
            {
                for (int i = 1; i <= count; i++)
                {
                    this.orders.Add(new Meal(meal));
                }
            }
            else throw new ArgumentOutOfRangeException(); 
            
        }

        public bool InMenu(String meal) 
        {
            Menu menu=new Menu();
            Meal Meal = new Meal(meal);
            for(int i=0;i<menu.meals.Count;i++)
            {
                if (menu.meals[i].name == Meal.name) return true;
            }
            return false;
        }
    }
}
