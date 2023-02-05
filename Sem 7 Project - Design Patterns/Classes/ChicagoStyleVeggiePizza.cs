using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Classes
{
    //Concrete pizza product
    public class ChicagoStyleVeggiePizza:Pizza
    {
		public ChicagoStyleVeggiePizza()
		{
			Description = "Chicago Style Veggie Pizza";
			Dough = "Extra Thick Crust Dough";
			Sauce = "Plum Tomato Sauce";
			Cheese = "Gouda Cheese";

			DefaultToppings.Add("Mushrooms");
			DefaultToppings.Add("Artichokes");
			DefaultToppings.Add("Diced Tomatoes");
			DefaultToppings.Add("Rosemary");
			DefaultToppings.Add("Ranch Dressing");

			Cost = 15;
		}

        new void cut()
		{
			Console.WriteLine("Cutting the pizza into square slices");
		}
	}
}
