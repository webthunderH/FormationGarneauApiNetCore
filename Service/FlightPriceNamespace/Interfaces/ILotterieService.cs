using Service.Lotterie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.FlightPriceNamespace.Interfaces
{
    public interface ILotterieService
    {
        public List<BilletPossible> ObtenirListeBilletPossible();
    }
}
