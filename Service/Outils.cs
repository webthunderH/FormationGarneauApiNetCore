using FormationGarneauApiNetCore.FlightPriceNamespace.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    internal static class Outils
    {
        public static int Add(this int x, int y) { return x + y; }

        public static void AddSupplementLuggage(this FlightPrice flightPrice, Luggage luggage)
        {
            flightPrice.Luggage = luggage;

        }


    }
}
