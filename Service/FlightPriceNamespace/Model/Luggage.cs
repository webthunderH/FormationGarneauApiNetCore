namespace FormationGarneauApiNetCore.FlightPriceNamespace.Model
{
    public class Luggage
    {
        public Luggage(float weight, float height, int numberAccepted, ClasseSeat classeSeat)
        {
            Weight = weight;
            Height = height;
            NumberAccepted = numberAccepted;
            ClasseSeat = classeSeat;
        }

        public float Weight { get; set; }
        public float Height { get; set;}
        public int NumberAccepted { get; set; }

        public ClasseSeat ClasseSeat { get; set; }
    }
}
