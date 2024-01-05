using Xunit;

public class xUnit2003
{
    [Fact]
    public void TestMethod()
    {
        var result = "Hello world!";

        Assert.Equal(null, result);
    }
}
