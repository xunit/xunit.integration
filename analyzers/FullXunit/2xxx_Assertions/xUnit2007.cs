using Xunit;

public class xUnit2007
{
    [Fact]
    public void TestMethod()
    {
        var result = "foo";

        Assert.IsType(typeof(string), result);
    }
}
