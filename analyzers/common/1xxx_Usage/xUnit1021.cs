#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using Xunit;

public class xUnit1021
{
    public static TheoryData<int> TestData { get; set; }

    [Theory]
    [MemberData(nameof(TestData), "Hello world", 123)]
    public void TestMethod(int _) { }
}
