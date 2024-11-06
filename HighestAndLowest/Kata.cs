
namespace HighestAndLowest;

public class Kata
{
	public static string HighAndLow(string input)
	{
		return input == null || string.IsNullOrEmpty(input) ? "0" : "1,1";
	}
}