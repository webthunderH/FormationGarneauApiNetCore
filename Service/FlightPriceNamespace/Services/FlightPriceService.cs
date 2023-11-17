using FormationGarneauApiNetCore.FlightPriceNamespace.Model;
using Service.FlightPriceNamespace.Interfaces;
using System.Linq;

namespace FormationGarneauApiNetCore.FlightPriceNamespace.Services
{
    public class FlightPriceService : IFlightPrice
    {

        public List<FlightPrice> GetFlightPrices(string depart, string arrival)
        {
            var flightPrice = new List<FlightPrice>();
            flightPrice.Add(new FlightPrice(100.404F, "Rio de Janeiro", "Montréal", ClasseSeat.Economic, 
                new Company("Air Canada", "une bande de voleur", "Canada", new Uri("https://google.com"), new List<Plane>()
                ), new Luggage(10,10,2,ClasseSeat.Economic), "A39", "SOS5645")
            );
            flightPrice.Add(new FlightPrice(500.404F, "Rio de Janeiro", "Québec", ClasseSeat.Economic,
                new Company("Air Canada", "une bande de voleur", "Canada", new Uri("https://google.com"), new List<Plane>()
                ), new Luggage(10, 10, 2, ClasseSeat.FirstClasse), "A39", "SOS5645")
            );
            flightPrice.Add(new FlightPrice(120.404F, "Paris", "Montréal", ClasseSeat.Economic,
                new Company("Air Canada", "une bande de voleur", "Canada", new Uri("https://google.com"), new List<Plane>()
                ), new Luggage(10, 10, 2, ClasseSeat.Economic), "A39", "SOS5645")
            );
            flightPrice.Add(new FlightPrice(15.404F, "Rio de Janeiro", "Montréal", ClasseSeat.Economic,
               new Company("Air Brasil", "une bande de voleur", "Brasil", new Uri("https://google.com"), new List<Plane>()
               ), new Luggage(10, 10, 1, ClasseSeat.Economic), "A39", "SOS5645")
           );
            flightPrice.Add(new FlightPrice(80.404F, "Rio de Janeiro", "Montréal", ClasseSeat.Economic,
                new Company("Air Mexico", "une bande de voleur", "Mexique", new Uri("https://google.com"), new List<Plane>()
                ), new Luggage(10, 10, 1, ClasseSeat.Economic), "A39", "SOS5645")
            );

            return flightPrice.FindAll(x =>
            {
                return x.Arrival == arrival && x.Depart == depart;
            }).OrderBy(x=>x.Price).ToList();
        }
    }
}
