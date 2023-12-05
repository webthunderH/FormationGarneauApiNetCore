using BaseDeDonneeSql.FlightPriceNameSpace;
using FormationGarneauApiNetCore.FlightPriceNamespace.Model;
using Service;
using Service.FlightPriceNamespace.Interfaces;
using System.Linq;

namespace FormationGarneauApiNetCore.FlightPriceNamespace.Services
{
    public class FlightPriceService : IFlightPrice
    {
        private readonly IFlightPriceRepository repository;

        public static string arrival { get; set; }
        public static string depart { get; set; }

        public FlightPriceService(IFlightPriceRepository repository)
        {
            this.repository = repository;
        }

        public List<Model.FlightPrice> GetFlightPrices(string depart, string arrival)
        {           
     
            var flightPrice = new List<Model.FlightPrice>();
           
            var testW = repository.GetListBy(x => x.Arrival == arrival || x.Depart == depart).Result;
            testW.ForEach(w => flightPrice.Add(new Model.FlightPrice(w.Price, w.Arrival, w.Depart,ClasseSeat.Economic,
                new Company("Air Mexico", "une bande de voleur", "Mexique", new Uri("https://google.com"), new List<Plane>()
                ), new Luggage(10, 10, 1, ClasseSeat.Economic), "A39", "SOS5645")));
            return flightPrice.OrderBy(x => x.Price).ToList();
        }

        public Func<BaseDeDonneeSql.FlightPriceNameSpace.FlightPrice, bool> Func = x => x.Price == 10;
        public Func<BaseDeDonneeSql.FlightPriceNameSpace.FlightPrice, bool> Triche = x => ClauseWhere(x);
        private static bool ClauseWhere(BaseDeDonneeSql.FlightPriceNameSpace.FlightPrice flightPrice)
        {
            return flightPrice.Price == 10;
        }
        
    }
}
