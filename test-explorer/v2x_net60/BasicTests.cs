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
    [InlineData("hello from v2x_net6.0")]
    [InlineData(null)]
    [MemberData(nameof(PlatformName))]
    public void Theory(object value)
    {
        Assert.NotNull(value);
    }

    public static TheoryData<string> PlatformName
        => new() { System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription };
}
