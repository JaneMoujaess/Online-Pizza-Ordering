using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Classes
{
    public class PineapplePizzaDecorator : PizzaDecorator
    {
        Pizza pizza;
        public PineapplePizzaDecorator(Pizza pizza):base(pizza)
        {
            //this.pizza = pizza;
            //Cheese = pizza.Cheese;
            //Dough = pizza.Dough;
            //Sauce = pizza.Sauce;
            //DefaultToppings = pizza.DefaultToppings;
            //Description = Description+", Pineapple";
            //Cost = Cost+3;
            setDescription("Pineapple");
            setCost(3);
        }
        //public override string Description
        //{
        //    //set { pizza.Description = pizza.Description + value; }
        //    get { return pizza.Description + ", Pineapple"; }
        //}
        //public override double Cost 
        //{
        //    //set { pizza.Cost = pizza.Cost + 2; }
        //    get { return pizza.Cost + 2; }
        //}

        //public override void setDescription(string desc)
        //{
        //    Description = pizza.Description + desc;
        //}
        //public override void setCost(double cost)
        //{
        //    Cost = pizza.Cost + cost;
        //}
    }
}
