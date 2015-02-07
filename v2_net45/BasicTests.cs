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
    [InlineData("hello")]
    [InlineData(null)]
    public void Theory(object value)
    {
        Assert.NotNull(value);
    }

    [Fact]
    public void InvalidFact(object x) { }  // Facts can't have parameters

    [Theory]
    [InlineData(42, "Hello World", 21.12)]  // Too much data
    [InlineData(2600)]                      // Not enough data
    public void InvalidTheory(int x, string y) { }
}
