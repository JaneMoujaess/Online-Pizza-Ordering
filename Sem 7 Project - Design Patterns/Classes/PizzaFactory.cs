using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Classes
{
	//Abstract pizza factory
    public abstract class PizzaFactory
    {
		public abstract Pizza createPizza(String item);

		public Pizza orderPizza(String type)
		{
			Pizza pizza = createPizza(type);
			Console.WriteLine("--- Making a " + pizza.Description + " ---");
			pizza.prepare();
			pizza.bake();
			pizza.cut();
			pizza.box();
			return pizza;
		}
	}
}
