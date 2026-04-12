using Xunit;

public class xUnit1065
{
    public static TheoryData<int> DataSource(string x = "Hello") => [x.Length];
    public static TheoryData<int> DataSource(int multiplier = 1) => [42 * multiplier];

    [Theory]
    [MemberData(nameof(DataSource))]
    public void TestMethod(int _)
    { }
}
