using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullPatternExample.Autos
{
    public class MiniCooper : AutomobileBase
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
                return "Mini Cooper";
            }
        }

        public override void Start()
        {
            Console.WriteLine("The Mini Cooper is on! 1.6 liters of brutal force is churning.");
        }

        public override void Stop()
        {
            Console.WriteLine("The Mini Cooper is turned off.");
        }
    }
}
