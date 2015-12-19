using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediatorPatternExample
{
    public interface IAirTrafficControl
    {
        void ReceiveAircraftLocation(Aircraft reportingAircraft);
        void RegisterAircraftUnderGuidance(Aircraft aircraft);
    }
}
