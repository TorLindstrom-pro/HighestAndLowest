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
}