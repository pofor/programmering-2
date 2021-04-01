using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observerreal
{
    interface ISubject
    {
        void Subscribe(Observer observer);
        void Unsubscribe(Observer observer);
        void Notify();
    }
}

