using System.Linq;
using Xunit;

public class xUnit2012
{
    [Fact]
    public void TestMethod()
    {
        var result = new[] { "Hello" };

        Assert.True(result.Any(value => value == "Hello"));
    }
}
