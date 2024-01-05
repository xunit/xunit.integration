using System.Linq;
using Xunit;

public class xUnit2017
{
    [Fact]
    public void TestMethod()
    {
        var result = new[] { "foo", "bar" };

        Assert.True(result.Contains("foo"));
    }
}
