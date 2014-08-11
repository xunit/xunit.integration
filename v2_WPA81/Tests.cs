using System;
using Xunit;

public class v2_WPA81
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
