
namespace HighestAndLowest;

public class Kata
{
	public static string HighAndLow(string input)
	{
		if (IsInputInvalid(input))
			return "invalid input";
		
		var numbers = input.Split(" ");
		return numbers.Max() + " " + numbers.Min();
	}

	private static bool IsInputInvalid(string input)
	{
		return input == null || string.IsNullOrWhiteSpace(input);
	}
}