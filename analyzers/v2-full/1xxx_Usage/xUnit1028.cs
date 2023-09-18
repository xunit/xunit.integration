using System.Threading.Tasks;
using Xunit;

public class xUnit1028
{
    [Fact]
    public int InvalidReturnType()
    {
        return 42;
    }

    [Fact]
    public Task<int> InvalidGenericTaskReturnType()
    {
        return Task.FromResult(42);
    }

    // This should trigger, because ValueTask is not supported by v2 (only Task)
    [Fact]
    public ValueTask ValueTaskUnsupportedInV2()
    {
        return default;
    }
}
