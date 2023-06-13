using System;
using Xunit;

public class xUnit2005
{
    [Fact]
    public void TestMethod()
    {
        var result = DateTime.Now;

        Assert.Same(new DateTime(2017, 1, 1), result);
    }
}
