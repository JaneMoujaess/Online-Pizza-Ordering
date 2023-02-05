using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Classes
{
	//Concrete pizza product
    public class NYStylePepperoniPizza:Pizza
    {
		public NYStylePepperoniPizza()
		{
			Description = "NY Style Pepperoni Pizza";
			Dough = "Thin Crust Dough";
			Sauce = "Marinara Sauce";
			Cheese = "Mozzarella Cheese";

			DefaultToppings.Add("Sliced Pepperoni");

			Cost = 16;
		}
	}
}
