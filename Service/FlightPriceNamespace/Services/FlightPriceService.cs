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

            var x = new Model.FlightPrice(100.404F, "Rio de Janeiro", "Montréal", ClasseSeat.Economic,
                new Company("Air Canada", "une bande de voleur", "Canada", new Uri("https://google.com"), new List<Plane>()
                ), new Luggage(10, 10, 2, ClasseSeat.Economic), "A39", "SOS5645");
            x.AddSupplementLuggage(new Luggage(10, 10, 2, ClasseSeat.Economic));
            var flightPrice = new List<Model.FlightPrice>();
            flightPrice.Add(new Model.FlightPrice(100.404F, "Rio de Janeiro", "Montréal", ClasseSeat.Economic,
                new Company("Air Canada", "une bande de voleur", "Canada", new Uri("https://google.com"), new List<Plane>()
                ), new Luggage(10, 10, 2, ClasseSeat.Economic), "A39", "SOS5645")
            );
            flightPrice.Add(new Model.FlightPrice(500.404F, "Rio de Janeiro", "Québec", ClasseSeat.Economic,
                new Company("Air Canada", "une bande de voleur", "Canada", new Uri("https://google.com"), new List<Plane>()
                ), new Luggage(10, 10, 2, ClasseSeat.FirstClasse), "A39", "SOS5645")
            );
            flightPrice.Add(new Model.FlightPrice(120.404F, "Paris", "Montréal", ClasseSeat.Economic,
                new Company("Air Canada", "une bande de voleur", "Canada", new Uri("https://google.com"), new List<Plane>()
                ), new Luggage(10, 10, 2, ClasseSeat.Economic), "A39", "SOS5645")
            );
            flightPrice.Add(new Model.FlightPrice(15.404F, "Rio de Janeiro", "Montréal", ClasseSeat.Economic,
               new Company("Air Brasil", "une bande de voleur", "Brasil", new Uri("https://google.com"), new List<Plane>()
               ), new Luggage(10, 10, 1, ClasseSeat.Economic), "A39", "SOS5645")
           );
            flightPrice.Add(new Model.FlightPrice(80.404F, "Rio de Janeiro", "Montréal", ClasseSeat.Economic,
                new Company("Air Mexico", "une bande de voleur", "Mexique", new Uri("https://google.com"), new List<Plane>()
                ), new Luggage(10, 10, 1, ClasseSeat.Economic), "A39", "SOS5645")
            );
            var testW = repository.Get().Result;
            return flightPrice.FindAll(x =>
            {
                return x.Arrival == arrival && x.Depart == depart;
            }).OrderBy(x => x.Price).ToList();
        }

        public Func<BaseDeDonneeSql.FlightPriceNameSpace.FlightPrice, bool> Func = x => x.Price == 10;
        public Func<BaseDeDonneeSql.FlightPriceNameSpace.FlightPrice, bool> Triche = x => ClauseWhere(x);
        private static bool ClauseWhere(BaseDeDonneeSql.FlightPriceNameSpace.FlightPrice flightPrice)
        {
            return flightPrice.Price == 10;
        }
        
    }
}
