using Xunit;

public class xUnit2001
{
    [Fact]
    public void TestMethod()
    {
        var result = 21 * 2;

        Assert.Equals(42, result);
    }
}
