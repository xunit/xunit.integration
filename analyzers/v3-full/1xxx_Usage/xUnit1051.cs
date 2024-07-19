using System.Threading.Tasks;
using Xunit;

public class xUnit1051
{
    [Fact]
    public async ValueTask TestMethod()
    {
        await Task.Delay(1);
    }
}
