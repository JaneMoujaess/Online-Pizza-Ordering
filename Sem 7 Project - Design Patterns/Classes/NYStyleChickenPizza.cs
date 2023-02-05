using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Classes
{
	//Concrete pizza product
    public class NYStyleChickenPizza:Pizza
    {
		public NYStyleChickenPizza()
		{
			Description = "NY Style BBQ Chicken Pizza";
			Dough = "Thin Crust Dough";
			Sauce = "BBQ Sauce";
			Cheese = "Mozarella Cheese";

			DefaultToppings.Add("Grilled Chicken Breast");
			DefaultToppings.Add("Sliced Onions");

			Cost = 18;
		}
	}
}
