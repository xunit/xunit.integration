using System.Threading.Tasks;
using Xunit;

public class xUnit1028
{
    [Fact]
    public int InvalidReturnType()
    {
        return 42;
    }

    // This shouldn't trigger, because v3 supports ValueTask
    [Fact]
    public ValueTask SupportedTaskReturnType()
    {
        return default;
    }
}
