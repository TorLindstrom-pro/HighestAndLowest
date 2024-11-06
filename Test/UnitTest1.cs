namespace Test;

public class UnitTest1
{
    [Fact(DisplayName = "Metoden returnerar en sträng")]
    public void Test1()
    {
        Kata.HighAndLow("1 2 3 4 5");
    }
}