using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.FlightPriceNamespace.Interfaces;
using Service.Lotterie.Model;

namespace FormationGarneauApiNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LotterieController : ControllerBase
    {
        public readonly ILotterieService LotterieService;

        public LotterieController(ILotterieService lotterieService)
        {
            LotterieService = lotterieService;
        }

        [HttpGet]
        public List<BilletPossible> Get()
        {
                        
            return LotterieService.ObtenirListeBilletPossible();
        }

        [HttpGet("Erreur")]
        public BilletPossible GetBillet()
        {
            throw new NotImplementedException();
        }
    }
}
