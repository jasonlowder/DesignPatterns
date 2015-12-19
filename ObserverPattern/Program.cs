using ObserverPattern.YouTubeExample.Observer;
using ObserverPattern.YouTubeExample.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            YouTubeChannel myChannel = new YouTubeChannel();

            ISubscriber joey = new User("Joey");
            ISubscriber alex = new User("Alex");
            ISubscriber guy = new Moderator();

            myChannel.Subscribe(joey);
            myChannel.Subscribe(alex);
            myChannel.Subscribe(guy);

            myChannel.NotifySubscribers();

            Console.ReadKey();

            myChannel.Unsubscribe(alex);
            myChannel.NotifySubscribers();

            Console.ReadKey();
        }
    }
}
