#pragma warning disable CS8618

using Xunit;

public class xUnit1017
{
    public TheoryData<string, int> TestData;

    [Theory]
    [MemberData(nameof(TestData))]
    public void TestMethod(string _1, int _2) { }
}
