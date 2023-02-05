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
    public partial class PizzaTypeForm : Form
    {
        CartData cartData;
        Cart cart;
        public PizzaTypeForm(CartData cartData,Cart cart)
        {
            InitializeComponent();
            this.cartData = cartData;
            this.cart = cart;
        }

        private void btnContinueNY_Click(object sender, EventArgs e)
        {
            NYPizzaForm nYPizzaForm = new NYPizzaForm(cartData);
            nYPizzaForm.Show();
        }

        private void btnContinueChicago_Click(object sender, EventArgs e)
        {
            ChicagoPizzaForm chicagoPizzaForm = new ChicagoPizzaForm(cartData);
            chicagoPizzaForm.Show();
        }

        private void btnCart_MouseEnter(object sender, EventArgs e)
        {
            btnCart.FillColor = Color.PeachPuff;
            btnCart.BorderThickness = 4;
            imgCart.BackColor = Color.PeachPuff;
           
        }

        private void btnCart_MouseLeave(object sender, EventArgs e)
        {
            btnCart.FillColor = Color.SeaShell;
            btnCart.BorderThickness = 2;
            imgCart.BackColor = Color.SeaShell;
        }

        private void imgCart_MouseEnter(object sender, EventArgs e)
        {
            btnCart.FillColor = Color.PeachPuff;
            btnCart.BorderThickness = 4;
            imgCart.BackColor = Color.PeachPuff;
        }

        private void imgCart_MouseLeave(object sender, EventArgs e)
        {
            btnCart.FillColor = Color.SeaShell;
            btnCart.BorderThickness = 2;
            imgCart.BackColor = Color.SeaShell;
        }

        private void imgCart_Click(object sender, EventArgs e)
        {
            cart.Show();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            cart.Show();
        }
    }
}
