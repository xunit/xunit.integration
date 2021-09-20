using System;
using Xunit;

public class xUnit2015
{
    void FunctionThatThrows() { }

    [Fact]
    public void TestMethod()
    {
        Assert.Throws(typeof(InvalidOperationException), () => FunctionThatThrows());
    }
}
