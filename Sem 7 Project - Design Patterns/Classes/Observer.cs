using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Classes
{
    public abstract class Observer
    {
        //private Observable_CurrencyRate currencyRateObservable;


        public abstract void update(double rate);
    }
}
