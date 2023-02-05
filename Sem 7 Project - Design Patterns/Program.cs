using Sem_7_Project___Design_Patterns.Classes;
using Sem_7_Project___Design_Patterns.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem_7_Project___Design_Patterns
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LoadingForm());

            CartData cartData = new CartData();
            Cart cart = new Cart(cartData);

            cartData.addObserver(cart);

            //Pizza pizza = new NYStylePepperoniPizza();
            //pizza = new PineapplePizzaDecorator(pizza);
            //pizza = new BaconPizzaDecorator(pizza);
            //double cost = pizza.Cost;

            PizzaTypeForm pizzaTypeForm = new PizzaTypeForm(cartData,cart);
            Application.Run(pizzaTypeForm);


        }
    }
}
