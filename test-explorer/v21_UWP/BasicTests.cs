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
