using System;
namespace Service.RicardoRecipes.Model
{
	public class Ingredient
	{
        public Ingredient(string name, double quantity, string measurementUnit, Ingredient? alternativeIngredient = null)
        {
            Name = name;
            Quantity = quantity;
            MeasurementUnit = measurementUnit;
            AlternativeIngredient = alternativeIngredient;
        }

        public string Name { get; }
		public double Quantity { get; }
		public string MeasurementUnit { get; }
		public Ingredient? AlternativeIngredient { get; }
	}
}

