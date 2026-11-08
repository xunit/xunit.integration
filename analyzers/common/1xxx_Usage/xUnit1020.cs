#pragma warning disable CS8618
#pragma warning disable xUnit1053

using Xunit;

public class xUnit1020
{
    public static TheoryData<string, int> TestData { private get; set; }

    [Theory]
    [MemberData(nameof(TestData))]
    public void TestMethod(string _1, int _2) { }
}
