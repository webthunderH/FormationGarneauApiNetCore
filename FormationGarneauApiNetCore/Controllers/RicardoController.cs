using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.RicardoRecipes.Interfaces;
using Service.RicardoRecipes.Model;

namespace FormationGarneauApiNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RicardoController : ControllerBase
    {
        private readonly IRicardoRecipeService RicardoRecipeService;

        public RicardoController(IRicardoRecipeService ricardoRecipeService)
        {
            RicardoRecipeService = ricardoRecipeService;
        }

        [HttpGet("Recipes")]
        public List<Recipe> GetRecipes(string name, CuisineType cuisineType, uint cookTimeInMinutes, uint servingSize)
        {
            return RicardoRecipeService.GetRecipes(name, cuisineType, cookTimeInMinutes, servingSize);
        }
    }
}
