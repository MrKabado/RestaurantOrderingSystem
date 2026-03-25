using System;

namespace RestaurantOrderingSystem
{
	public class MenuItem
	{
		public string Code { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }

		public virtual string GetCategory()
		{
			return "General";
		}

		public string GetDisplayText()
		{
			return $"{Name} ({GetCategory()}) - PHP {Price}";

		}
	}

	public class FoodItem : MenuItem
	{
		public override string GetCategory()
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
