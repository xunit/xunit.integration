#pragma warning disable CS8618
#pragma warning disable xUnit1053

using Xunit;

public class xUnit1014
{
    public static TheoryData<string, int> TestData;

    [Theory]
    [MemberData("TestData")]
    public void TestMethod(string _1, int _2) { }
}
