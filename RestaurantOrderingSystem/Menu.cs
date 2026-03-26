using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

namespace RestaurantOrderingSystem
{
	public class Menu
	{
		public List<MenuItem> Items = new List<MenuItem>()
		{
			new FoodItem { Code = "F1", Name = "Burger", Price = 40 },
			new FoodItem { Code = "F2", Name = "Pizza", Price = 100 },
			new FoodItem { Code = "F3", Name = "Fries", Price = 40 },

			new DrinkItem { Code = "D1", Name = "Coke", Price = 20 },
			new DrinkItem { Code = "D2", Name = "Juice", Price = 15 },
			new DrinkItem { Code = "D3", Name = "Water", Price = 10 },
		};

		public void GetMenuDisplay() //show menu
		{
			string display = "Menu:\n";

			Console.WriteLine("Food Items:");
			foreach (var item in Items)
			{
				if (item.GetCategory() == "Food")
				{
					Console.WriteLine($"{item.Code}: {item.GetDisplayText()}");
				}
				
			}
			Console.WriteLine();

			Console.WriteLine("Drink Items:");
			foreach(var item in Items)
			{
				if (item.GetCategory() == "Drink")
				{
					Console.WriteLine($"{item.Code}: {item.GetDisplayText()}");
				}
			}
			Console.WriteLine();
		}
		
		public MenuItem FindItemByCode(string code)
		{
			return Items.Find(item => item.Code.Equals(code, StringComparison.OrdinalIgnoreCase));
		}
	}
}
