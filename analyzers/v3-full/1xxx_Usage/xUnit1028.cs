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

    // This shouldn't trigger, because v3 supports ValueTask
    [Fact]
    public ValueTask ValueTaskSupportedInV3()
    {
        return default;
    }

    [Fact]
    public ValueTask<int> InvalidGenericValueTaskReturnType()
    {
        return new(42);
    }
}
