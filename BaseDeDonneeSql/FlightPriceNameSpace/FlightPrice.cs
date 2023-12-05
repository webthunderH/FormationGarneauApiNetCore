using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDonneeSql.FlightPriceNameSpace
{
    public class FlightPrice
    {
        
        public int FlightPriceId { get; set; }
        public float Price { get; set; }
        public string Arrival { get; set; }
        public string Depart { get; set; }
    }
}
