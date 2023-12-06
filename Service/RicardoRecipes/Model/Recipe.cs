using System;
namespace Service.RicardoRecipes.Model
{
    public class Recipe
    {
        public Recipe(string name, CuisineType cuisineType, TimeSpan cookTime, uint servingSize, string description, List<Ingredient> ingredients, List<string> steps, uint rate, List<Category> categories)
        {
            Name = name;
            CuisineType = cuisineType;
            CookTime = cookTime;
            ServingSize = servingSize;
            Description = description;
            Ingredients = ingredients;
            Steps = steps;
            Rate = rate;
            Categories = categories;
        }

        public string Name { get; }

        public CuisineType CuisineType { get; }

        public TimeSpan CookTime { get; }

        public uint ServingSize { get; }

        public string Description { get; }

        public List<Ingredient> Ingredients { get; }

        public List<string> Steps { get; }

        public uint Rate { get; set; }

        public List<Category> Categories { get; set; } = new List<Category>();

    }
}

