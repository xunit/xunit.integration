using Xunit;

public class xUnit9013
{
    class DataSourceClass
    {
        public static TheoryData<int> DataSource => [42];
    }

    [Theory]
    [MemberData(nameof(DataSourceClass.DataSource), MemberType = typeof(DataSourceClass))]
    public void TestMethod(int _)
    { }
}
