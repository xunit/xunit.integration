using Xunit;

public class xUnit2009
{
    [Fact]
    public void TestMethod()
    {
        var result = "foo bar baz";

        Assert.True(result.Contains("bar"));
    }
}
