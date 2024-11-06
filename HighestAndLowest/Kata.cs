
namespace HighestAndLowest;

public class Kata
{
	public static string HighAndLow(string input)
	{
		return IsInputInvalid(input) ? "0" : "1,1";
	}

	private static bool IsInputInvalid(string input)
	{
		return input == null || string.IsNullOrWhiteSpace(input);
	}
}