using Xunit;

public class BasicTests
{
    [Fact]
    public void Passing()
    {
        Assert.True(true);
    }

    [Fact]
    public void Failing()
    {
        Assert.True(false);
    }

    [Theory]
    [InlineData(2112)]
    [InlineData("hello from x2x_net462_OldProject")]
    [InlineData(null)]
    public void Theory(object value)
    {
        Assert.NotNull(value);
    }
}
