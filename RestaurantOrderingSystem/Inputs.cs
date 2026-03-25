using System;

namespace RestaurantOrderingSystem
{
	public class Inputs
	{
		public Inputs()
		{
		}

		private Validation valid = new Validation();

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


	}
}
