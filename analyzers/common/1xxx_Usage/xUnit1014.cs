#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using Xunit;

public class xUnit1014
{
    public static TheoryData<string, int> TestData;

    [Theory]
    [MemberData("TestData")]
    public void TestMethod(string _1, int _2) { }
}
