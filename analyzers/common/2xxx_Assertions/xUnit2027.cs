using System.Collections.Generic;
using Xunit;

public class xUnit2027
{
    [Fact]
    public void TestMethod()
    {
        var expected = new List<int> { 2112, 42 };
        var actual = new HashSet<int> { 42, 2112 };

        Assert.Equal(expected, actual);
    }
}
