using HighestAndLowest;

namespace Test;

public class UnitTest1
{
    [Theory(DisplayName = "Om input är invalid returneras specialvärdet 0")]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    public void HighAndLow_InputIsInvalid_ReturnsZero(string input)
    {
        var result = Kata.HighAndLow(input);

        Assert.Equal("invalid input", result);
    }
    
    [Theory(DisplayName = "Om input innehåller ett tal anses det vara både högst och lägst")]
    [InlineData("1", "1 1")]
    [InlineData("2", "2 2")]
    public void HighAndLow_InputIsOneNumber_ReturnsNumberForBothHighestAndLowest(string input, string expected)
    {
        var result = Kata.HighAndLow(input);

        Assert.Equal(expected, result);
    }
    
    [Theory(DisplayName = "Om input innehåller två olika tal returneras högst och lägst")]
    [InlineData("2 1", "2 1")]
    [InlineData("1 2", "2 1")]
    [InlineData("1 2 3", "3 1")]
    public void HighAndLow_InputIstwoDifferentNumbers_ReturnsHighestAndLowest(string input, string expected)
    {
        var result = Kata.HighAndLow(input);

        Assert.Equal(expected, result);
    }
}