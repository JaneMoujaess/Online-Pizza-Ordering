using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Classes
{
    public class Observable_DollarRate : Observable_CurrencyRate
    {
        private List<Observer> observers;
        private double rate;

        public Observable_DollarRate()
        {
            observers = new List<Observer>();
        }
        public double Rate
        {
            set
            {
                rate = value;
                notify();
            }
            get { return rate; }
        }

        public override void add(Observer observer)
        {
            observers.Add(observer);
        }

        public override void notify()
        {
            foreach (Observer observer in observers)
            {
                observer.update(rate);
            }
        }
    }
}
