using Xunit;

public class xUnit2023
{
    [Fact]
    public void TestMethod()
    {
        var collection = new[] { 1 };

        Assert.Collection(
            collection,
            item => Assert.Equal(1, item)
        );
    }
}
