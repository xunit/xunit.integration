using Xunit;

public class xUnit9012
{
    public static TheoryData<int> DataSource() => DataSource(1);
    public static TheoryData<int> DataSource(int multiplier) => [42 * multiplier];

    [Theory]
    [MemberData(nameof(DataSource))]
    public void TestMethod(int _)
    { }
}
