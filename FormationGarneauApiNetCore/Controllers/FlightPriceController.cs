using FormationGarneauApiNetCore.FlightPriceNamespace.Model;
using FormationGarneauApiNetCore.FlightPriceNamespace.Services;
using Microsoft.AspNetCore.Mvc;
using Service.FlightPriceNamespace.Interfaces;

namespace FormationGarneauApiNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightPriceController : ControllerBase
    {
        private readonly IFlightPrice FlightPriceService;

        public FlightPriceController(IFlightPrice flightPrice)
        {
             FlightPriceService = flightPrice;
        }

        [HttpGet(Name = "GetFlightPrice")]
        public List<FlightPrice> GetFlightPrice(string depart, string arrivee)
        {
            return FlightPriceService.GetFlightPrices(depart,arrivee);
        }

    }
}
