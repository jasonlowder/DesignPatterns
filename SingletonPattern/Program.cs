using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger log = Logger.GetInstance();

            log.WriteToFile("Use the Singleton Pattern sparingly!");

            Console.ReadKey();
        }
    }
}
