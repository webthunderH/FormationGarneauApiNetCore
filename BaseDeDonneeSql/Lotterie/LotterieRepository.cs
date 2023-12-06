using BaseDeDonneeSql.FlightPriceNameSpace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDonneeSql.Lotterie
{
    public class LotterieRepository : BaseRepository<BilletLotterieEntity>, ILotterieRepository
    {
        public LotterieRepository(DbContextGarneau context) : base(context)
        {
        }
    }
}
