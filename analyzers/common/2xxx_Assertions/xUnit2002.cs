using Xunit;

public class xUnit2002
{
    [Fact]
    public void TestMethod()
    {
        var result = 2 + 3;

        Assert.NotNull(result);
        Assert.True(result > 4);
    }
}
