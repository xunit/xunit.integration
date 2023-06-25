using System.Text.RegularExpressions;
using Xunit;

public class xUnit2008
{
    [Fact]
    public void TestMethod()
    {
        var result = "foo bar baz";

        Assert.True(Regex.IsMatch(result, "foo (.*?) baz"));
    }
}
