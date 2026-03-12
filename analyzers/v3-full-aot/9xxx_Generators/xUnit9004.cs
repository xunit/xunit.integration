using Xunit;
using Xunit.v3;

public class xUnit9004_BeforeAfter
{
    [Fact, MyBeforeAfter]
    public void TestMethod() { }

    class MyBeforeAfter : BeforeAfterTestAttribute { }
}

[CollectionDefinition]
public class xUnit9004_Collection : ICollectionFixture<xUnit9004_Collection.PrivateClass>
{
    class PrivateClass { }
}

public class xUnit9004_SkipExceptions
{
    [Fact(SkipExceptions = [typeof(PrivateException)])]
    public void TestMethod() { }

    class PrivateException { }
}
