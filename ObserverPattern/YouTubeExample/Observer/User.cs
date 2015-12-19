using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.YouTubeExample.Observer
{
    public class User : ISubscriber
    {
        private readonly string _name;

        public string Name { get { return _name; } }

        public User(string name)
        {
            _name = name;
        }

        public void Notify()
        {
            Console.WriteLine("Updating user about new video");
        }
    }
}
