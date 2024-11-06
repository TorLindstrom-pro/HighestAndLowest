using HighestAndLowest;

namespace Test;

public class UnitTest1
{
    [Theory(DisplayName = "Om input är invalid returneras specialvärdet 0")]
    [InlineData(null)]
    [InlineData("")]
    public void HighAndLow_InputIsInvalid_ReturnsZero(string input)
    {
        var result = Kata.HighAndLow(input);

        Assert.Equal("0", result);
    }
    
    [Fact(DisplayName = "Om input innehåller ett tal anses det vara både högst och lägst")]
    public void HighAndLow_InputIsOneNumber_ReturnsNumberForBothHighestAndLowest()
    {
        var result = Kata.HighAndLow("1");

        Assert.Equal("1,1", result);
    }
}