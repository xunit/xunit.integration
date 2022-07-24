using System.Linq;
using Xunit;

public class xUnit2013
{
    [Fact]
    public void TestMethod()
    {
        var result = new[] { "Hello" };

        Assert.Equal(1, result.Count());
        Assert.Equal(1, result.Length);
    }
}
