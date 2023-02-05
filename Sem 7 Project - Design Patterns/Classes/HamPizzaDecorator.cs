using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Classes
{
    public class HamPizzaDecorator:PizzaDecorator
    {
        Pizza pizza;
        public HamPizzaDecorator(Pizza pizza):base(pizza)
        {
            setDescription("Ham");
            setCost(5);
        }

        //public override string Description
        //{
        //    //set { pizza.Description = pizza.Description + ", Ham"; }
        //    get { return pizza.Description + ", Ham"; }
        //}
        //public override double Cost
        //{
        //    //set { pizza.Cost = pizza.Cost + 5; }
        //    get { return pizza.Cost + 5; }
        //}
    }
}
