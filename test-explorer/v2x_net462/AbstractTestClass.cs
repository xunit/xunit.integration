using Xunit;

public abstract class AbstractTestClass
{
    [Fact]
    public void TestHasSourceInfo() { } // made concrete by v2x_net462_ReferencingProject; should not show under v2x_net462, not in the External category
}

public abstract class GenericAbstractTestClass<T>
{
    [Fact]
    public void TestHasSourceInfo() { } // made concrete by v2x_net462_ReferencingProject; should not show under v2x_net462, not in the External category
}