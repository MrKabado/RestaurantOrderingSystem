using System;

namespace RestaurantOrderingSystem
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Restaurant Ordering System!\n");
			Menu menu = new Menu();
			Order order = new Order(menu);
			Receipt receipt = new Receipt(order);

			menu.GetMenuDisplay();

			order.AddItem();
			order.OrderAgain();
			order.GetCustomerInfo();

			receipt.PrintReceipt();
		}
	}
}
