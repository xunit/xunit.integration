using Xunit;

public class xUnit1036
{
    public static TheoryData<int> TestData(int n) =>
        new() { n };

    [Theory]
    [MemberData(nameof(TestData), 42, 2112)]
    public void TestMethod(int _)
    { }
}
