using Xunit;

public class xUnit2032
{
    [Fact]
    public void TestMethod()
    {
        Assert.IsAssignableFrom<object>("Hello world");
        Assert.IsNotAssignableFrom<object>("Hello world");
    }
}
