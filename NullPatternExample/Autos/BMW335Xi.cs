using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullPatternExample.Autos
{
    public class BMW335Xi : AutomobileBase
    {
        public override Guid ID
        {
            get
            {
                return new Guid();
            }
        }

        public override string Name
        {
            get
            {
                return "BMW 335Xi";
            }
        }

        public override void Start()
        {
            Console.WriteLine("The BMW 335Xi is on and running.");
        }

        public override void Stop()
        {
            Console.WriteLine("The BMW 335Xi is off.");
        }
    }
}
