using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Classes
{
	//Concrete pizza product
    public class ChicagoStyleChickenPizza:Pizza
    {
		public ChicagoStyleChickenPizza()
		{

			Description = "Chicago Style Chicken Supreme Pizza";
			Dough = "Extra Thick Crust Dough";
			Sauce = "Alfredo Sauce";
			Cheese = "Gruyère Cheese";

			DefaultToppings.Add("Grilled Chicken Breast");
			DefaultToppings.Add("Sliced Onions");
			DefaultToppings.Add("Green Bell Peppers");

			Cost = 20;
		}

		public new void cut()
		{
			Console.WriteLine("Cutting the pizza into square slices");
		}
	}
}
