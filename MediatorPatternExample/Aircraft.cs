using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPatternExample
{
    public abstract class Aircraft
    {
        private readonly IAirTrafficControl _atc;
        private int _currentAltitude;

        public abstract int Ceiling { get; }
        public string CallSign { get; private set; }
        public int Altitude
        {
            get
            {
                return _currentAltitude;
            }
            set
            {
                _currentAltitude = value;
                _atc.ReceiveAircraftLocation(this);
            }
        }

        protected Aircraft(string callSign, IAirTrafficControl atc)
        {
            CallSign = callSign;
            _atc = atc;
            _atc.RegisterAircraftUnderGuidance(this);
        }

        public void Climb(int heightToClimb)
        {
            Altitude += heightToClimb;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return CallSign.GetHashCode();
        }

        public void WarnOfAirspaceIntrusionBy(Aircraft reportingAircraft)
        {
            // do something in response to the warning
            Console.WriteLine("{0}: {1} get out of my airspace", CallSign, reportingAircraft.CallSign);
        }
    }
}
