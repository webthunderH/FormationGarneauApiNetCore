using FormationGarneauApiNetCore.FlightPriceNamespace.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.FlightPriceNamespace.Interfaces
{
    public interface IFlightPrice
    {
        List<FlightPrice> GetFlightPrices(string depart, string arrival);
    }
}
