
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDonneeSql.FlightPriceNameSpace
{
    public class FlightPriceRepository : BaseRepository<FlightPrice>, IFlightPriceRepository
    {
        public FlightPriceRepository(DbContextGarneau context) : base(context)
        {
        }
    }
}
