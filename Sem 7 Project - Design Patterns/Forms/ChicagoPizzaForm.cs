using Sem_7_Project___Design_Patterns.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem_7_Project___Design_Patterns.Forms
{
    public partial class ChicagoPizzaForm : Form
    {
        CartData cartData;
        public ChicagoPizzaForm(CartData cartData)
        {
            InitializeComponent();
            this.cartData = cartData;
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            ChicagoStylePizzaFactory chicagoStylePizzaFactory = new ChicagoStylePizzaFactory();
            Pizza pizza;

            if (rdbtnPepperoni.Checked == true)
                pizza = chicagoStylePizzaFactory.createPizza("pepperoni");
            else if (rdbtnChickenSupreme.Checked == true)
                pizza = chicagoStylePizzaFactory.createPizza("chicken");
            else if (rdbtnVeggie.Checked == true)
                pizza = chicagoStylePizzaFactory.createPizza("veggie");
            else
            {
                MessageBox.Show("Please select a pizza.", "No pizza selected.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (checkboxPineapple.Checked == true)
                pizza = new PineapplePizzaDecorator(pizza);
            if (checkboxHam.Checked == true)
                pizza = new HamPizzaDecorator(pizza);
            if (checkboxBacon.Checked == true)
                pizza = new BaconPizzaDecorator(pizza);

            cartData.addToCart(pizza);
            MessageBox.Show("Succesfully added to cart.", "Order processed successfully.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (Control control in this.Controls)
            {
                if (control is Panel)
                {
                    foreach (Control ctrl in control.Controls)
                    {
                        if (ctrl is Guna.UI2.WinForms.Guna2CustomCheckBox box && box.Checked)
                            box.Checked = false;
                        if (ctrl is Guna.UI2.WinForms.Guna2CustomRadioButton button && button.Checked == true)
                            button.Checked = false;
                    }

                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            //PizzaTypeForm pizzaTypeForm = new PizzaTypeForm(cartData);
            //pizzaTypeForm.Show();
        }
    }
}
