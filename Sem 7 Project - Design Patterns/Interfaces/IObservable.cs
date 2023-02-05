using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sem_7_Project___Design_Patterns.Interfaces
{
    public interface IObservable
    {
        void addObserver(IObserver observer);
        void notify();
    }
}
