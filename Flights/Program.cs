using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flights
{
    class Program
    {
        static void Main(string[] args)
        {
            FlightSchedule flights = new FlightSchedule();

            foreach (string flight in flights)
            {
                if(flight.Contains("Los Angeles"))
                {
                    Console.WriteLine(flight);
                }
            }
            Console.ReadLine();
        }
    }
}
