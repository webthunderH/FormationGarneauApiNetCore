using System;
using Service.RicardoRecipes.Interfaces;
using Service.RicardoRecipes.Model;

namespace Service.RicardoRecipes.Services
{
    public class RicardoRecipeService : IRicardoRecipeService
	{
        private List<Recipe> _recipesRicardo;

        public RicardoRecipeService()
        {
            LoadAllRecipes();
        }

        private void LoadAllRecipes()
        {
            _recipesRicardo = new List<Recipe>();

            // TODO : add recipes randomly
        }


        public List<Recipe> GetRecipes(string name, CuisineType cuisineType, uint cookTimeInMinutes, uint servingSize)
        {
            List<Recipe> recipesTrouves = new List<Recipe>();
            foreach (Recipe recipe in _recipesRicardo)
            {
                if (recipe.Name.Contains(name)
                    && recipe.CuisineType == cuisineType
                    && recipe.ServingSize == servingSize
                    && recipe.CookTime.TotalMinutes <= cookTimeInMinutes)
                {
                    recipesTrouves.Add(recipe);
                }
            }

            return recipesTrouves;
        }
    }
}

