using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Classes
{
    //Concrete pizza factory that creates Chicago style pizza products.
    public class ChicagoStylePizzaFactory:PizzaFactory
    {
        public override Pizza createPizza(String item)
        {
            if (item=="chicken")
            {
                return new ChicagoStyleChickenPizza();
            }
            else if (item=="veggie")
            {
                return new ChicagoStyleVeggiePizza();
            }
            else if (item=="pepperoni")
            {
                return new ChicagoStylePepperoniPizza();
            }
            else return null;
        }
    }
}
