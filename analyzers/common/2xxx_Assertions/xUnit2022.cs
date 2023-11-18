using Xunit;

public class xUnit2022
{
    [Fact]
    public void TestMethod()
    {
        var condition = true;

        Assert.False(!condition);
    }
}
