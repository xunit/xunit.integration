#pragma warning disable xUnit1033
#pragma warning disable xUnit1073

using Xunit;

public class xUnit1056 : IClassFixture<TooManyCtors>
{
    [Fact]
    public void TestMethod() { }
}

[CollectionDefinition("Foo")]
public class xUnit1056_CollectionDefinition : ICollectionFixture<TooManyCtors>, IClassFixture<TooManyCtors>
{ }

public class TooManyCtors
{
    public TooManyCtors() { }
    public TooManyCtors(int _) { }
}
