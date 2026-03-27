using System;

namespace RestaurantOrderingSystem
{
	class Program
	{
		public static void Main(string[] args)
		{
			Menu menu = new Menu();
			Validation valid = new Validation();

			Inputs inputs = new Inputs(menu, valid);
			Order order = new Order(menu, inputs, valid);
			Receipt receipt = new Receipt(order);

			valid.IsOrderAgain = true;
			while (valid.IsOrderAgain)
			{
				Console.WriteLine("Welcome to the Restaurant Ordering System!");
				Console.WriteLine("Type 0 to cancel the order\n");

				menu.GetMenuDisplay();

				order.AddItem();
				if (valid.IsCancelled == true) return;

				order.AddAgain();

				order.GetCustomerInfo();
				if (valid.IsCancelled == true) return;

				receipt.PrintReceipt();

				//ask if want to order again
				order.OrderAgain();
			} 
		}
	}
}
