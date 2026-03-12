using Xunit;

public class xUnit9003 : IClassFixture<TooManyCtors>
{
    [Fact]
    public void TestMethod() { }
}

[CollectionDefinition]
public class xUnit9003_CollectionDefinition : ICollectionFixture<TooManyCtors>, IClassFixture<TooManyCtors>
{ }

public class TooManyCtors
{
    public TooManyCtors() { }
    public TooManyCtors(int _) { }
}
