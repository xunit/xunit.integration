using System.Linq;
using Xunit;

public class xUnit2033
{
    [Fact]
    public void SingleSample()
    {
        var collection = new[] { 1 };

        Assert.Single(collection);
        Assert.Equal(1, collection.Single());
    }

    [Theory]
    [InlineData("Hello world")]
    public void IsTypeSample(object value)
    {
        Assert.IsType<string>(value);
        Assert.StartsWith("Hello", (string)value);
    }
}
