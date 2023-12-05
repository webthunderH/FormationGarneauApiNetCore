using BaseDeDonneeSql.Lotterie;
using Service.FlightPriceNamespace.Interfaces;
using Service.Lotterie.Model;
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

        public List<BilletPossible> ObtenirListeBilletPossible() { 
            var billet = new List<BilletPossible>();

            for (int i = 0; i < 4; i++)
            {
                var numeroGagnant = new List<uint>();
                var randomX = new Random();
                double pourcentage = (double)randomX.Next(0, 100);
                for (int j = 0; j < 6; j++)
                { 
                    uint numeroGagnant2 = (uint)randomX.Next(0, 56);
                    numeroGagnant.Add(numeroGagnant2);
                }
                double montantGagner = (double)randomX.Next(500, 500000000);
                billet.Add(new BilletPossible(numeroGagnant, pourcentage, "beauTemps", montantGagner,10));
            }
            
            return billet;
        }
    }
}
