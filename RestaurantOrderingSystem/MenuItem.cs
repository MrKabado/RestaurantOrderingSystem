using System;

namespace RestaurantOrderingSystem
{
	public abstract class MenuItem
	{
		public string Code { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }

		public abstract string GetCategory();

		public string GetDisplayText()
		{
			return $"{Name} - PHP {Price}";

		}
	}

	public class FoodItem : MenuItem //inherit
	{
		public override string GetCategory() //polymorphism
		{
			return "Food";
		}
	}

	public class DrinkItem : MenuItem
	{
		public override string GetCategory()
		{
			return "Drink";
		}
	}

}
