using System;
using System.Threading.Tasks;
using Xunit;

public class xUnit1051
{
    [Fact]
    public async ValueTask TestMethod()
    {
        await Task.Delay(1);
        await Record.ExceptionAsync(() => Task.Delay(1));
        await Assert.ThrowsAsync<InvalidOperationException>(() => Task.Delay(1));
        Assert.Collection(
            Array.Empty<int>(),
            x => Task.Delay(1),
            x => Task.Delay(2)
        );

        var _ = async () => await Task.Delay(1);
        Task LocalMethod() => Task.Delay(1);
    }
}
