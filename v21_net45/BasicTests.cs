using System.Threading.Tasks;
using Xunit;

public class BasicTests
{
    [Fact]
    public void Passing()
    {
        Assert.True(true);
    }

    [Fact]
    public void Failing()
    {
        Assert.True(false);
    }

    [Theory]
    [InlineData(2112)]
    [InlineData("hello from v21_net45")]
    [InlineData(null)]
    public void Theory(object value)
    {
        Assert.NotNull(value);
    }

    [Fact]
    public async void FailingAsyncVoidTest()
    {
        await Task.Delay(0);
        Assert.True(false);
    }

    [Fact]
    public async Task FailingAsyncTaskTest()
    {
        await Task.Delay(0);
        Assert.True(false);
    }
}
