using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Extensions;

public class v1_net20
{
    [Fact]
    public void Passing()
    {
    }

    [Fact]
    public void Failing()
    {
        Assert.True(false);
    }

    [Theory]
    [InlineData(2112)]
    [InlineData("hello")]
    [InlineData(null)]
    public void Theory(object value)
    {
        Assert.NotNull(value);
    }
}