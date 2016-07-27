using Xunit;

public abstract class AbstractTestClass
{
    [Fact]
    public void TestHasSourceInfo() { } // made concrete by v2x_net45_referencingproject; should not show under v2x_net45, not in the External category
}
