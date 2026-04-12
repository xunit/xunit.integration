using Xunit;
using Xunit.v3;

public class xUnit1057_BeforeAfter
{
    [Fact, MyBeforeAfter]
    public void TestMethod() { }

    class MyBeforeAfter : BeforeAfterTestAttribute { }
}

[CollectionDefinition]
public class xUnit1057_Collection : ICollectionFixture<xUnit1057_Collection.PrivateClass>
{
    class PrivateClass { }
}

public class xUnit1057_SkipExceptions
{
    [Fact(SkipExceptions = new[] { typeof(PrivateException) })]
    public void TestMethod1() { }

    [Fact(SkipExceptions = [typeof(PrivateException)])]
    public void TestMethod2() { }

    class PrivateException { }
}

public class xUnit1057_MemberData
{
    [Theory]
    [MemberData(nameof(DataSourceClass.DataSource), MemberType = typeof(DataSourceClass))]
    public void TestMethod(int _)
    { }

    class DataSourceClass
    {
        public static TheoryData<int> DataSource => [42];
    }
}
