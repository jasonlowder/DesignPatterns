using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Logger
    {
        private static Logger instatance = null;

        private Logger() { }

        public static Logger GetInstance()
        {
            // YODA EXPRESSION
            if (null == instatance)
            {
                instatance = new Logger();
            }
            return instatance;
        }

        public void WriteToFile(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
