using System;

public class OrderItem
{
	public string ItemCode { get; set; }
	public string ItemName { get; set; }
	public int Quantity { get; set; }
	public double Price { get; set; }

	public string GetDisplayText()
	{
		return $"{ItemCode} {ItemName} x {Quantity}";
	
	}

	public double GetTotalPrice()
	{
		return Price * Quantity;
	}
}
