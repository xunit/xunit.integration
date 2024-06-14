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
    [InlineData("hello from v3x_net60")]
    [InlineData(new object?[] { null })]
    public void Theory(object? value)
    {
        Assert.NotNull(value);
    }
}
