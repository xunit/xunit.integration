using System.Linq;
using Xunit;

public class xUnit2031
{
    [Fact]
    public void TestMethod()
    {
        int[] collection = [1, 3, 5, 6, 9];

        Assert.Single(collection.Where(i => i % 2 == 0));
    }
}
