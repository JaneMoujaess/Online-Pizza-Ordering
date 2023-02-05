using Sem_7_Project___Design_Patterns.Classes;
using Sem_7_Project___Design_Patterns.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem_7_Project___Design_Patterns
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();

				//PizzaFactory nyFactory = new NYStylePizzaFactory();
				//PizzaFactory chicagoFactory = new ChicagoStylePizzaFactory();

				//Pizza pizza = nyFactory.orderPizza("cheese");
				//Console.WriteLine("Ethan ordered a " + pizza.Description + "\n");

				//pizza = chicagoFactory.orderPizza("veggie");
				//Console.WriteLine("Joel ordered a " + pizza.Description + "\n");
			
		}

        private void timer_Tick(object sender, EventArgs e)
        {
            CartData cartData = new CartData();
            if (progressBar.Value == progressBar.Maximum)
            {
                timer.Enabled = false;
                this.Hide();
                //PizzaTypeForm pizzaTypeForm = new PizzaTypeForm(cartData);
                //pizzaTypeForm.Show();
            }

            else
                progressBar.Value += 1;
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timer.Interval = 50;
            timer.Start();
            progressBar.Maximum = 50;
        }
    }
}
