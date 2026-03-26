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
			Order order = new Order(menu, inputs);
			Receipt receipt = new Receipt(order);

			Console.WriteLine("Welcome to the Restaurant Ordering System!\n");

			menu.GetMenuDisplay();

			order.AddItem();
			if (valid.IsCancelled == true) return;

			order.OrderAgain();

			order.GetCustomerInfo();
			if (valid.IsCancelled == true) return;

			receipt.PrintReceipt();
		}
	}
}
