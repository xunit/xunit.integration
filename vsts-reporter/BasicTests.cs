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
        Assert.False(true);
    }


    [Theory]
    [InlineData(2112)]
    [InlineData("hello from vsts-reporter")]
    public void Theory(object value)
    {
        Assert.NotNull(value);
    }
}
