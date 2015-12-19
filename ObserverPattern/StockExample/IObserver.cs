using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.StockExample
{
    // The Observers update method is called when the Subject changes - See more at: http://www.newthinktank.com/2012/08/observer-design-pattern-tutorial/#sthash.84wuCSRB.dpuf
    public interface IObserver
    {
        void Update(double ibmPrice, double aaplPrice, double googPrice);
    }
}
