using FormationGarneauApiNetCore.FlightPriceNamespace.Model;
using Service.FlightPriceNamespace.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.FlightPriceNamespace.Services
{
    internal class FlightServiceCore : IFlightPrice
    {
        public List<FlightPrice> GetFlightPrices(string depart, string arrival)
        {
            // Trouvé les companies dans la BD qu'on accepte.
            // Appeler leurs services web
            // Filtrer les retour sur départ et arrivée 
            // Adapter les valeur de ClasseSeat et Luggage 

            return new List<FlightPrice>();
        }
    }
}
