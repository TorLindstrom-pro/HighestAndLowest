using HighestAndLowest;

namespace Test;

public class UnitTest1
{
    [Fact(DisplayName = "Metoden returnerar en sträng")]
    public void HighAndLow_ReturnsResultAsString()
    {
        var result = Kata.HighAndLow("1 2 3 4 5");

        Assert.IsType<string>(result);
    }

    [Fact(DisplayName = "Om input är null returneras specialvärdet 0")]
    public void HighAndLow_InputIsNull_ReturnsZero()
    {
        var result = Kata.HighAndLow(null);

        Assert.Equal("0", result);
    }
}