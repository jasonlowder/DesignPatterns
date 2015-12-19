using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.YouTubeExample.Observer
{
    public class Moderator : ISubscriber
    {
        public string Name
        {
            get { return "Moderator"; }
        }

        public void Notify()
        {
            Console.WriteLine("Moderator needs to review new video");
        }
    }
}
