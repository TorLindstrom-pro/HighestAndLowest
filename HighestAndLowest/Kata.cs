
namespace HighestAndLowest;

public class Kata
{
	public static string HighAndLow(string input)
	{
		if (InputIsInvalid(input))
			return "invalid input";

		return MaxAndMinValuesOf(input);
	}

	private static string MaxAndMinValuesOf(string input)
	{
		var numbers = input.Split(" ");
		return numbers.Max() + " " + numbers.Min();
	}

	private static bool InputIsInvalid(string input)
	{
		return string.IsNullOrWhiteSpace(input);
	}
}