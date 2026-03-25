using System;
using System.ComponentModel.DataAnnotations;

namespace RestaurantOrderingSystem
{
	public class Inputs
	{
		public Inputs()
		{
		}

		private Validation valid = new Validation();
		private Menu menu;

		public string GetValidName()
		{
			while (true)
			{
				Console.Write("\nEnter your name: ");
				string input = Console.ReadLine();

				if (input == "0") //break the loop if meet the condition
				{
					Console.WriteLine("Order cancelled.");
					return null;
				}

				if (valid.IsValidName(input)) //break the loop if meet the condition
				{
					return input;
				}

				Console.WriteLine("Invalid name. Try again. (0 to stop)");
			}
		}

		public string GetValidContact()
		{
			while (true)
			{
				Console.Write("\nEnter your contact number: ");
				string input = Console.ReadLine();

				if (input == "0") //break the loop if meet the condition
				{
					Console.WriteLine("Order Cancelled");
					return null;
				}

				if (valid.IsValidNumber(input)) //break the loop if meet the condition and return the input
				{
					return input;
				}

				Console.WriteLine("Invalid contact. Try again. (0 to stop)");
			}
		}

		public MenuItem GetItemCode()
		{		
			while (true)
			{
				Console.Write("Enter item code: ");
				string input = Console.ReadLine();

				MenuItem selectedItem = menu.FindItemByCode(input);

				if (input == "0") //break the loop if meet the condition
				{
					Console.WriteLine("Order Cancelled");
					return null;
				}

				if (valid.IsValidMenuChoice(input)) //break the loop if meet the condition and return the input
				{
					return selectedItem;
				}

				Console.WriteLine("Item not found in the menu. Please try again. (0 to cancel)");
			}
		}

		public int GetItemQuantity()
		{
			while (true)
			{
				Console.Write("Enter item quantity: ");
				int input = int.Parse(Console.ReadLine());

				if (input == 0) //break the loop if meet the condition
				{
					Console.WriteLine("Order Cancelled");
					return 0;
				}

				if (valid.IsValidQuantity(input, 10))
				{
					return input;
				}

				Console.WriteLine("Quantity invalid. (0) to cancel.");
			}
		}
	}
}
