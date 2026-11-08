#pragma warning disable CS8618
#pragma warning disable xUnit1053

using Xunit;

public class xUnit1021
{
    public static TheoryData<int> TestData { get; set; }

    [Theory]
    [MemberData(nameof(TestData), "Hello world", 123)]
    public void TestMethod(int _) { }
}
