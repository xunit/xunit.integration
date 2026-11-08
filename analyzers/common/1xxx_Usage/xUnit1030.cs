#pragma warning disable xUnit1013
#pragma warning disable xUnit1031
#pragma warning disable xUnit1051
#pragma warning disable xUnit3003

using System;
using System.Threading.Tasks;
using Xunit;

public class xUnit1030
{
    [Fact]
    public async Task TestMethod_Async()
    {
        var trueValue = true;

        await Task.Delay(1).ConfigureAwait(false);
        await Task.Delay(1).ConfigureAwait(1 == 0);
        await Task.Delay(1).ConfigureAwait(1 == 1);
        await Task.Delay(1).ConfigureAwait(trueValue);

        // Shouldn't trigger in lambda or local function
        Action _ = async () => await Task.Delay(1).ConfigureAwait(false);
        async void LocalFunction() => await Task.Delay(1).ConfigureAwait(false);
    }

    [Theory]
    [InlineData(42)]
    public void TestMethod_NonAsync(int delay)
    {
        var trueValue = true;

        Task.Delay(delay).ConfigureAwait(false).GetAwaiter().GetResult();
        Task.Delay(delay).ConfigureAwait(1 == 0).GetAwaiter().GetResult();
        Task.Delay(delay).ConfigureAwait(1 == 1).GetAwaiter().GetResult();
        Task.Delay(delay).ConfigureAwait(trueValue).GetAwaiter().GetResult();

        // Shouldn't trigger in lambda or local function
        Action _ = () => Task.Delay(delay).ConfigureAwait(false).GetAwaiter().GetResult();
        void LocalFunction() => Task.Delay(1).ConfigureAwait(false).GetAwaiter().GetResult();
    }

#if !XUNIT_AOT

    public class MyFactAttribute : FactAttribute { }

    [MyFact]
    public async Task TestMethod_Ignored()
    {
        await Task.Delay(1).ConfigureAwait(false);
    }

#endif

    public async Task NonTestMethod()
    {
        await Task.Delay(1).ConfigureAwait(false);
    }

#if NET80_OR_GREATER

    [Fact]
    public async Task TestMethodWithOptionsEnum()
    {
        await Task.Delay(1).ConfigureAwait(ConfigureAwaitOptions.SuppressThrowing);
    }

#endif
}
