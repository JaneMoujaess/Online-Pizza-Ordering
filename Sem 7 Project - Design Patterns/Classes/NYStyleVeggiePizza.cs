using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Classes
{
	//Concrete pizza product
    public class NYStyleVeggiePizza:Pizza
    {
		public NYStyleVeggiePizza()
		{
			Description = "NY Style Veggie Pizza";
			Dough = "Thin Crust Dough";
			Sauce = "Marinara Sauce";
			Cheese = "Mozzarella Cheese";

			DefaultToppings.Add("Mushrooms");
			DefaultToppings.Add("Green Bell Peppers");
			DefaultToppings.Add("Diced Tomatoes");
			DefaultToppings.Add("Black Olives");

			Cost = 12;
		}
	}
}
