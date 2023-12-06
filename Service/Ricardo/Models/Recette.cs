using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Ricardo.Models
{
    public class Recette
    {
        public string Title { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Etape> Etapes { get; set; }

        public Photo PhotoFinalAvecRicardo { get; set; }
        public int Stars { get; set; }
    }
}
