using HighestAndLowest;

namespace Test;

public class UnitTest1
{
    [Fact(DisplayName = "Om input är null returneras specialvärdet 0")]
    public void HighAndLow_InputIsNull_ReturnsZero()
    {
        var result = Kata.HighAndLow(null);

        Assert.Equal("0", result);
    }
    
    [Fact(DisplayName = "Om input innehåller ett tal anses det vara både högst och lägst")]
    public void HighAndLow_InputIsOneNumber_ReturnsNumberForBothHighestAndLowest()
    {
        var result = Kata.HighAndLow("1");

        Assert.Equal("1,1", result);
    }
}