using Xunit;

public class xUnit1067
{
    public static TheoryData<int> DataSource(int multiplier) => [42 * multiplier];

    [Theory]
    [MemberData(nameof(DataSource))]
    public void TestMethod(int _)
    { }
}
