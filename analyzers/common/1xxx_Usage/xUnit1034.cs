using Xunit;

public class xUnit1034
{
    public static TheoryData<string> TestData(int n, string s) =>
        new() { $"Hello {s}! x {n}" };

    [Theory]
    [MemberData(nameof(TestData), 2112, null)]
    public void TestMethod(string _)
    { }
}
