using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Lotterie.Model
{
    public class BilletPossible
    {
        public BilletPossible()
        {
            
        }
        public BilletPossible(List<uint> Numéros, double pourcentageReussite, string tempsQuIlFaisait, double montantRemporter, uint nombreDeGagnant)
        {
            this.Numéros = Numéros;
            PourcentageReussite = pourcentageReussite;
            TempsQuIlFaisait = tempsQuIlFaisait;
            MontantRemporter = montantRemporter;
            NombreDeGagnant = nombreDeGagnant;
        }

        public List<uint> Numéros {  get; set; }
        public double PourcentageReussite { get; set; }

        public string TempsQuIlFaisait { get; set; }

        public double MontantRemporter { get; set; }

        public uint NombreDeGagnant { get; set; }
    }
}
