using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Ricardo.Models
{
    public class Etape
    {
        public string Tache { get; set; }
        public int NumeroEtape { get; set; }
        public bool IsDone { get; set; }
        public Photo Photo { get; set; }
    }
}
