using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Classes
{
	//Abstract pizza product
    public abstract class Pizza
    {
		private string description;
		private string dough;
		private string sauce;
		private string cheese;
		List<string> defaultToppings = new List<String>();
		private double cost;

		public string Description
        {
            set { description = value; }
            get { return description; }
        }
		
		public string Dough
        {
            set { dough = value; }
            get { return dough; }
        }

		public string Sauce
        {
            set { sauce = value; }
            get { return sauce; }
        }
		
		public string Cheese
        {
            set { cheese = value; }
            get { return cheese; }
        }

		public List<string>	DefaultToppings
        {
            set { defaultToppings = value; }
            get { return defaultToppings; }
        }

		public double Cost
        {
            set { cost = value; }
            get { return cost; }
        }


		public void prepare()
		{
			Console.WriteLine("Prepare " + Description);
			Console.WriteLine("Tossing dough...");
			Console.WriteLine("Adding sauce...");
			Console.WriteLine("Adding toppings: ");
			foreach (string topping in defaultToppings)
			{
				Console.WriteLine("   " + topping);
			}
		}

		public void bake()
		{
			Console.WriteLine("Bake for 25 minutes at 350");
		}

		public void cut()
		{
			Console.WriteLine("Cut the pizza into diagonal slices");
		}

		public void box()
		{
			Console.WriteLine("Place pizza in official PizzaStore box");
		}

    }
}
