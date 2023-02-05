using Sem_7_Project___Design_Patterns.Classes;
using Sem_7_Project___Design_Patterns.Interfaces;
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
    public partial class Cart : Form,IObserver
    {
        private List<Pizza> orderedPizzas;
        private CartData cartData;
        public Cart(CartData cartData)
        {
            InitializeComponent();
            this.cartData = cartData;
            dgvCart.DataSource=orderedPizzas;
        }

        public void update()
        {
            this.orderedPizzas = cartData.OrderedPizzas;
            dgvCart.DataSource = null;
            dgvCart.DataSource = orderedPizzas;
        }

        private void Cart_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your total is " + cartData.Total + "$", "Checkout", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cartData.clearCart();
        }
    }
}
