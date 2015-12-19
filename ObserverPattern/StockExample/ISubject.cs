using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.StockExample
{
    // This interface handles adding, deleting and updating - See more at: http://www.newthinktank.com/2012/08/observer-design-pattern-tutorial/#sthash.84wuCSRB.dpuf
    // all observers
    public interface ISubject
    {
        void Register(IObserver o);
        void Unregister(IObserver o);
        void NotifyObservers();
    }
}
