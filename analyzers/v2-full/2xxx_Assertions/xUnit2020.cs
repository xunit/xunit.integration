using Xunit;

public class xUnit2020
{
    [Fact]
    public void TestMethod()
    {
        Assert.True(false, "Failure message");
        Assert.False(true, "Failure message");
    }
}
