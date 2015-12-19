using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternExample
{
    public class AirBus321 : Aircraft
    {
        public AirBus321(string callSign, IAirTrafficControl atc) : base(callSign, atc)
        {
        }

        public override int Ceiling
        {
            get { return 41000; }
        }
    }
}
