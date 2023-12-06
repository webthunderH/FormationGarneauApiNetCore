using BaseDeDonneeSql.Lotterie;
using Service.FlightPriceNamespace.Interfaces;
using Service.Lotterie.Model;
using Service.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Lotterie.Services
{
    internal class LotterieService : ILotterieService
    {
        private ILotterieRepository repository;

        public LotterieService(ILotterieRepository repository)
        {
            this.repository = repository;
        }

        public List<BilletPossible> ObtenirListeBilletPossible() {
            var toReturn = new List<BilletPossible>();
            repository.GetListBy(x => x.PourcentageReussite > 0.80).Result.ForEach(
                billet=> toReturn.Add(BilletMapper.BilletEntyToBilletPossible(billet)));

            return toReturn;
        }
    }
}
