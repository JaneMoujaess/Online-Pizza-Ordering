using Sem_7_Project___Design_Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Classes
{
    public class CartData : IObservable
    {
        private List<Pizza> orderedPizzas;
        private double total;

        private List<IObserver> observers;

        public CartData()
        {
            observers = new List<IObserver>();
            orderedPizzas = new List<Pizza>();
        }
        public double Total
        {
            get
            {
                total = 0;
                foreach (Pizza orderedPizza in orderedPizzas)
                    total += orderedPizza.Cost;
                return total;
            }
        }

        public void addToCart(Pizza newOrderedPizza)
        {
            orderedPizzas.Add(newOrderedPizza);
            notify();
        }

        public void clearCart()
        {
            orderedPizzas.Clear();
            notify();
        }

        public List<Pizza> OrderedPizzas
        {
            get
            {
                return orderedPizzas;
            }
        }

        public void addObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void notify()
        {
            foreach (IObserver observer in observers)
                observer.update();
        }
    }
}
