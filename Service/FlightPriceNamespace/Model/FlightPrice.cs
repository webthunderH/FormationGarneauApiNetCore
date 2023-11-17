namespace FormationGarneauApiNetCore.FlightPriceNamespace.Model
{
    public class FlightPrice
    {
        public FlightPrice(float price, string arrival, string depart, ClasseSeat classeSeat, Company company, Luggage luggage, string siegeNumber, string flightNumber)
        {
            Price = price;
            Arrival = arrival;
            Depart = depart;
            ClasseSeat = classeSeat;
            Company = company;
            Luggage = luggage;
            SiegeNumber = siegeNumber;
            FlightNumber = flightNumber;
        }

        public float Price { get; }
        public string Arrival {  get; }
        public string Depart { get; }

        public ClasseSeat ClasseSeat { get; set; }

        public Company Company { get; set; }

        public Luggage Luggage { get; set; }

        public string SiegeNumber { get; set; }
        public string FlightNumber {  get; set; }
    }
}
