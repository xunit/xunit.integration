using Xunit;

public class xUnit1035
{
    public static TheoryData<string> TestData(string n) =>
        new() { n };

    [Theory]
    [MemberData(nameof(TestData), new object[] { 2112 })]
    public void TestMethod(string _)
    { }
}
