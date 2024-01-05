using System;
using Xunit;

public class xUnit2018
{
    [Fact]
    public void TestMethod()
    {
        var result = new object();

        Assert.IsType<IDisposable>(result);
        Assert.IsNotType<IDisposable>(result);
    }
}
