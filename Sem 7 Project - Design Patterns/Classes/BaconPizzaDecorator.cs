using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Classes
{
    public class BaconPizzaDecorator : PizzaDecorator
    {
        Pizza pizza;
        public BaconPizzaDecorator(Pizza pizza):base(pizza)
        {
            setDescription("Bacon");
            setCost(5.5);
        }

        //public override string Description 
        //{
        //    //set { pizza.Description = pizza.Description + ", Bacon"; }
        //    get { return pizza.Description + ", Bacon"; }
        //}
        //public override double Cost
        //{
        //    //set { pizza.Cost = pizza.Cost + 5; }
        //    get { return pizza.Cost + 5; }
        //}
    }
}
