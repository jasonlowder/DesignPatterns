using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.StockExample
{
    // Uses the Subject interface to update all Observers
    public class StockGrabber : ISubject
    {
        List<IObserver> observers;
        double ibmPrice;
        double aaplPrice;
        double googPrice;

        public double IbmPrice
        {
            get { return ibmPrice; }
            set
            {
                ibmPrice = value;
                NotifyObservers();
            }
        }
        public double AaplPrice
        {
            get { return aaplPrice; }
            set
            {
                aaplPrice = value;
                NotifyObservers();
            }
        }
        public double GoogPrice
        {
            get { return googPrice; }
            set
            {
                googPrice = value;
                NotifyObservers();
            }
        }

        public StockGrabber()
        {
            // Creates a list to hold all observers
            observers = new List<IObserver>();
        }

        public void Register(IObserver newObserver)
        {
            // Adds a new observer to the list
            observers.Add(newObserver);
        }

        public void Unregister(IObserver deleteObserver)
        {
            // Get the index of the observer to delete
            int observerIndex = observers.IndexOf(deleteObserver);

            // Print out message (Have to increment the index to match)
            Console.WriteLine("Observer {0} deleted", observerIndex + 1);

            //Removes the observer from the list
            observers.RemoveAt(observerIndex);
        }

        public void NotifyObservers()
        {
            // Cycle through all observers and notify them of price changes
            foreach (IObserver observer in observers)
            {
                observer.Update(IbmPrice, AaplPrice, GoogPrice);
            }
        }
    }
}
