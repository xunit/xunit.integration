using Xunit;

public class xUnit2000
{
    [Fact]
    public void TestMethod()
    {
        var result = 2 + 3;

        Assert.Equal(result, 5);
    }
}
