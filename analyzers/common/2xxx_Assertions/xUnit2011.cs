using Xunit;

public class xUnit2011
{
    [Fact]
    public void TestMethod()
    {
        var result = new[] { 1 };

        Assert.Collection(result);
    }
}
