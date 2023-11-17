namespace FormationGarneauApiNetCore.FlightPriceNamespace.Model
{
    public class Company
    {
        public Company(string name, string description, string pays, Uri url, List<Plane> planes)
        {
            Name = name;
            Description = description;
            Pays = pays;
            this.url = url;
            this.planes = planes;
        }

        public string Name { get; }
        public string Description { get; }
        public string Pays { get; }
        public Uri url { get; set; }
        public List<Plane> planes { get; set; }
    }
}
