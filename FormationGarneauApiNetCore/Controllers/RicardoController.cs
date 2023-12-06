using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Ricardo;
using Service.Ricardo.Models;

namespace FormationGarneauApiNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RicardoController : ControllerBase
    {
        private IRicardoService ricardoService;

        public RicardoController(IRicardoService ricardoService)
        {
            this.ricardoService = ricardoService;
        }

        public List<Recette> GetRecette()
        {
            return ricardoService.GetRecettes();
        }
    }
}
