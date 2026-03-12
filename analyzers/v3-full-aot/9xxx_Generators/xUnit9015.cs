using Xunit;

public class xUnit9015
{
    public static TheoryData<int> DataSource(int multiplier) => [42 * multiplier];

    [Theory]
    [MemberData(nameof(DataSource))]
    public void TestMethod(int _)
    { }
}
