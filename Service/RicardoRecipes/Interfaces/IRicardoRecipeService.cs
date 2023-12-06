using System;
using Service.RicardoRecipes.Model;

namespace Service.RicardoRecipes.Interfaces
{
	public interface IRicardoRecipeService
	{
		public List<Recipe> GetRecipes(string name, CuisineType cuisineType, uint cookTimeInMinutes, uint servingSize);
	}
}

