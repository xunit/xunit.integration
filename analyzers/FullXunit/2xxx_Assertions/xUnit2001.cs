using Xunit;

public class xUnit2001
{
    [Fact]
    public void TestMethod()
    {
        var result = 21 * 2;

        // This will always also show CS0619 because we use [Obsolete(..., error: true)]
        Assert.Equals(42, result);
    }
}
