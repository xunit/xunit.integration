using System.Linq;
using Xunit;

public class xUnit2030
{
    [Fact]
    public void TestMethod()
    {
        var collection = new[] { 1, 2, 3 };

        Assert.NotEmpty(collection.Where(i => i % 2 == 0));
    }
}
