using Xunit;

public class xUnit2016
{
    [Fact]
    public void TestMethod()
    {
        var actual = 1.1;

        Assert.Equal(1.1, actual, 16);
    }
}
