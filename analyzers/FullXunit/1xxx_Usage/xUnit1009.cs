#pragma warning disable xUnit1026 // Theory methods should use all of their parameters

using Xunit;

public class xUnit1009
{
    [Theory]
    [InlineData("Hello world")]
    public void TestMethod(string greeting, int age = 42) { }
}
