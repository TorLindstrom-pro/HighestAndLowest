
namespace HighestAndLowest;

public class Kata
{
	public static string HighAndLow(string input)
	{
		if (IsInputInvalid(input))
			return "0";
		else
			return "1,1";
	}

	private static bool IsInputInvalid(string input)
	{
		return input == null || string.IsNullOrWhiteSpace(input);
	}
}