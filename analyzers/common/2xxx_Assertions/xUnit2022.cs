using Xunit;

public class TestClass
{
    [Fact]
    public void TestMethod()
    {
        var condition = true;

        Assert.False(!condition);
    }
}
