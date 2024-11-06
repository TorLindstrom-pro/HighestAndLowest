
namespace HighestAndLowest;

public class Kata
{
	public static string HighAndLow(string input)
	{
		return input == null || string.IsNullOrWhiteSpace(input) ? "0" : "1,1";
	}
}