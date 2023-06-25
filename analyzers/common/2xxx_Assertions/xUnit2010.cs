using Xunit;

public class xUnit2010
{
    [Fact]
    public void TestMethod()
    {
        var result = "foo bar baz";

        Assert.True(string.Equals("foo bar baz", result));
    }
}
