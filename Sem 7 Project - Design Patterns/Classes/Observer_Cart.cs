using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Classes
{
    public class Observer_Cart:Observer
    {
        private List<Pizza> orderedPizzas = new List<Pizza>();
        private double totalPriceUSD;
        private double totalPriceLBP;
        private Observable_DollarRate dollarRate;

        public Observer_Cart(Observable_DollarRate dollarRate) { }

        public double TotalPriceUSD
        {
            get
            {
                totalPriceUSD = 0;
                foreach(Pizza orderedPizza in orderedPizzas)
                {
                    totalPriceUSD += orderedPizza.Cost;
                }
                return totalPriceUSD;
            }
        }

        public double TotalPriceLBP
        {
            get
            {
                return totalPriceUSD * dollarRate.Rate;
            }
        }

        public override void update(double dollarRate)
        {
            this.dollarRate.Rate = dollarRate;
        }
    }
}
