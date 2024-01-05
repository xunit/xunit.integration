using Xunit;

public class xUnit2006
{
    [Fact]
    public void TestMethod()
    {
        var result = "foo";

        Assert.Equal<string>("foo", result);
    }
}
