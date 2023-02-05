using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Classes
{
	//Concrete pizza factory that creates New York style pizza products.
    public class NYStylePizzaFactory:PizzaFactory
    {
		public override Pizza createPizza(String item)
		{
			if (item=="chicken")
			{
				return new NYStyleChickenPizza();
			}
			else if (item=="veggie")
			{
				return new NYStyleVeggiePizza();
			}
			else if (item=="pepperoni")
			{
				return new NYStylePepperoniPizza();
			}
			else return null;
		}
    }
}
