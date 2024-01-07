using System;
using Xunit;

#if NETCOREAPP || NET462_OR_GREATER
using Microsoft.Extensions.Primitives;
#endif

public class xUnit2028
{
    [Fact]
    public void TestMethod()
    {
        Assert.Empty(new ArraySegment<int>());
        Assert.NotEmpty(new ArraySegment<int>());

#if NETCOREAPP || NET462_OR_GREATER
        Assert.Empty(StringValues.Empty);
        Assert.NotEmpty(StringValues.Empty);
#endif
    }
}
