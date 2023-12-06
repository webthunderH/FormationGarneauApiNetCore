using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Ricardo.Models;

namespace FormationGarneauApiNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RicardoController : ControllerBase
    {
        public List<Recette> GetRecette()
        {
            return new List<Recette>();
        }
    }
}
