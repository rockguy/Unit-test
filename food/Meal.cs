using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace food
{
    public class Meal
    {
        public String name;
   
        public Meal(String name) 
        {
            this.name = name;
            
            
        }
        public string GetTitle() 
        {
            return name;
        }
    }
}
