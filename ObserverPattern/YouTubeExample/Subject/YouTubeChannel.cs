using ObserverPattern.YouTubeExample.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.YouTubeExample.Subject
{
    public class YouTubeChannel
    {
        private IList<ISubscriber> subscribers = new List<ISubscriber>();

        public void Subscribe(ISubscriber s)
        {
            subscribers.Add(s);
        }

        public void Unsubscribe(ISubscriber s)
        {
            subscribers.Remove(s);
            Console.WriteLine(s.Name + " has been unsubscribed");
        }

        public void NotifySubscribers()
        {
            foreach(ISubscriber s in subscribers)
            {
                s.Notify();
            }
        }
    }
}
