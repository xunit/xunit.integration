#pragma warning disable CS8618

using Xunit;

public class xUnit1015
{
    public static TheoryData<string, int> TestData;

    [Theory]
    [MemberData("MyTestData")]
    public void TestMethod(string _1, int _2) { }
}
