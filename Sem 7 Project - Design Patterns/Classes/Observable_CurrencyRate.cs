using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Classes
{
    public abstract class Observable_CurrencyRate
    {
        public abstract void add(Observer observer);

        public abstract void notify();
    }
}
