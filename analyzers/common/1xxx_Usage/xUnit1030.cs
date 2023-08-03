#pragma warning disable xUnit1013 // Public method should be marked as test

using System.Threading.Tasks;
using Xunit;

public class xUnit1030
{
    [Fact]
    public async void TestMethod_Async()
    {
        await Task.Delay(1).ConfigureAwait(false);
    }

    [Theory]
    [InlineData(42)]
    public void TestMethod_NonAsync(int delay)
    {
        Task.Delay(delay).ConfigureAwait(true).GetAwaiter().GetResult();
    }

    public class MyFactAttribute : FactAttribute { }

    [MyFact]
    public async void TestMethod_Ignored()
    {
        await Task.Delay(1).ConfigureAwait(false);
    }

    public async void NonTestMethod()
    {
        await Task.Delay(1).ConfigureAwait(false);
    }
}
