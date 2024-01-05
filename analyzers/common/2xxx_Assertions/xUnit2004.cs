using Xunit;

public class xUnit2004
{
    [Fact]
    public void TestMethod()
    {
        var result = 2 + 2;

        Assert.Equal(true, result > 3);
    }
}
