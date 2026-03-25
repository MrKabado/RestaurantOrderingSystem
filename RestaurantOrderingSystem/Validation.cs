using System;
using System.Reflection.Metadata.Ecma335;
using System.Linq;

public class Validation
{
	public Validation()
	{
	}

	public bool IsValidMenuChoice (string choice)
	{
		string[] menuChoice = { "F1", "F2", "F3", "D1", "D2", "D3" };
		return !string.IsNullOrEmpty(choice) && menuChoice.Any(c => c.Equals(choice, StringComparison.OrdinalIgnoreCase));
	}

	public bool IsValidQuantity (int qty, int max)
	{
		return qty > 0 && qty < max;
	}

	public bool IsValidName (string name)
	{
		return !string.IsNullOrWhiteSpace(name) && name.All(c => char.IsLetter(c) || c == ' ');
	}

	public bool IsValidNumber (string number)
	{
		return !string.IsNullOrWhiteSpace(number) && number.All(c => char.IsDigit(c));
	}
} 
