using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Classes
{
    //Concrete pizza product
    public class ChicagoStylePepperoniPizza:Pizza
    {
		public ChicagoStylePepperoniPizza()
		{
			Description = "Chicago Style Pepperoni Pizza";
			Dough = "Extra Thick Crust Dough";
			Sauce = "Plum Tomato Sauce";
			Cheese = "Mozarella Cheese";

			DefaultToppings.Add("Sliced Pepperoni");

			Cost = 18;
		}

        new void cut()
		{
			Console.WriteLine("Cutting the pizza into square slices");
		}
	}
}
