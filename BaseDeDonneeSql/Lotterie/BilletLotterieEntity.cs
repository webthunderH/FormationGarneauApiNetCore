using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDonneeSql.Lotterie
{
    public class BilletLotterieEntity
    {
        [Key]
        public int BilletId { get; set; }
        public double PourcentageReussite { get; set; }

        public string TempsQuIlFaisait { get; set; }

        public uint MontantRemporter { get; set; }

        public uint NombreDeGagnant { get; set; }
        public List<BouleNumero> Numéros { get; set; }
    }
}
