using System;
using RestaurantOrderingSystem;

public class Receipt
{

	private Order order;

	public Receipt(Order order)
	{
		this.order = order;
	}

	public void PrintReceipt()
	{
		Console.WriteLine("\n--- Receipt ---");
		double total = 0;
		foreach (var item in order.Items)
		{
			Console.WriteLine($"{item.ItemName} x {item.Quantity} - PHP{item.GetTotalPrice()}");
			total += item.GetTotalPrice();
		}

		Console.WriteLine("-------------------");
		Console.WriteLine($"Total: PHP{total}");
		Console.WriteLine($"Customer: {order.Customer.Name}");
		Console.WriteLine($"Contact: {order.Customer.ContactNumber}");
		Console.WriteLine("-------------------");

	}
}
