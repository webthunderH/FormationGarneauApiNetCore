using BaseDeDonneeSql.Lotterie;
using Service.Lotterie.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Mapper
{
    public static class BilletMapper
    {
        public static BilletPossible BilletEntyToBilletPossible(BilletLotterieEntity billetLotterieEntity)
        {
            var toReturn = new BilletPossible();
            toReturn.PourcentageReussite = billetLotterieEntity.PourcentageReussite;
            toReturn.MontantRemporter = billetLotterieEntity.MontantRemporter;
            toReturn.NombreDeGagnant = billetLotterieEntity.NombreDeGagnant;
            toReturn.TempsQuIlFaisait = billetLotterieEntity.TempsQuIlFaisait;
            toReturn.Numéros = new List<uint>();
            foreach (var numero in billetLotterieEntity.Numéros)
            {
                uint numeroToAdd = 0;
                if(uint.TryParse(numero.Numero.ToString(), out numeroToAdd))
                {
                    toReturn.Numéros.Add(numeroToAdd);
                }                
            }

            return toReturn;
        }
    }
}
