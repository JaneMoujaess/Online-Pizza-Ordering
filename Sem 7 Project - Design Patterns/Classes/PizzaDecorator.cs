using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Classes
{
    //Abstract pizza decorator
    public abstract class PizzaDecorator:Pizza
    {
        Pizza pizza;

        public PizzaDecorator(Pizza pizza)
        {
            Dough = pizza.Dough;
            Cheese = pizza.Cheese;
            Sauce = pizza.Sauce;
            DefaultToppings = pizza.DefaultToppings;
            this.pizza = pizza;
        }

        public void setDescription(string desc)
        {
            Description = pizza.Description +", "+ desc;
        }

        public void setCost(double cost)
        {
            Cost = pizza.Cost + cost;
        }
    }
}
