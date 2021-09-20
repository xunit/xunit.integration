#pragma warning disable xUnit1026 // Theory methods should use all of their parameters

using Xunit;

public class xUnit1011
{
    [Theory]
    [InlineData("Hello world", 42)]
    public void TestMethod(string greeting) { }
}
