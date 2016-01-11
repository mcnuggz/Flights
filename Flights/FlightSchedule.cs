using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights
{
    class FlightSchedule : IEnumerable
    {
        string[] milwaukeeFlights =
        {
            "Dallas - Flight 1119 - 5:00pm",
            "Houston - Flight 5802 - 5:12pm",
            "Baltimore - Flight 6054 - 5:50pm",
            "Kansas City - Flight 1027 - 5:45pm",
            "Washington - Flight 2766 - 6:00pm",
            "Los Angeles - Flight 1717 - 6:10pm",
            "Atlanta - Flight 4396 - 6:18pm",
            "St. Louis - Flight 1168 - 7:05pm",
            "Boston - Flight 312 - 7:55pm",
            "Las Vegas - Flight 1227 - 8:25pm"
        };

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < milwaukeeFlights.Length; index++)
            {
                yield return milwaukeeFlights[index];
            }
        }
    }
}
